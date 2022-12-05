using System;

namespace Lab2___Tema1
/*Ex 1: 
 * Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg n: ");

            int modulusCheck = 0;
            int sum = 0;

            int n = int.Parse(Console.ReadLine());


            while (n != 0)
            {
                modulusCheck = n % 10;
                n = n - modulusCheck;
                n = n / 10;
                sum = sum + modulusCheck;
            }
            Console.WriteLine("Suma cifrelor numarului dat este: {0} ", sum);
        }
    }
}
