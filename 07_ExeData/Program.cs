using System;

namespace _07_ExeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int literInTank = 0;
            int numOfLines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfLines; i++)
            {    
                int quantity = int.Parse(Console.ReadLine());
                if (quantity <= capacity)
                {
                    capacity -= quantity;
                    literInTank += quantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(literInTank);
        }
    }
}
