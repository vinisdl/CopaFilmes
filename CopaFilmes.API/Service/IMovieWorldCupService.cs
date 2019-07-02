using CopaFilmes.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.API.Service
{
    public interface IMovieWorldCupService
    {
        Task<IEnumerable<MovieViewModel>> GetMovies();
    }
}
