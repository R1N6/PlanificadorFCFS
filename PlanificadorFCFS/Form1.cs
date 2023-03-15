using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanificadorFCFS.Classes;

namespace PlanificadorFCFS
{
    public partial class Form1 : Form
    {
        Queue<Proceso> colaProcesos = new Queue<Proceso>();
        public Form1()
        {
            InitializeComponent();
            colaProcesos.Enqueue(new Proceso(3));
            colaProcesos.Enqueue(new Proceso(5));
            colaProcesos.Enqueue(new Proceso(2));
            colaProcesos.Enqueue(new Proceso(5));
            colaProcesos.Enqueue(new Proceso(5));
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
