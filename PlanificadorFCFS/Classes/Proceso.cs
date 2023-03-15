using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanificadorFCFS.Classes
{
    internal class Proceso
    {
        int tiempoEjecucion { get; set; }
        int tiempoTranscurrido {get; set; }
        public Proceso (int t) 
        {
            this.tiempoEjecucion = t;
            this.tiempoTranscurrido = tiempoEjecucion;
        }
    }
}
