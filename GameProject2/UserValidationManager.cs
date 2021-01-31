using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "merve" && gamer.LastName == "teke" && gamer.IdentityNumber == 123456789)
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
