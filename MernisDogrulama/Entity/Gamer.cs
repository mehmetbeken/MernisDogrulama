using MernisDogrulama.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Entity
{
    public class Gamer:IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public long NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
