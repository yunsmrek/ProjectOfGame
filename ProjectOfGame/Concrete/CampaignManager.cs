using ProjectOfGame.Entities;
using ProjectOfGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOfGame.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " added at " + campaign.StartDate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " deleted at" + campaign.StartDate);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " updated at " + campaign.StartDate);
        }
    }
}
