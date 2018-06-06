using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            var dealer = new Player("AI", deck);
            bool play = true;
            System.Console.WriteLine("Welcome please input your name: \n");
            string player1Name = Console.ReadLine();
            var player1 = new Player(player1Name, deck);
            var welcomeStatement = String.Format(@"Welcome {0} lets play some Black Jack", player1.name);
            System.Console.WriteLine(welcomeStatement);
            
            while(play){
                    /* black jack game */
            }


        }
    }
}
