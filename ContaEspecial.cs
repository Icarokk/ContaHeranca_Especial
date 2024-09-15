using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaHeranca_Especial
{
    internal class ContaEspecial
    {
        private double limite;

        public double Limite { get => limite; set => limite = value; }

        //Buscar limite
        public void ConsultarLimite()
        {
            Console.WriteLine($"O Limite Atual é: {limite}");
        }

        //Diminui limite
        public double DiminuirLimite(double _valor)
        {
            double limiteDiminuido = limite -= _valor;
            return limiteDiminuido;
        }
        //Aumenta limite
        public double AumentarLimite(double _valor)
        {
            double limiteAumentado = limite += _valor;
            return limiteAumentado;
        }
    }
}
