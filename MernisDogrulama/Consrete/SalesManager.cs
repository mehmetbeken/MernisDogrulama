using MernisDogrulama.Abstract;
using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Consrete
{
    class SalesManager : ISalesService
    {
        public void Sale(Gamer gamer, Game game, Campain campain)
        {
            Console.WriteLine(gamer.FirstName + "isimli kullanıcı" + game.GameName + "oyununu satın aldı");
            Console.WriteLine(game.GameName + " isimli oyunun indirimli fiyatı =" + game.GamePrice * (campain.CampainDiscount / 100) + "TL");

        }
    }
}
