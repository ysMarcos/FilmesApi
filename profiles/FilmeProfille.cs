using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.profiles
{
    public class FilmeProfille : Profile
    {
        public FilmeProfille()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, UpdateFilmeDto>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}