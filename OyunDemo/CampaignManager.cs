using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDemo
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine( "  Added");

        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updated");
        }
    }
}
