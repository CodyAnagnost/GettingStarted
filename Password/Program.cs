using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {

            int att = 0;

            Console.WriteLine("Input a username loser ");
            String username = Console.ReadLine();
            if(username != "root")
                Console.WriteLine("well thats not right");
            att++;


            Console.WriteLine("Now gimmy ya shword ");
            String shword = Console.ReadLine();
            if (shword != "letmein")
                Console.WriteLine("well thats still not right");
            att++;

            if (att == 3)
                
              Console.WriteLine("ur locked out fool");
           
        }
    }
}
