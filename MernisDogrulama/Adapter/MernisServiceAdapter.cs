using MernisDogrulama.Abstract;
using MernisDogrulama.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Adapter
{
    class MernisServiceAdapter : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId),
            gamer.FirstName.ToUpper(),
            gamer.LastName.ToLower(),
            gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
