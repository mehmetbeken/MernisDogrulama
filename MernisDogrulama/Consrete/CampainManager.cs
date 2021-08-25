using MernisDogrulama.Abstract;
using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Consrete
{
    class CampainManager : ICampainService
    {
        public void Add(Campain campain)
        {
            Console.WriteLine
                (campain.CampainName + "isimli kampanya" + campain.CampainDateTime + "tarihinde %"
                + campain.CampainDiscount + "indrim oranıyla sistemimize eklenmiştir");
        }

        public void Delete(Campain campain)
        {
            Console.WriteLine(campain.CampainName + " isimli kampanya " + campain.CampainDateTime +
                 " tarihinde sistemden silinmiştir. ");
        }

        public void Update(Campain campain)
        {
            Console.WriteLine(campain.CampainName + " isimli kampanya " + campain.CampainDateTime +
                " tarihinde güncellenmiştir ");
        }
    }
}
