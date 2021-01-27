using ProjectOfGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOfGame.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void SellGame(Game game,Player player,Campaign campaign);
    }
}
