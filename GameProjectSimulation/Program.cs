using System;

namespace GameProjectSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "beyza",
                LastName = "atar",
                IdentityNumber = 12345
            };
            UserValidationManager userValidationManager = new UserValidationManager();

            GamerManager gamerManager = new GamerManager(userValidationManager);

            gamerManager.Add(gamer1);
            

            
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
            orderManager.Addsale(order1, gamer1, campaign1);
            orderManager.Sale(order1, gamer1);





        }
    }
}
