using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoContaBancaria {
    class ContaBancaria {

        public int NumConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

     

        public ContaBancaria(int numConta, string titularConta) {
            NumConta = numConta;
            TitularConta = titularConta;
        }

        public ContaBancaria(int numConta, string titularConta, double saldo) : this(numConta, titularConta) {
            Saldo = saldo;
        }
                  
        

        public void Deposito(double quantia) {
                  Saldo += quantia;
                   
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
            Saldo -= 5.0;
        }


        public override string ToString() {
            return "Conta "
                    + NumConta
                    + ", Titular: "
                    + TitularConta
                    + ", Saldo: $ "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
