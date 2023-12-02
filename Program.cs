using GameStore.Api.Data;
using GameStore.Api.Endpoints;
using GameStore.Api.Repositories;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();

string? connString = builder.Configuration.GetConnectionString("GameStoreContext");
builder.Services.AddSqlServer<GameStoreContext>(connString);

WebApplication app = builder.Build();

app.MapGamesEndpoints();

app.Run();
