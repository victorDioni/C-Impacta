using System;

namespace Aula05.Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            decimal resul = quantidade * valor;

            Console.WriteLine("Total da Compra: {0:c}", resul);
            Console.ReadLine();

             
        }
    }
}
