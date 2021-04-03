using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1998 && gamer.FirstName=="beyza"
                && gamer.LastName=="atar" && gamer.IdentityNumber==12345)
            {
                return true;

            }  
            else
            {
                return false;
            }
        }
    }
}
