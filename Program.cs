using GameProject_K.Entities;
using GameProject_K.Abstract;
using System;
using GameProject_K.Concrete;

namespace GameProject_K
    {
   public class Program
        {
        static void Main(string[] args)
            {
            Gamer gamer1 = new Gamer();
            gamer1.gamerId = 6060;
            gamer1.gamerName = "Muhammed Tayyib";
            gamer1.gamerPassword = "1234";
            gamer1.gamerMail = "60mts@60mts.com.tr";
            gamer1.auth = true;

            Gamer gamer2 = new Gamer();
            gamer2.gamerId = 606010;
            gamer2.gamerName = "Özcan Öner";
            gamer2.gamerPassword = "12345";
            gamer2.gamerMail = "ozcanoner@60mts.com.tr";
            gamer2.auth = false;

            Gamer gamer3 = new Gamer();
            gamer3.gamerId = 606010;
            gamer3.gamerName = "Onur can Atar";
            gamer3.gamerPassword = "12345s";
            gamer3.gamerMail = "onurcanatar@60mts.com.tr";
            gamer3.auth = false;

            if (gamer1.auth == true)
                {
                Console.WriteLine("Sayın" +"  "+ gamer2.gamerName + " "+"Hesabınız doğrulanmış.");               
                    }
            else
                {
                Console.WriteLine("Sayın" +"  "+ gamer2.gamerName +" "+ "Hesabınız doğrulanmamış.Lütfen kısa süre içinde doğrulayın.");
                }

            Campaign campaign1 = new Campaign();
            campaign1.campaingId = 0001;
            campaign1.campaingName = "1 numaralı kampanya";
            campaign1.campaingFinishDate = new DateTime(2021, 8, 29, 19, 27, 15);
            campaign1.campaingContent = "Kaçmaz bu fırsat! 2 Oyun alana 3 oyun hediye!";

            Game game1 = new Game();
            game1.gameName = "Super Mario";
            game1.gameDescription = "Kraliçeyi düşmandan kurtarma oyunu ";
            game1.gamePrice = 500;
            game1.gameCategory = "Video Oyun Serisi";
            game1.gameProducer = "Nintendo";

            Game game2 = new Game();
            game2.gameName = "amiral battı";
            game2.gameDescription = "Yer tahmini yaparak gemi vurma oyunu";
            game2.gamePrice = 1000;
            game2.gameCategory = "Strateji";
            game2.gameProducer = "Peter Berg ";

            GameManager gamer = new GameManager();
          



            }
        }
    }
