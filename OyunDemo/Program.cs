using System;

namespace OyunDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager ();
            Player player = new Player ();
            player.Tc = "5878522523";
            player.PersonName = "MERVE";
            player.PersonSurname = "TEKE";
            player.YearOfBirth = 1996;

            Player player2 = new Player { };
            player2.Tc = "88484878793";
            player2.PersonName = "EMİR";
            player2.PersonSurname = "TEKE";
            player2.YearOfBirth = 1996;


            playerManager.Add();
            playerManager.Delete();
            playerManager.Update();

           
        }
    }
}
