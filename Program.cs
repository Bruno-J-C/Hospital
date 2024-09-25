using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Boa noite");
            Paciente[] lista = new Paciente[11];

            for (int i = 0; i < 11; i++)
            {
                lista[i] = new Paciente();
            }
            for (int n = 0; n < 11; n++)
            {
                lista[n].CadastrarPaciente();
            }


            Console.ReadKey();

        }
    }
}
