using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    class OrderManager : IOrderService
    {
        public void Sale(Order order, Gamer gamer)
        {
            Console.WriteLine("ürün fiyatı:"+order.GamePrice);
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+
                "isimli kullanıcı"+order.GameName+"oyununu satın aldı");

        }

        public void Addsale(Order order, Gamer gamer, Campaign campaign)
        {
            double newGamePrice = order.GamePrice - ((order.GamePrice
                * campaign.Discount) / 100);
            Console.WriteLine("kampanyalı oyun fiyatı:"+newGamePrice);

            Console.WriteLine(gamer.FirstName
                + " " + gamer.LastName.ToUpper() + " isimli kullanıcı "
                + order.GameName + " ürününü " + campaign.CampaignName + " kampanyası dahilinde"
                + " %" + campaign.Discount + " oranında indirimli aldı!");
        }
    }
}
