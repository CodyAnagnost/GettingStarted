using System;

namespace Largest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the first number: ");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second number: ");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Third number: ");
            int Third = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            if (First < Second)
            {
                count++;
                if (Second < Third)
                    count++;
            }

            
            Console.WriteLine("Number " + count + " is the greatest");        }
    }
}
