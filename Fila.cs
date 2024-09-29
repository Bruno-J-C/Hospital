using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlaPaciente
{
    internal class Fila
    {
        
        protected Paciente[] array = new Paciente[11];
        protected int length = 0;
        private int n = 0; //vai ajudar a verificar a prioridade do paciente.

        private int VerificarPrioridade(int Prioridade) 
        {
            int p = 0; //posicao
            if (Prioridade == 3) 
            {
                p += this.n; //p = p + n
                n++;

                /*A ideia é que dessa forma possamos colocar mais de um paciente 
                 de prioridade 3 na fila de maneira com que primero paciente prioridade 3 
                adicionado na fila estara na frente do segundo paciente de nivel 3 
                adicionado e assim por diante.
                 */
            }

            return p;

        
        }
        public void add(Paciente pcnt) 
        {
            this.array[this.VerificarPrioridade(pcnt.Prioridade)] = pcnt; //this.verificarPrioridade vai retornar a posicao do paciente no array
            this.length++;
        }

        public void mostrar() {
            for (int i = 0; i < this.length; i++) {
                Console.WriteLine($"{i+1}º:{this.array[i].Nome}");
            }
        
        
        
        }
    }
}
