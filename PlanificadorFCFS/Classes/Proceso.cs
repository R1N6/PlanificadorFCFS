using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanificadorFCFS.Classes
{
    internal class Proceso
    {
        int tiempoEjecucion = 0;
        int tiempoRestante  = 0;
        public Proceso (int t) 
        {
            this.tiempoEjecucion = t;
            this.tiempoRestante = tiempoEjecucion;
        }
    }
}
