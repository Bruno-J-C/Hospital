using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Laudo:Consulta
    {
        private string diagnostico;
        public void gerar(Paciente pcnt, string medico ,string diagsc,int n ,string data, string h)
        {
            this.Paciente = pcnt;
            this.NomeDoMedico = medico;
            this.diagnostico = diagsc;

            this.nmrDaConsuta = n;
            this.data = data;
            this.horario = h;
        }

        public void mostrarLaudo() 
        {
            Console.WriteLine("\n");
            Console.WriteLine("Laudo Medico:");
            Console.WriteLine($"Paciente: {this.Paciente.Nome}, Medico responsavel: {this.NomeDoMedico}");
            Console.WriteLine($"codigo da consulta:{this.nmrDaConsuta}, Horario da consulta: {this.horario}, data da consulta {this.data}, ");
            Console.WriteLine($"Diagnostico do Paciente: {this.diagnostico}");
            Console.WriteLine("\n");

        }
    }
}
