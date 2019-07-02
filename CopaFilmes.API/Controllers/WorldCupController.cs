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
using CopaFilmes.API.Service;
using AutoMapper;

namespace CopaFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldCupController : ControllerBase
    {
        public WorldCupController(IMovieWorldCupService movieWorldCupService, IMapper mapper)
        {          
            _movieWorldCupService = movieWorldCupService;
            _mapper = mapper;
        }

        private readonly IMovieWorldCupService _movieWorldCupService;
        private readonly IMapper _mapper;

        // GET: api/WorldCup
        [HttpGet]
        [Route("GetWinner")]
        public async Task<ActionResult<List<MovieViewModel>>> GetWinner(List<string> moviesIds)
        {            

            var moviesViewModel = (await _movieWorldCupService.GetMovies())
                .Where(a => moviesIds.Contains(a.Id));

            var movies = _mapper.Map<List<Movie>>(moviesViewModel);

            var worldCup = new WorldCup(movies);
            if (!worldCup.IsValid())
                return UnprocessableEntity();

            return _mapper.Map<List<MovieViewModel>>(worldCup.RunCup());
        }
    }
}
