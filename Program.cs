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
            Fila fila = new Fila();

            Paciente paciente = new Paciente();
            Paciente paciente2 = new Paciente();
            Paciente paciente3 = new Paciente();
            Paciente paciente4 = new Paciente();    
            

            paciente.Cadastrar();
            paciente2.Cadastrar();
            paciente3.Cadastrar();
            paciente4.Cadastrar();


            fila.add(paciente);
            fila.add(paciente2);
            fila.add(paciente3);
            fila.add(paciente4);



            fila.mostrar();

           
            //System.ConsoleKey
            Console.WriteLine(Console.ReadKey().Key);
            Console.ReadKey();

        }
    }
}
