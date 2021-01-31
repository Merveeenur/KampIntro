using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {

            if (gamer.Id == 1 && gamer.BirthYear == 1996 && gamer.FirstName == "GİZEM" && gamer.LastName == "BOSTAN" &&
                gamer.IdentityNumber == 12345)
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

