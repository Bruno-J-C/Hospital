using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Paciente
    {

        protected string nome;
        public string Nome { get; private set; } // posso acessar fora da classe mas nao posso alterar. 

        private string TipoSang;
        private string cpf; //cpf nao é int, pq temos caracteres como "-" e "." alem de ser considerado um numero muito grande. 
        private string telFamilia; //tel nao é int.
        private string telPaciente; // tbm nao é int.

        private int prioridade;
        public int Prioridade { get; private set; } 

        public void Cadastrar() //o nome CadastrarPaciente() é redundante.
        {
            Console.WriteLine("Insira o nome:");
            this.Nome = Console.ReadLine();

            Console.WriteLine("Insira o cpf:");
            this.cpf = Console.ReadLine();

            Console.WriteLine("Insira o tipo sanguíneo:");
            this.TipoSang = Console.ReadLine();

            Console.WriteLine("Insira o telefone do paciente");
            this.telPaciente = Console.ReadLine();

            Console.WriteLine("Insira o telefone de um responsável:");
            this.telFamilia = Console.ReadLine();


            Console.WriteLine("Insira o grau de prioridade, sendo 1 leve, 2 mediano e 3 grave:");
            this.Prioridade = int.Parse(Console.ReadLine());

        }
    }
}
