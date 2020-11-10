using System;

namespace funzione_che_converte_caratteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un carattere: ");
            char input = Convert.ToChar(Console.ReadLine());
            int value = Convert.ToInt32(input);
            Console.WriteLine($"decimal value of {input} is {value}");
            string hexOutput = String.Format("{0:X}", value);
            Console.WriteLine($"Hexadecimal value of {input} is {hexOutput}");
            string binary = Convert.ToString(input, 2);
            Console.WriteLine($"binary value of {input} is {binary}");

        }
    }
}
