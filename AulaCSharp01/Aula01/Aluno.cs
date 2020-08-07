using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula01
{
    public class Aluno //CLASSE ALUNO!! --> ideia!! Entity / Model
    {
        public string nome; //atributo (O que a classe TEM)
        public int idade; //características, adjetos
        public string email;
        public string endereco;
        public string matricula;

        public void MostraOsDadosDeAlunoNaTela()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Endereco: " + endereco);
            Console.WriteLine("Matricula: " + matricula);
        }
    }
}
