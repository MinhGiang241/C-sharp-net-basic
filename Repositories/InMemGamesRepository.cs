using GameStore.Api.Entities;

namespace GameStore.Api.Repositories;

public class InMemGamesRepository
{

    private readonly List<Game> games = new List<Game>
  {
  new Game(){
    Id=1,
    Name="Street Fighter II",
    Genre="Fighting",
    Price=19.19M,
    releaseDate= new DateTime(1992,1,24),
    ImageUri="https://source.unsplash.com/random/100x100"
  },
  new Game(){
    Id=2,
    Name="Final Fantasy XIV",
    Genre="Fighting",
    Price=69.19M,
    releaseDate= new DateTime(2007,10,27),
    ImageUri="https://source.unsplash.com/random/100x100"
  },
    new Game(){
    Id=3,
    Name="FIFA 23",
    Genre="Fighting",
    Price=59.99M,
    releaseDate= new DateTime(2010,9,30),
    ImageUri="https://source.unsplash.com/random/100x100"
  }

  };

    public IEnumerable<Game> GetAll()
    {
        return games;
    }

    public Game Get(int id)
    {
        return games.Find(game => game.Id == id);
    }

    public void Create(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public void Update(Game updatedGame)
    {
        var index = games.FindIndex(game => game.Id == updatedGame.Id);
        games[index] = updatedGame;
    }

    public void Delete(int id)
    {
        var index = games.FindIndex(game => game.Id == id);
        games.RemoveAt(index);
    }

}


