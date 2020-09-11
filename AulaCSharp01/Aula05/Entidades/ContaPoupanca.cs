using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula05.Entidades
{
    public class ContaPoupanca : ContaBancaria
    {
        private double rendimento;

        public double Rendimento { get => rendimento; set => rendimento = value; }

        public ContaPoupanca()
        {
            
        }

        public ContaPoupanca(string agencia, string numero)
            : base(agencia,  numero)
        {

        }

        public ContaPoupanca(double rendimento, string agencia, string numero, double saldo, Titular titular) 
            : base(agencia, numero, saldo, titular)
        {
            this.rendimento = rendimento;
        }

    }


}
