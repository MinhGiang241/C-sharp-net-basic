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
    }
}
