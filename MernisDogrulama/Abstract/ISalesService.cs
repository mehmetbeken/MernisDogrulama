using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Abstract
{
   public interface ISalesService
    {
        void Sale(Gamer gamer,Game game,Campain campain);
    }
}
