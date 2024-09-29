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
            Paciente paciente = new Paciente();
            Fila fila = new Fila();

            paciente.Cadastrar();
            fila.add(paciente);

            fila.mostrar();

            Console.ReadKey();

        }
    }
}
