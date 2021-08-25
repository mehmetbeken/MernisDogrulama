using MernisDogrulama.Abstract;
using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Consrete
{
    class GamerManager : IGamerService
    {
        IVerificationService _verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }
        public void Add(Gamer gamer)
        {
            if (_verificationService.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine(" BULUNAMADI!!");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "   : Oyuncusu Silindi ");
        }

        public void Update(Gamer gamer)
        {
            if (_verificationService.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Güncelleme Başarısız");
            }
         
        }
    }
}
