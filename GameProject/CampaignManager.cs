using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICompaignManegerService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("kampanya güncellendi");
        }
    }
}
