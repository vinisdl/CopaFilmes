using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CopaFilmes.API.Service;
using CopaFilmes.API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public MovieController(IMovieWorldCupService movieWorldCupService)
        {
            _movieWorldCupService = movieWorldCupService;
        }

        private readonly IMovieWorldCupService _movieWorldCupService;

        // GET: api/Movie
        [HttpGet]        
        public async Task<ActionResult<List<MovieViewModel>>> Get()
        {
            return (await _movieWorldCupService.GetMovies())
                .ToList();
        }
    }
}