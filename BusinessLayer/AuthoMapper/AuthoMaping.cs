
using AutoMapper;
using MovieFinalProject.BusinessLogicLayer.Dtos;
using MovieFinalProject.DataContext.Entities;
using MovieFinalProjectBusinessLogicLayer.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Academy.BusinessLogicLayer.AutoMapping;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<Movie, MovieDto>()
            .ForMember(dest => dest.Genre,opt => opt.MapFrom(src => src.Genres))
            .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.Actors))
            .ReverseMap();
        CreateMap<MovieCreateDto, Movie>().ReverseMap();
        CreateMap<MovieUpdateDto, Movie>().ReverseMap();


        CreateMap<Genre, GenreDto>()
            .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Movie.Select(s => s.Id)))
            .ReverseMap();
        CreateMap<GenreCreateDto, Genre>().ReverseMap();
        CreateMap<GenreUpdateDto, Genre>().ReverseMap();

        CreateMap<Actor, ActorDto>()
            .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Name))
            .ReverseMap();
        CreateMap<ActorCreateDto, Actor>().ReverseMap();
        CreateMap<ActorUpdateDto, Actor>().ReverseMap();

        CreateMap<Country, CountryDto>()
         .ReverseMap();
        CreateMap<CountryCreateDto, Country>().ReverseMap();
        CreateMap<CountryUpdateDto, Country>().ReverseMap();

        CreateMap<Review, ReviewDto>()
            .ForMember(dest => dest.Movie, opt => opt.MapFrom(src => src.Movie))
            .ReverseMap();
        CreateMap<ReviewCreateDto, Review>().ReverseMap();
        CreateMap<ReviewUpdateDto, Review>().ReverseMap();

        CreateMap<Rating, RatingDto>()
        .ForMember(dest => dest.MovieId, opt => opt.MapFrom(src => src.Movie))
            .ReverseMap();

    }

}
