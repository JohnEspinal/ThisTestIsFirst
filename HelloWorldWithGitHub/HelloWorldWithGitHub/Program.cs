using System;

namespace HelloWorldWithGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "I am ", "a daydreamer ", "and night as well" };

            for (int i = 0; i <= array.Length-1; i++)
            {
                Console.Write(array[i]);
            }

            Console.ReadKey();
        }
    }
}
