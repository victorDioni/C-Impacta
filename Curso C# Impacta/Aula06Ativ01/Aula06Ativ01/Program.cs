using System;

namespace Aula06Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valorCompra, valorParcela, ValorMinimoParcelar = 1000.01m;
            int numeroParcelas = 3;

            Console.WriteLine("Digite o valor da compra: ");
            valorCompra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor a vista {0:c}", valorCompra);

            if (valorCompra >= ValorMinimoParcelar)
            {
                valorParcela = (valorCompra / numeroParcelas);
                Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da Parcela {1:c}", numeroParcelas, valorParcela);
            }
            Console.ReadLine();
        }
    }
}
