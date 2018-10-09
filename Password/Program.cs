using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {

            int att = 0;
            while (att < 3) 
            {
                Console.WriteLine("Input a username loser ");
                String username = Console.ReadLine();
                if (username != "root")
                {
                    Console.WriteLine("well thats not right");
                    att++;
                }

                else
                {
                    Console.WriteLine("Correct");
                }


                Console.WriteLine("Now gimmy ya shword ");
                String shword = Console.ReadLine();
                if (shword != "letmein")
                {
                    Console.WriteLine("well thats still not right");
                    att++;
                }
                else
                {
                    Console.WriteLine("uR in Kid");
                    break;
                }
            }

            if (att == 3)

            {
                Console.WriteLine("ur locked out fool");
            }
        }
    }
}
