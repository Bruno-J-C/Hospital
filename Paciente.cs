using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Paciente
    {

        private string nome;
        private string TipoSang;
        private int cpf;
        private int telFamilia;
        private int telPaciente;
        private int prioridade;

        public void CadastrarPaciente()
        {
            Console.WriteLine("Insira o nome:");
            this.nome = Console.ReadLine();

            Console.WriteLine("Insira o cpf:");
            this.cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o tipo sanguíneo:");
            this.TipoSang = Console.ReadLine();

            Console.WriteLine("Insira o telefone de um responsável:");
            this.telFamilia = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o telefone do paciente");
            this.telPaciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o grau de prioridade, sendo 1 leve e 5 grave:");
            this.prioridade = int.Parse(Console.ReadLine());

        }
    }
}
