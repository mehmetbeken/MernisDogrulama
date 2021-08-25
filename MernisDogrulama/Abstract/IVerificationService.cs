using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Abstract
{
    public interface IVerificationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
