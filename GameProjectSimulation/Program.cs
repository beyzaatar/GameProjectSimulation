using System;

namespace GameProjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1998, FirstName = "beyza", LastName = "atar", IdentityNumber = 12345 });

            Order order1 = new Order()
            {
                Id = 1,
                GameName = "clash of royal",
                GamePrice = 150
            };

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "yaz indirimi",
                Discount = 50,
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign1);

            OrderManager orderManager = new OrderManager();




        }
    }
}
