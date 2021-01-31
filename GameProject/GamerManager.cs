using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //microservice
    class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer))
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
            Console.WriteLine("kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
