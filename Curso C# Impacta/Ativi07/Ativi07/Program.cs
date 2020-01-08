using System;

namespace Ativi07
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            Console.Write("Qual a tabuada desejada: ");
            tabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", tabuada, i, tabuada * i);
            }
            Console.ReadLine();
        }
    }
}
