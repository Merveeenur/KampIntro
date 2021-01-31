using GameProject2.Abstract;
using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Concrete
{
    class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("kayıt oluşturuldu");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Id +" nolu kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Id + " nolu  kayıt güncellendi");
        }
    }
}