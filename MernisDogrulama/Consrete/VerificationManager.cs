using MernisDogrulama.Abstract;
using MernisDogrulama.Adapter;
using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Consrete
{
    class VerificationManager : IVerificationService
    {
        IVerificationService _verificationService;
        public bool CheckIfRealPerson(Gamer gamer)
        {
            _verificationService = new MernisServiceAdapter();

            return _verificationService.CheckIfRealPerson(gamer);
        }
    }
}
