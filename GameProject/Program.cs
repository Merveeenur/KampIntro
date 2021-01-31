using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1996, FirstName = "GİZEM", LastName = "BOSTAN", IdentityNumber = 12345 });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { CampaignId = 1, CampaignName = "indirim", CampaignPrice = 35, CampaignStock = 87 });

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(new Gamer(),new Campaign());

        }
    }
}
