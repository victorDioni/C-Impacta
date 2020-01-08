using System;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Digite um número entre 1 e 10: ");
            // int n = Convert.ToInt32(Console.ReadLine());

            // if (n < 1 || n > 10 ){
            //    Console.WriteLine("Número errado!");
            // }
            //  else
            //  {
            //   Console.WriteLine("Obrigado");
            //  }

            int hora = DateTime.Now.Hour;
            if (hora > 17)
            {
                Console.WriteLine("Boa Noite");
            }else if (hora > 11){
                Console.WriteLine("Boa Tarde");
            }else
            {
                Console.WriteLine("Bom Dia");
            }

            Console.ReadLine();
        }
    }
}
