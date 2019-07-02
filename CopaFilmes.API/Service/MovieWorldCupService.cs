using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaFilmes.API.ViewModel;
using Flurl.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace CopaFilmes.API.Service
{
    public class MovieWorldCupService : IMovieWorldCupService
    {
        private readonly string _urlPath;
        private readonly IMemoryCache _memory;

        public MovieWorldCupService(IConfiguration iConfig, IMemoryCache memory)
        {
            _urlPath = iConfig.GetSection("Config").GetValue<string>("WorldCupApiUrl");
            _memory = memory;
        }
        public async Task<IEnumerable<MovieViewModel>> GetMovies()
        {
            if (_memory.TryGetValue("movies", out List<MovieViewModel> movies))
            {
                return movies;
            }
            var moviesApi = await _urlPath.GetJsonAsync<List<MovieViewModel>>();
            _memory.Set("movies", moviesApi, new TimeSpan(0, 10, 0));
            return moviesApi;
        }
    }
}
