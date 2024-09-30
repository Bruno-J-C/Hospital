using controlaPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teste = ConsoleKey.R;
            Fila fila = new Fila();
            Medico medico = new Medico();
            medico.cadastrar();


           


            while (teste != ConsoleKey.Q)
            {
                Console.WriteLine("Escreva add para adicionar paciente \nEscreva list para ver a fila de pacientes \nEscreva atender para atenter pacientes da fila");
                string Acao = Console.ReadLine();

                if (Acao == "add") 
                {
                    Paciente paciente = new Paciente();
                    paciente.Cadastrar();
                    fila.add(paciente);
                }

                if (Acao == "list") 
                {
                    fila.mostrar();
                }

                if (Acao == "atender") 
                {
                    Console.WriteLine("escreva o diagnostico");
                    string diagnostico = Console.ReadLine();
                    medico.atenderProximo(fila, diagnostico);
                }

                Console.WriteLine("presione q para Sair ou r para repetir as opcoes");
                teste = Console.ReadKey(true).Key;
                Console.WriteLine("\n");
               




            }

        }
    }
}
