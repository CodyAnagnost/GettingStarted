using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int att = 0;
            while (att < 3) 
            {
                Console.WriteLine("Input a Username ");
                String username = Console.ReadLine();
                if (username != "root")
                {

                    att++;
                    Console.WriteLine("Input a Password");
                }


                
                String shword = Console.ReadLine();
                if (shword != "letmein")
                {
                    
                    temp++;
                }
                else
                {
                    Console.WriteLine("uR in Kid");
                    
                }
            }

            if (att == 3 || temp == 3)

            {
                Console.WriteLine("ur locked out fool");

            }
        }
    }
}
