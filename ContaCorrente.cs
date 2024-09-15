using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaHeranca_Especial
{
    public class ContaCorrente
    {
        private string nomeConta;
        private double cpfConta;

        private double saldo;

        public string NomeConta { get => nomeConta; set => nomeConta = value; }
        public double CpfConta { get => cpfConta; set => cpfConta = value; }
        public double Saldo { get => saldo; set => saldo = value; }


        public void ConsultarSaldo(double saldo)
        {
            Console.WriteLine($"Seu Saldo Atual é de: {saldo}");

        }
        public double DepositarSaldo(double valor)
        {
            double depositado = saldo += valor;
            return depositado;
        }
        public double SacarSaldo(double valor)
        {
            double saque = saldo -= valor;
            return saque;
        }

    }
}
