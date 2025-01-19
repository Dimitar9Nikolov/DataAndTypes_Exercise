using System;

namespace _03_ExeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int coursesCount = 0;
            bool empty = false;

            if (people <= capacity)
            {
                empty = true;
                coursesCount++;
            }
           
            while (people > 0)
              {
                  if (empty == true)
                  {
                      break;
                  }
                  people -= capacity;
                  coursesCount++; 
              }
            Console.WriteLine(coursesCount);
        }
    }
}
