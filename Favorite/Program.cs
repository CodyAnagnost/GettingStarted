using System;

namespace Favorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite food? ");
            String food = Console.ReadLine();

            if (food != "pizza")
                Console.WriteLine("Ew discusting thats gross i cant believe youd even say that like ew thats so gross ima gonna gag. Youre fav food should be pizza!! ");
            else
                Console.WriteLine("Very good choice boi");
        }
    }
}
