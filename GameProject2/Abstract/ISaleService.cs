using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Abstract
{
    interface ISaleService
    {
        void Add(Gamer gamer,Game game,Campaign campaign);
        void Update(Gamer gamer, Game game, Campaign campaign);
    }
}
