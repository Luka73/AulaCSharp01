using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome? ");
            string nomeDoAluno = Console.ReadLine();
            //Luana 

            Console.WriteLine("Qual a sua idade? ");
            int idadeDoAluno = int.Parse(Console.ReadLine());
            //45

            Console.WriteLine("Qual o seu endereço? ");
            string enderecoDoAluno = Console.ReadLine();
            //Logradouro
            //Numero
            //Complemento
            //Cep
            //cidade
            //estado
            //pais

            string[] enderecos = { "Rua da Carioca", "78", "Apto 7" };
           
            //Rua da Carioca, 78 
            //Rua da Carioca, 78 - Rio de Janeiro, RJ
            //int string
            //Seres Humanos, Animais (Felinos, Répteis...), Mamíferos
            //Cozinha/Banheiro/

            Console.ReadKey();
        }
    }
}
