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

        private int VerificarPrioridade(int Prioridade) 
        {
            int p; //posicao
            if (Prioridade > 2) 
            {
                p = 0;
            }

            if (p < 2) 
            {
            
            
            }

            return p;


        
        
        }
        public void addPaciente(Paciente p) 
        {
            
            this.pacientes[this.VerificarPrioridade(p.prioridade)];
        
        
        }

       


        

        
    }
}
