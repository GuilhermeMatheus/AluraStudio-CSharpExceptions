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
            TentaFazerDivisao();

            Console.WriteLine("Fim da aplicação. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void TentaFazerDivisao()
        {
            FazerDivisao();
        }

        private static void FazerDivisao()
        {
            int resultado = Dividir(12, 0);
            Console.WriteLine("Fim do FazerDivisao");
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }

    }
}
