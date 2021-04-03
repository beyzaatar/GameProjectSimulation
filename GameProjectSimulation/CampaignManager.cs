using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya girişi yapıldı");
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
