using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual.UserControls
{
    public partial class Calendario : UserControl
    {
        private int month, year;
        Form parentForm;

        public Calendario()
        {
            InitializeComponent();
            
        }

        private void Calendario_ResizeEnd(object sender, EventArgs e)
        {
            ResizeElementos();
        }




        public void GenerarDias()
        {
            
            DateTime hoy = DateTime.Now;
            month = hoy.Month;
            year = hoy.Year;

            DateTime inicioMes = new DateTime(year, month, 1);

            int cantidadDias = DateTime.DaysInMonth(year, month);

            int diaSemana = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d"));


            //Controles nulos
            for (int i = 1; i < diaSemana; i++)
            {
                UCDia diasBlancos = new UCDia();
                panelMes.Controls.Add(diasBlancos);
            }

            //Controles dias
            for (int i = 1; i<=cantidadDias; i++)
            {
                UCDia diasMes = new UCDia();
                diasMes.lblDia.Text = i.ToString();

                panelMes.Controls.Add(diasMes);
            }
        }


        public void ResizeElementos()
        {


            
            panelDias.Width = this.Width;
            foreach (Control c in panelDias.Controls)
            {
                c.Width = panelDias.Width/7;
                c.Height = panelMes.Height/7;
                if(c is Label)
                {
                    float fontSize = Math.Min(c.Width / 5.0f, c.Height / 2.0f);
                    if (fontSize <= 6)
                    {
                        fontSize = 6;
                    }
                    else if (fontSize > 20)
                    {
                        fontSize = 20;
                    }
                    c.Font = new Font(c.Font.Name,
                    fontSize, c.Font.Style);
                }
                
            }

            panelMes.Width = this.Width;
            foreach(Control c in panelMes.Controls)
            {

                c.Height = panelMes.Height / 7;
                if (!(c is FlowLayoutPanel))
                {
                    c.Width = panelMes.Width / 7;
                    
                    UCDia diasMes = (UCDia)c;
                    float fontSize = Math.Min(panelMes.Width / 20.0f, panelMes.Height / 15.0f);
                    if (fontSize <= 0)
                    {
                        fontSize = 1;
                    }
                    else if (fontSize > 20)
                    {
                        fontSize = 20;
                    }
                    diasMes.lblDia.Font = new Font(diasMes.lblDia.Font.Name,
                    fontSize, diasMes.lblDia.Font.Style);
                }
                

            }
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            parentForm = (Form)this.FindForm();
            parentForm.ResizeEnd += new EventHandler(Calendario_ResizeEnd);
            GenerarDias();
            ResizeElementos();
        }
    }
}
