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
            int resultado = Metodo();

            if(resultado == -681)
            {
                Console.WriteLine("Tentativa de divisão de divisor maior que o numero");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static int Metodo()
        {
            int resultado1 = TestaDivisao(0);
            int resultado2 = TestaDivisao(20);

            if(resultado2 == -681)
            {
                return -681;
            }

            return 0;
        }

        private static int TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            if(resultado == -1)
            {
                Console.WriteLine("Tentativa de divisão por zero!");
            }

            if(resultado == -681)
            {
                return -681;
            }

            return 0;
        }

        private static int Dividir(int numero, int divisor)
        {
            if(divisor == 0)
            {
                return -1;
            }

            if(divisor > numero)
            {
                return -681;
            }
            
            return numero / divisor;
        }

        // numero = 1
        // divisor = 2;

    }
}
