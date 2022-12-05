using System;

namespace Lab2___Tema2
{
    /*• Ex 2: 
     * Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            do
            {
                factorial = factorial * n;
                n = n - 1;
            }
            while (n != 0);
            Console.WriteLine("n factorial este: {0}", factorial);
        }
    }
}
