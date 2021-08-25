using MernisDogrulama.Abstract;
using MernisDogrulama.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Consrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine
                (game.GameCategory + "kategorili" + game.GameName + "isimli oyun" + game.GamePrice + "fiyata sisteme eklenmiştir");
        }

        internal void Add(GameManager gameManager)
        {
            throw new NotImplementedException();
        }

        public void Delete(Game game)
        {
            Console.WriteLine
                (game.GameCategory + "kategorili" + game.GameName + "isimli oyun" + game.GamePrice + "fiyata sistemden silinmiştir"); ;
        }

        public void Update(Game game)
        {
            Console.WriteLine
                (game.GameCategory + "kategorili" + game.GameName + "isimli oyun" + "güncellenmiştir");
        }
    }
}
