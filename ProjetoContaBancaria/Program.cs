using System;
using System.Globalization;

namespace ProjetoContaBancaria {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.WriteLine("Entre com o Número da Conta");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Titular da Conta");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá Deposito Inicial" + "(s/n)");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com um Deposito");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }else {
                conta = new ContaBancaria(numero, titular);
            }
            
            Console.WriteLine(conta);
               
            Console.WriteLine();
            Console.WriteLine("Entre com os Dados para Saque");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);





        }
    }
}
