using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Paciente:Medico
    {
        private string TipoSang;
        private string telFamilia; //tel nao é int.
        private string telPaciente; // tbm nao é int.

        private int prioridade;
        public int Prioridade { get; private set; } 

        public void Cadastrar() //o nome CadastrarPaciente() é redundante.
        {
            base.cadastrar();

            Console.WriteLine("Insira o tipo sanguíneo:");
            this.TipoSang = Console.ReadLine();


            Console.WriteLine("Insira o telefone de um responsável:");
            this.telFamilia = Console.ReadLine();


            Console.WriteLine("Insira o grau de prioridade, sendo 1 leve,  3 grave:");
            this.Prioridade = int.Parse(Console.ReadLine());

        }
    }
}
