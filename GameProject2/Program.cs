using GameProject2.Concrete;
using GameProject2.Entities;
using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1996, FirstName = "merve", LastName = "teke", IdentityNumber = 123456789 });
            gamerManager.Delete(new Gamer { Id = 1, BirthYear = 1996, FirstName = "merve", LastName = "teke", IdentityNumber = 123456789 });
            gamerManager.Update(new Gamer { Id = 2, BirthYear = 1996, FirstName = "merve", LastName = "teke", IdentityNumber = 123456789 });





            CampaignManager campaignManager = new CampaignManager();
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager.Add(new Campaign()   
            { Id = 1,
                CampaignName = "Yaz Kampanyası",
                CampaignType = "Öğrenci İndirimi",
            });
            campaignManager1.Delete(new Campaign()
            {
                Id = 2,
                CampaignName = "Kış Kampanyası",
                CampaignType = "Çalışan İndirimi",
            });
            campaignManager1.Update(new Campaign()
            {
                Id = 3,
                CampaignName = "Bahar Kampanyası",
                CampaignType = "Herkes İçin İndirim",
            });

            Game game = new Game()
            {
                GameName = "Flappy bird",
                GamePrice = 30,
        };

        SaleManager saleManager = new SaleManager(new CampaignManager());
        saleManager.Add(new Gamer{Id=1}, new Game {GameName="Flappy"}, new Campaign { CampaignName = "Kış Kampanyası" });

        }
    }
}
