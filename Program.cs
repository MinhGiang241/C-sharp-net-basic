using GameStore.Api.Data;
using GameStore.Api.Endpoints;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddRepositories(builder.Configuration);

WebApplication app = builder.Build();

app.Services.InitializeDb();

app.MapGamesEndpoints();

app.Run();
