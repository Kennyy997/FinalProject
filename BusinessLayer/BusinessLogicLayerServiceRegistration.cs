using Academy.BusinessLogicLayer.Services;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieFinalProject.DataAccessLayer;
using MovieFinalProjectBusinessLogicLayer.Services;
using MovieFinalProjectBusinessLogicLayer.Services.Contracts;

namespace MovieFinalProject.BusinessLogicLayer
{
    public static class BusinessLogicLayerServiceRegistration
    {
        public static IServiceCollection RegisterBusinessLogicLayerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICrudService<,,,>), typeof(CrudManager<,,,>));
            services.AddScoped<IMovieService, MovieManager>();
            services.AddScoped<IActorService, ActorManager>();
            services.AddScoped<IReviewService, ReviewManager>();
            services.AddScoped<IGenreService, GenreManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<IQualityService, QualityManager>();
            services.AddScoped<IRatingService, RatingManager>();
            services.AddAutoMapper(typeof(BusinessLogicLayerServiceRegistration));
            return services;
        }
    }
}
