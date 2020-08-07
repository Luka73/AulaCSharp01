using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula01
{
    public class Professor
    {
        public string nome;
        public int idade;
        public string email;
        public string endereco;
        public string disciplina;

        public void MostraOsDadosDeProfessorNaTela()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Endereco: " + endereco);
            Console.WriteLine("Disciplina: " + disciplina);
        }
    }
}
