using ContaHeranca_Especial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    private static void Main(string[] args)
    {
        ContaEspecial conta = new ContaEspecial();
        conta.Limite = 300;

        //BUSCAR LIMITE---------------------------------------------------------

        Console.WriteLine("Aqui esta o Limite da sua conta:");
        conta.ConsultarLimite();

        //DIMINUIDO LIMITE------------------------------------------------------

        Console.WriteLine("Quanto deseja diminuir seu Limite?");
        double valor = double.Parse(Console.ReadLine());
        double diminuido = conta.DiminuirLimite(valor);
        if (diminuido > 0)
        {
            Console.WriteLine($"O seu Limite foi alterado para: {diminuido}.");
        }
        else
        {
            Console.WriteLine("Nao foi possivel fazer alteração.");
        }

        //AUMENTANDO LIMITE-----------------------------------------------------

        Console.WriteLine("Qaunto deseja aumentar seu Limite?");
        double valor2 = double.Parse(Console.ReadLine());
        double aumento = conta.AumentarLimite(valor2);
        Console.WriteLine($"Seu Limite foi alterado para: {aumento}.");

        //----------------------------------------------------------------------
        ContaCorrente _conta = new ContaCorrente();
        _conta.NomeConta = "Icaro Michael";
        _conta.CpfConta = 62774912377;
        _conta.Saldo = 225;

        //CONSULTAR SALDO-------------------------------------------------------

        Console.WriteLine("Deseja ver aeu Saldo? \n [1]Sim ou [2]Nao");
        int resp = int.Parse(Console.ReadLine());
        if (resp == 1)
        {
            Console.WriteLine($"Seus Saldo Atual é de : {_conta.Saldo}.");
        }
        else if (resp == 2)
        {
        }
        else
        {
            Console.WriteLine("Resposta Invalida");
        }

        //DEPOSITAR-------------------------------------------------------------

        Console.WriteLine("Quanto deseja Depositar?");
        double _valor = double.Parse(Console.ReadLine());
        double depositado = _conta.DepositarSaldo(_valor);
        Console.WriteLine($"O seu deposito foi alterado para {depositado}.");

        //SACAR-----------------------------------------------------------------
        Console.WriteLine("Quanto deseja sacar?");
        double _valor2 = Double.Parse(Console.ReadLine());
        double saque = _conta.SacarSaldo(_valor2);
        Console.WriteLine($"O seu deposito foi alterado para {saque}!");

    }
}