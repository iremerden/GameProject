using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());
            gamerManager.Add(new Gamer
            {
                GamerId = 01,
                FirstName = "Axel",
                LastName = "Lee",
                DateOfBirth = 1997,
                NationalIdentitiyNumber = 123456789
            });

            GamerManager gamerManager2 = new GamerManager(new NewEStateValidationManager());
            gamerManager.Update(new Gamer
            {
                GamerId = 02,
                FirstName = "Blue",
                LastName = "Johnson",
                DateOfBirth = 1995,
                NationalIdentitiyNumber = 9876543210
            });

            GamesManager gamesManager = new GamesManager();
            gamesManager.Add(new Games
            {
                GameId = 011,
                GameName = "Senua's Sacrifice",
                DateOfRelease = 2019,
                AgeLimit = 18
            });

            GamesManager gamesManager2 = new GamesManager();
            gamesManager2.Delete(new Games
            {
                GameId = 012,
                GameName = "God Of War III",
                DateOfRelease = 2018,
                AgeLimit = 18
            });


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaignId = 1,
                CampaignName = "Great February Discount",
                DateOfDeadLine = "End Of February",
                RateOfDiscount = 55
            });


            
        }
    }
}
