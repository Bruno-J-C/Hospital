using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Consulta
    {
        protected Paciente Paciente;
        protected string  NomeDoMedico;
        protected string consutorio;

        protected int nmrDaConsuta;
        protected string data;
        protected string horario;
        private Laudo laudo;


        
        public virtual void cadastrar(Paciente pcnt, string medico) 
        {

            Console.WriteLine("Digite o numero da consulta:");
            this.nmrDaConsuta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data da Consulta:");
            this.data = Console.ReadLine();

            Console.WriteLine("Digite o Horario da Consulta:");
            this.horario = Console.ReadLine();

            this.Paciente = pcnt;
            this.NomeDoMedico = medico;
        }

        public void gerarLaudo(string diagnostico) 
        {
            this.laudo = new Laudo();
            laudo.gerar(this.Paciente, this.NomeDoMedico ,diagnostico,this.nmrDaConsuta ,this.data, this.horario);
            laudo.mostrarLaudo();
        
        }
    }
}
