using MernisDogrulama.Consrete;
using MernisDogrulama.Entity;
using System;

namespace MernisDogrulama
{
    class Program

    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.GameName = "Counter-Strike";
            game1.GamePrice = 300;
            game1.GameCategory = "Action";

            Game game2 = new Game();
            game2.GameName = "Fifa";
            game2.GamePrice = 400;
            game2.GameCategory = "sports";

            Campain campain1 = new Campain();
            campain1.CampainName = "Bayram Kampanyası";
            campain1.CampainDiscount = 25;
            campain1.CampainDateTime = new DateTime(2016, 12, 10);

            Campain campain2 = new Campain();
            campain2.CampainName = "Bahar Kampanyası";
            campain2.CampainDiscount = 50;
            campain2.CampainDateTime = new DateTime(2020, 10, 10);

            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Mehmet";
            gamer1.LastName = "Beken";
            gamer1.NationalityId = 33712992882;
            gamer1.DateOfBirth = new DateTime(1998, 2, 15);

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Hasan";
            gamer2.LastName = "Karagöz";
            gamer2.NationalityId = 12345678912;
            gamer2.DateOfBirth = new DateTime(1992, 3, 18);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

            CampainManager campainManager = new CampainManager();
            campainManager.Add(campain1);
            campainManager.Add(campain2);

            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(gamer1, game1, campain1);
            salesManager.Sale(gamer2, game2, campain2);





        }
    }
}
