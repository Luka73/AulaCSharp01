using AulaCSharp01.Aula01.Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula01.Exercicio
{
    public class Program //Runnable
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario(); //objeto
            funcionario1.nome = "Pedro";
            funcionario1.sobrenome = "Rodrigues";
            funcionario1.email = "pedro@gmail.com";
            funcionario1.idade = 34;

            funcionario1.MostrarEmail(); //chamada do método!!
            funcionario1.MostraNomeESobrenomeJuntos();
            funcionario1.MostraODobroDaIdade();

            Funcionario funcionario2 = new Funcionario("Maria");
            funcionario2.email = "maria@gmail.com";

            Funcionario funcionario3 = new Funcionario("Amanda", "Maia", "amamaia@gmail.com", 32);
            funcionario3.MostraNomeESobrenomeJuntos();

            Console.WriteLine("Nome: " + funcionario2.nome);

            Console.ReadKey();
        }
    }
}
