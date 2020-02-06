using System;

namespace oHappy
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "The capital of the Great Britain","What is the square root of 256",
                "Н2О. This is the formula of what","How many planets in the solar system", "2018 World Cup Champion" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
