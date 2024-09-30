using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Medico
    {
        protected string nome;
        public string Nome { get; private set; } // posso acessar fora da classe mas nao posso alterar. \
        protected string cpf;
        protected string rg;
        protected string nasc;
        protected string telefone;

        public virtual void cadastrar() 
        {
            Console.WriteLine($"Insira o nome do {this.GetType().Name} :");
            this.Nome = Console.ReadLine();

            Console.WriteLine("Insira o cpf:");
            this.cpf = Console.ReadLine();

            Console.WriteLine("Insira o rg:");
            this.cpf = Console.ReadLine();

            Console.WriteLine("Insira o telefone");
            this.telefone = Console.ReadLine();
        }

        public void atenderProximo(Fila fila, string diagnostico) 
        {
            Consulta cons = new Consulta();
            cons.cadastrar(fila.proximo(), this.Nome);
            cons.gerarLaudo(diagnostico);

        }


    }
}
