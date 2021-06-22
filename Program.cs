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
            // não funciona pois nao tem tratamento de exceções
            // ContaCorrente conta = new ContaCorrente(7480,874150);
            // Console.WriteLine(ContaCorrente.TaxaOperacao);
            Metodo();

            Console.ReadLine();
        }

        // teste com a cadeia de chamada:
        // metodo -> Testa divisão -> dividir
        private static void Metodo(){
            TestaDivisao(0);
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor){
            int resultado = Dividir(10,divisor);
            Console.WriteLine("resultado da divisão de 10 por "+ divisor +" é "+ resultado);
        }

        private static int Dividir(int numero, int divisor){
           if(divisor == 0){
               return -1;
           }
           return numero / divisor;
        }
    }
}
