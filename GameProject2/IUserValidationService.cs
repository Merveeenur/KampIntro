using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
