using System;
using ProjectOfGame.Entities;
using ProjectOfGame.Abstract;
using ProjectOfGame.Concrete;
using System.Collections.Generic;
using System.Text;

namespace ProjectOfGame.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " deleted");
        }

        public void SellGame(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine(game.Name + " purchased by " + player.FirstName + " " + player.LastName + " for " + game.Price + " $ with " + campaign.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " updated");
        }
    }
}
