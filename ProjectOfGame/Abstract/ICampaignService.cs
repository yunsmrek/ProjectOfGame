using ProjectOfGame.Entities;
using ProjectOfGame.Abstract;
using ProjectOfGame.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOfGame.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
