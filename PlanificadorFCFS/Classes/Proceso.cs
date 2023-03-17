using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanificadorFCFS.Classes
{
    internal class Proceso
    {
        public string nombre { get; set; }
        public PictureBox imagen { get; set; }
        public int tiempoEjecucion { get; set; }
        public int tiempoTranscurrido {get; set; }
        public Proceso (int t, string n) 
        {
            this.nombre = n;
            this.tiempoEjecucion = t;
            this.tiempoTranscurrido = 0;
            this.imagen = new PictureBox ();
            this.imagen.Width = 140;
            this.imagen.Height = 68;
            this.imagen.Image = PlanificadorFCFS.Properties.Resources.panzer_chiquito;
        }
    }
}
