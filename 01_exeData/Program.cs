using System.Security.Cryptography;

namespace _01_exeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());

            int secont = int.Parse(Console.ReadLine());

            int third = int.Parse(Console.ReadLine());

            int four = int.Parse(Console.ReadLine());

            int add = first + secont;
            int devision = add / third;
            int multipy = devision * four;

            Console.WriteLine(multipy);
        }
    }
}