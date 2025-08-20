using DataAccessLayer.Repositorys;
using DataAccessLayer.Repositorys.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieFinalProject.DataAccessLayer;
using MovieFinalProject.Repositorys;

namespace MovieFinalProject.DataAccessLayer
{
    public static class DataAccessLayerServiceRegistration
    {
       public static IServiceCollection RegisterDataAccessLayerServices(this IServiceCollection services ,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
               options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped(typeof(IRepositoryasync<>), typeof(EfCoreRepository<>));
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IQualityRepository, QualityRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            return services;

        }
        

    }
}
