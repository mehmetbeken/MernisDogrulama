using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Abstract
{
   public interface ICampainService
    {
        void Add(Campain campain);
        void Update(Campain campain);
        void Delete(Campain campain);
    }
}
