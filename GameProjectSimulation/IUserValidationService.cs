using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
