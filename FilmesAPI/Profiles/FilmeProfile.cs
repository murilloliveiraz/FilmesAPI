using AutoMapper;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<FilmeDTO, Filme>();
            CreateMap<Filme, FilmeDTO>();
            CreateMap<Filme, FilmeDTOGet>();
            CreateMap<FilmeDTOGet, Filme>();
        }
    }
}
