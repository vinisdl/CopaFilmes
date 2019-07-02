using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaFilmes.Repository;
using CopaFIlmes.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flurl;
using Flurl.Http;
using CopaFilmes.API.ViewModel;

namespace CopaFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldCupController : ControllerBase
    {
        public WorldCupController(InMemoryContext ctx)
        {
            Ctx = ctx;
            UrlPath = "https://copadosfilmes.azurewebsites.net/api/filmes";
        }

        public InMemoryContext Ctx { get; }
        public string UrlPath { get; }

        // GET: api/WorldCup
        [HttpGet]
        [Route("GetWinner")]
        public async Task<ActionResult<List<Movie>>> GetWinner(string[] moviesIds)
        {
            var movies = (await UrlPath.GetJsonAsync<List<MovieViewModel>>()).Where(a => moviesIds.Contains(a.Id)).Select(m => new Movie() {
                Title = m.Title,
                Score = m.Score,
                Id = m.Id,
                ReleaseYear = m.ReleaseYear
            }).ToList();

            var worldCup = new WorldCup(movies);
            if (!worldCup.IsValid())
                return UnprocessableEntity();
            return worldCup.RunCup();
        }

    }
}
