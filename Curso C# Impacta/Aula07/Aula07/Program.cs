using System;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string senhaInformada = string.Empty;
            //string senha = "123";
            //while (senha != senhaInformada)
            //{
            //    Console.WriteLine("Digite a senha:");
            //    senhaInformada = Console.ReadLine();
            //}

            //Console.WriteLine("FIm");

            string senhaInformada = string.Empty;
            string senha = "123";
            do
            {
                Console.WriteLine("Digite a senha:");
                senhaInformada = Console.ReadLine();
                if (senhaInformada != senha)
                {
                    Console.WriteLine("Senha Incorreta");
                }
                
            } while (senha != senhaInformada);
        }
    }
}
