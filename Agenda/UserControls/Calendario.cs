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

        private Font tamanioDias;
        [Description("Establece el tamaño de los días")]
        [Category("Mod")]
        [DefaultValue(typeof(Font), "Calibri, 12pt")]


        public Font TamanioDias
        {
            get { return tamanioDias; }
            set
            {
                TamanioDias = value;
                lblDo.Font = tamanioDias;
                lblLu.Font = tamanioDias;
                lblMa.Font = tamanioDias;
                lblMi.Font = tamanioDias;
                lblJu.Font = tamanioDias;
                lblVi.Font = tamanioDias;
                lblSa.Font = tamanioDias;
            }
        }

        public Calendario()
        {
            InitializeComponent();
            
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

            panelPrincipal.Width = this.Width;
            panelPrincipal.Height = this.Height;
            
            panelDias.Width = this.Width;
            foreach (Control c in panelDias.Controls)
            {
                c.Width = panelDias.Width/7;

            }

            panelMes.Width = this.Width;
            foreach(Control c in panelMes.Controls)
            {
                c.Width = panelMes.Width / 7;
                c.Height = panelMes.Height / 6;
            }
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            GenerarDias();
            ResizeElementos();
        }
    }
}
