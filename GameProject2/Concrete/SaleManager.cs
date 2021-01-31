using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Concrete
{
    class SaleManager : ISaleService
    {
        ICampaignService _campaignService;
        public SaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;

        }
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.Id+" Numaralı müşteri "+game.GameName+" adlı oyunda "+ campaign.CampaignName+" adlı kampanyadan yararlandı ");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.Id + " Numaralı müşteri " + game.GameName + " adlı oyunda " + campaign.CampaignName + " adlı kampanyasını güncelledi ");
        }
    }
}
