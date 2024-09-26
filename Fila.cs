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
        protected int n = 0;

        private int VerificarPrioridade(int Prioridade) 
        {
            int p = 0; //posicao
            if (Prioridade == 3) 
            {
                p += this.n; //p = p + n
                n++;
            }

            return p;


        
        
        }
        public void addPaciente(Paciente p) 
        {
            this.array[this.VerificarPrioridade(p.prioridade)] = p;
        }  
    }
}
