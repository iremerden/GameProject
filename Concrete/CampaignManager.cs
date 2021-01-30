using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted.");
        }
    }
}
