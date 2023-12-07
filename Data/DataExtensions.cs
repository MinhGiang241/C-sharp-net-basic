using GameStore.Api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data
{
    public static class DataExtensions
    {
        public static void InitializeDb(this IServiceProvider serviceProvider)
        {
            using IServiceScope scope = serviceProvider.CreateScope();
            GameStoreContext dbContext = scope
                .ServiceProvider
                .GetRequiredService<GameStoreContext>();
            dbContext.Database.Migrate();
        }

        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            string? connString = configuration.GetConnectionString("GameStoreContext");
            _ = services
                .AddSqlServer<GameStoreContext>(connString)
                .AddScoped<IGamesRepository, EntityFrameworkGamesRepository>();
            return services;
        }
    }
}
