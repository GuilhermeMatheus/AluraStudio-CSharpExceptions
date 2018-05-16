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
            TestaDivisao(0);
            //try
            //{ 
            //    Console.WriteLine("TRY: inicio");
            //    TestaDivisao(0);
            //    TestaDivisao(20);
            //    Console.WriteLine("TRY: fim");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Mensagem: " + ex.Message);
            //    Console.WriteLine("Rastro da pilha: " + ex.StackTrace);
            //    Console.WriteLine("Ops, erro DivideByZeroException");
            //}
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Fui capturado pelo (NullReferenceException ex)");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fui capturado pelo (Exception ex)");
                Console.WriteLine(ex.StackTrace);
            }
            
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}

            Console.WriteLine("Estou executando normalmente!");

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                Console.WriteLine("Fazendo o cálculo " + numero + " / " + divisor);
                int resultado = numero / divisor;
                Console.WriteLine("O resultado é " + resultado);
                return resultado;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro no cálculo: " + ex.Message);
                throw; // Lançar exceção

                Console.WriteLine("Depois do throw");

            }
        }

        // numero = 1
        // divisor = 2;

    }
}
