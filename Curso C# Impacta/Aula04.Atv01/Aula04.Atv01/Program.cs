using System;

namespace Aula04.Atv01
{
    // Classe
    class Program
    {   
        //Método Principal
        static void Main(string[] args)
        {
            //Somar dois numeros
            int n1, n2, resul;

            //Obtendo os valores
            Console.Write("Digite o 1° número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Processar
            resul = n1 + n2;

            //Exibir
            Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, resul);
            Console.ReadLine();


        }
    }
}
