using System;

namespace Lab2___Tema4
{
    /*Ex 4: 
     * Scrieti un program care va determina daca un numar este sau nu
palindrom.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg cu cel putin doua cifre: ");
            string initialNumber = Console.ReadLine();
            char[] listOfCharsInNumber = initialNumber.ToCharArray();

            Array.Reverse(listOfCharsInNumber);
            string revertedNumber = new string(listOfCharsInNumber);
            //Console.WriteLine(revertedNumber);
            if (initialNumber == revertedNumber)
            {
                Console.WriteLine("numarul {0} este un palindrom", initialNumber);
            }
            else
            {
                Console.WriteLine("numarul {0} nu este un palindrom", initialNumber);
            }         
        }
    }
}
