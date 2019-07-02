using AutoMapper;
using CopaFilmes.API.ViewModel;
using CopaFIlmes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.API.Mapper
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieViewModel>()
                .ReverseMap();
        }
    }
}
