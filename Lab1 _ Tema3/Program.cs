using System;

namespace Lab1___Tema3
{
    /*Ex 3 
     * Să se scrie un program care citeşte de la tastatură un şir de n numere
naturale şi determină media aritmetică a celor pare, n fiind citit de la
tastatra
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            
            Console.WriteLine("Introduceti sapte numere naturale: ");            
            Console.WriteLine("Introduceti primul numar: ");
            array[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            array[1] = int.Parse(Console.ReadLine());     
            Console.WriteLine("Introduceti al treilea numar: ");
            array[2] = int.Parse(Console.ReadLine());         
            Console.WriteLine("Introduceti al patrulea numar: ");
            array[3] = int.Parse(Console.ReadLine());          
            Console.WriteLine("Introduceti al cincilea numar: ");
            array[4] = int.Parse(Console.ReadLine());         
            Console.WriteLine("Introduceti al saselea numar: ");
            array[5] = int.Parse(Console.ReadLine());         
            Console.WriteLine("Introduceti al saptelea numar: ");
            array[6] = int.Parse(Console.ReadLine());
            Console.WriteLine("cele sapte numere sunt: {0}, {1}, {2}, {3}, {4}, {5}, {6}", 
                array[0], array[1], array[2], array[3], array[4], array[5], array[6]);         
            
            int arithMean = 0;
            int sum = 0;
            int j = 0;

            for (int i = 0; i < 7; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum = sum + array[i];
                    j = j + 1;
                    arithMean = sum / j;
                }
            }
            Console.WriteLine("Media aritmetica a numerelor pare din sir este: " + arithMean);
        }
    }
}
