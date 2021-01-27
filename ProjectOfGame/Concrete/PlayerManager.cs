using System;
using System.Collections.Generic;
using System.Text;
using ProjectOfGame.Entities;
using ProjectOfGame.Abstract;
using ProjectOfGame.Concrete;

namespace ProjectOfGame.Concrete
{
    class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.FirstName+" "+player.LastName+" added");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " updated");
        }
    }
}

