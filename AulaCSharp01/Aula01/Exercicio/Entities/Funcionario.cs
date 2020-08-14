using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula01.Exercicio.Entities
{
    public class Funcionario //classe (ideia, criação, molde, definição)
    {

        public string nome; // atributos
        public string sobrenome;
        public string email;
        public int idade;


        public void MostrarEmail() // criação do método
        {
            Console.WriteLine("Email: " + email);
        }

        public void MostraODobroDaIdade()
        {
            Console.WriteLine("Dobro da idade: " + (idade * 2));
            // + --> concatenação
            // + --> soma
        }

        public void MostraNomeESobrenomeJuntos()
        {
            Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
            // Pedro
            // Rodrigues
            // Pedro Rodrigues
        }
    }
}
