using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager:ISalesManagerService
    {
     
       /* public void Sale(Gamer game, Campaign campaign)
        {
            Console.WriteLine(game.FirstName + "kişisine " + campaign.CampaignName + "ile satış gerçekleştirildi");
        }
       */
        public void Sale(GamerManager gamer, CampaignManager campaign)
        {
            throw new NotImplementedException();
        }
    }
}
