using MernisDogrulama.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Entity
{
    public class Campain:IEntity
    {
        public string CampainName { get; set; }
        public int CampainDiscount { get; set; }
        public DateTime CampainDateTime { get; set; }
    }
}
