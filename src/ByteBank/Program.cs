using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void Metodo()
        {
            try
            { 
                Console.WriteLine("TRY: inicio");
                TestaDivisao(0);
                TestaDivisao(20);
                Console.WriteLine("TRY: fim");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ops, erro DivideByZeroException");
            }
        }

        private static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }

        // numero = 1
        // divisor = 2;

    }
}
