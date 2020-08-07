using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula01
{
    public class Programa //Runnable / Controller
    {
        static void Main(string[] args)
        {
            String nome1 = "Luana";
            String nome2 = "João";
            String nome3 = "Adriele";

            Aluno aluno1 = new Aluno(); //OBJETO (é a instância de uma classe)!!
            aluno1.nome = "Luana";
            aluno1.idade = 31;
            aluno1.email = "luana@gmail.com";
            aluno1.endereco = "Rua do tal, 45";
            aluno1.matricula = "CR82913";

            Aluno aluno2 = new Aluno(); //OBJETO (é a instância de uma classe)!!
            aluno2.nome = "Pedro";
            aluno2.idade = 31;
            aluno2.email = "pedro@gmail.com";
            aluno2.endereco = "Rua do tal, 45";
            aluno2.matricula = "CR82213";

            Professor professor1 = new Professor();
            professor1.nome = "Marcos";
            professor1.idade = 45;
            professor1.email = "marcos@gmail.com";
            professor1.endereco = "Rua de tel, 89";
            professor1.disciplina = "Química";

            /* Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.idade);
            Console.WriteLine(professor1.nome);
            Console.WriteLine(professor1.disciplina); */

            aluno1.MostraOsDadosDeAlunoNaTela();
            aluno2.MostraOsDadosDeAlunoNaTela();
            professor1.MostraOsDadosDeProfessorNaTela();

            Console.ReadKey();
        }
    }
}
