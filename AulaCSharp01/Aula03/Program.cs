using AulaCSharp01.Aula03.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta("1234", "5637-9", "Adriele", "2020-08-20");
            conta1.deposita(120);
            conta1.deposita(50);

            conta1.saca(30);
            conta1.saca(-800);
            conta1.Agencia = "3451"; //set

            Console.WriteLine("Saldo: " + conta1.getSaldo());
            Console.WriteLine("Agencia: " + conta1.Agencia); //get

            Console.ReadKey();
        }
    }
}
