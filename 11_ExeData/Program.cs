using System;
using System.Numerics;

namespace _11_ExeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal snowballCount = int.Parse(Console.ReadLine());
            decimal bestSnow = 0;
            decimal bestTime = 0;
            decimal bestQuality = 0;
            BigInteger BestValue = 0;

            for (int i = 1; i <= snowballCount; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snow / time, quality);

                if (BestValue < value)
                {
                    BestValue = value;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {BestValue} ({bestQuality})");
        }
    }
}