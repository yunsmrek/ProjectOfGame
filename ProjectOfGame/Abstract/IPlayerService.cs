using ProjectOfGame.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOfGame.Abstract
{
    interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }
}
