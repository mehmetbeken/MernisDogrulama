using MernisDogrulama.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Entity
{
    public class Game:IEntity
    {
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public string GameCategory { get; set; }
    }
}
