using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine(); // Armazenando o nome digitado

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine()); // Armazenando e convertendo

            int dias = idade * 365;

            Console.WriteLine("Eae {0}, você ja viveu {1} dias", nome, dias); // String de formatação
            Console.ReadLine();
        }
    }
}
