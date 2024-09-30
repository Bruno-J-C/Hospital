using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Fila
    {

        public Paciente[] pacientes = new Paciente[11]; // os pacientes serao atendidos da ultima posicao para a primeira.
       

        protected int length = 0;

        private int ponteiro = 11;
        private int p3 = 1; //(p3:prioridaed 3) vai ajudar a verificar a prioridade do paciente.
        private int p1 = 0;
        private int VerificarPrioridade(int Prioridade) 
        {
            int p = 0; //posicao
            if (Prioridade == 3) 
            {
                p = this.pacientes.Length - this.p3; 
                p3++;

                /*A ideia é que dessa forma possamos colocar mais de um paciente 
                 de prioridade 3 na fila de maneira com que primero paciente prioridade 3 
                adicionado na fila estara na frente do segundo paciente de nivel 3 
                adicionado e assim por diante.
                 */

                if (this.pacientes[p] is Paciente)
                {
                    this.pacientes[p-1] = this.pacientes[p];
                }
            }

            if (Prioridade == 1) 
            {
                p = (this.pacientes.Length - 1) - this.length; 
                this.p1++;
            }

            return p;
        }
        public void add(Paciente pcnt) 
        {
            this.pacientes[this.VerificarPrioridade(pcnt.Prioridade)] = pcnt; //this.verificarPrioridade vai retornar a posicao do paciente no array.
            this.length++; //vai contar quantos pacientes foram adicionados.
        }

        public void mostrar() {
            int l = this.pacientes.Length; 
            int p = l - this.length; // posicao do ultimo paciente adicionado.
            
            int n = 1;  
            for (int i=l; i > p; i=i-1) {
                Console.WriteLine($"{n}º:{this.pacientes[i-1].Nome}");
                n++;
            }
        }

        public Paciente proximo() 
        {
            this.ponteiro = this.ponteiro - 1;
            return this.pacientes[ponteiro];    
        }
    }
}
