/*
 * Perez Ortiz Ricardo
 * 
 */
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
        int pulso = 0, segundo = 0;
        Queue<Proceso> colaProcesos = new Queue<Proceso>();
        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
        }

        protected void Add_Panzer(int t, string n)
        {
            Proceso p = new Proceso(t, n);
            colaProcesos.Enqueue(p);
            panel1.Controls.Add(p.imagen);
            p.imagen.Top = p.imagen.Height * (panel1.Controls.Count - 3) - p.imagen.Height + 5;
            p.imagen.Left = segundo * 24;
            lblPrompt.Text += $"Proceso {n} encolado" + Environment.NewLine;
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            Add_Panzer(3, "A");
            pbProceso.Maximum = colaProcesos.Peek().tiempoEjecucion;
            pbProceso.Value = 0;
        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (colaProcesos.Count < 1)
            {
                timer1.Enabled = false;
                return;
            }

            int segundo_previo = segundo;
            Proceso pro = colaProcesos.Peek();
            PictureBox pBox = pro.imagen;

            pulso++;
            pBox.Left += 8;
            segundo = pulso / 10;
            

            if (segundo == segundo_previo + 1)
            {
                pro.tiempoTranscurrido++;
                pbProceso.Value = pro.tiempoTranscurrido;
                switch (segundo)
                {
                    case 1:
                        Add_Panzer(5, "B");break;
                    case 3:
                        Add_Panzer(2, "C"); break;
                    case 9: Add_Panzer(5, "D"); break;
                    case 12: Add_Panzer(5, "E"); break;
                }
            }

            if (pro.tiempoTranscurrido == pro.tiempoEjecucion)
            {
                string name = colaProcesos.Dequeue().nombre;
                lblPrompt.Text += $"Proceso {name} finalizado" + Environment.NewLine;
                if (colaProcesos.Count > 0)
                {
                    pbProceso.Maximum = colaProcesos.Peek().tiempoEjecucion;
                    pbProceso.Value = 0;
                }
            }
                
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
