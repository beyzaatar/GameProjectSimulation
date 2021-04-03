using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    public interface IOrderService
    {
        void Sale(Order order, Gamer gamer);
        void Addsale(Order order, Gamer gamer, Campaign campaign);
    }
}
