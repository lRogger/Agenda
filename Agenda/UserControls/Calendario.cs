using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual.UserControls
{
    public partial class Calendario : UserControl
    {
        private int month, year;
        private List<UCDia> listaDias;
        private DateTime diaSelected;

        //Propiedades
        private Color bordeColor;
        [Description("Cambiar el color del borde de los dias del mes")]
        [Category("Colores")]
        [DefaultValue(typeof(Color), "Transparent")]
        public Color BordeColor
        {
            get { return bordeColor; }
            set
            {
                bordeColor = value;
                Invalidate();
            }
        }

        //--
        private Color colorDiaSeleccionado;
        [Description("Cambiar el color del día seleccionado")]
        [Category("Colores")]
        [DefaultValue(typeof(Color), "White")]
        public Color ColorDiaSeleccionado
        {
            get { return colorDiaSeleccionado; }
            set
            {
                colorDiaSeleccionado = value;
                Invalidate();
            }
        }


        //--
        private Color colorDia;
        [Description("Cambiar el color del día")]
        [Category("Colores")]
        [DefaultValue(typeof(Color), "Black")]
        public Color ColorDia
        {
            get { return colorDia; }
            set
            {
                colorDia = value;
                Invalidate();
            }
        }

        //--
        [Description("Cambiar el tipo de texto de los dias")]
        [Category("Textos")]
        [DefaultValue(typeof(Font), "Font.FontFamily,9,FontStyle.Regular")]
        public enum LabelTextOptions
        {
            Completo,
            Inicial,
            Abreviado
        }

        public LabelTextOptions TipoDias
        {
            get { return _customText; }
            set
            {
                _customText = value;
                switch (_customText)
                {
                    case LabelTextOptions.Completo:
                        lblDo.Text = "Domingo";
                        lblLu.Text = "Lunes";
                        lblMa.Text = "Martes";
                        lblMi.Text = "Miércoles";
                        lblJu.Text = "Jueves";
                        lblVi.Text = "Viernes";
                        lblSa.Text = "Sábado";
                        break;
                    case LabelTextOptions.Inicial:
                        lblDo.Text = "D";
                        lblLu.Text = "L";
                        lblMa.Text = "M";
                        lblMi.Text = "X";
                        lblJu.Text = "J";
                        lblVi.Text = "V";
                        lblSa.Text = "S";
                        break;
                    case LabelTextOptions.Abreviado:
                        lblDo.Text = "Do";
                        lblLu.Text = "Lu";
                        lblMa.Text = "Ma";
                        lblMi.Text = "Mi";
                        lblJu.Text = "Ju";
                        lblVi.Text = "Vi";
                        lblSa.Text = "Sa";
                        break;
                }
            }
        }

        private LabelTextOptions _customText;

        //--
        private Color fuenteDiasColor;
        [Description("Cambiar el color del texto de los dias del Mes")]
        [Category("Textos")]
        [DefaultValue(typeof(Color), "Black")]
        public Color FuenteDiasColor
        {
            get { return fuenteDiasColor; }
            set
            {
                fuenteDiasColor = value;
                Invalidate();
            }
        }

        //--

        private Font fuenteDias;
        [Description("Cambiar la fuente de los días del Calendario")]
        [Category("Textos")]
        [DefaultValue(typeof(Font), "Font.FontFamily,9,FontStyle.Regular")]
        public Font FuenteDias
        {
            get { return fuenteDias; }
            set
            {
                fuenteDias = value;
                Invalidate();
            }
        }

        //-------------------------------------------------------------------------------

        //Constructor
        public Calendario()
        {
            InitializeComponent();
            fuenteDias = new Font(Font.FontFamily,9,FontStyle.Regular);
            diaSelected = DateTime.Now;

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
            diaSemana = (diaSemana - 1 >= 0) ? diaSemana - 1 : 6;


            //Controles Anterior
            int diasMesAnterior = DateTime.DaysInMonth(year, (month-1>0)?month-1:12);
            for (int i = 0; i < diaSemana; i++)
            {
                UCDia diasBlancos = new UCDia();
                diasBlancos.ColorBorder= BordeColor;
                diasBlancos.lblDia.Text = ((diasMesAnterior+i+1)-(diaSemana)).ToString();
                diasBlancos.Enabled = false;
                diasBlancos.Dock = DockStyle.Fill;
                
                panelMes.Controls.Add(diasBlancos);
            }

            //Controles dias
            listaDias = new List<UCDia>();
            for (int i = 1; i<=cantidadDias; i++)
            {
                UCDia diasMes = new UCDia();
                diasMes.ColorBorder = BordeColor;
                diasMes.lblDia.Text = i.ToString();
                diasMes.Dock = DockStyle.Fill;
                diasMes.panel1.Click += new EventHandler(Dia_Click);
                panelMes.Controls.Add(diasMes);
                listaDias.Add(diasMes);
            }

            //Controles Posterior
            int diasMesPost = DateTime.DaysInMonth(year, (month+1>12)?1:month+1);
            int veces = 42 - (cantidadDias + diaSemana);
            for (int i = 0; i < veces; i++)
            {
                UCDia diasBlancos = new UCDia();
                diasBlancos.ColorBorder = BordeColor;
                diasBlancos.lblDia.Text = (i+1).ToString();
                diasBlancos.Enabled = false;
                diasBlancos.Dock = DockStyle.Fill;

                panelMes.Controls.Add(diasBlancos);
            }
        }

        private void Dia_Click(object sender, EventArgs e)
        {
            Panel dia = (Panel)sender;
            UCDia ucdia = (UCDia)dia.Parent;
            foreach (UCDia diasMes in listaDias)
            {
                if (!diasMes.lblDia.Text.Equals(ucdia.lblDia.Text))
                {
                    diasMes.panel1.BackColor = ColorDia;
                }
                else
                {
                    ucdia.panel1.BackColor = ColorDiaSeleccionado;
                    diaSelected = new DateTime(year, month, Convert.ToInt32(ucdia.lblDia.Text));
                    

                }
            }
            MessageBox.Show("Dia: " + diaSelected.Date.ToString("d"));

        }


        public void ResizeElementos()
        {

            panelMes.Width = this.Width;
            foreach(Control c in panelMes.Controls)
            {

                c.Height = panelMes.Height / 7;
                if (!(c is System.Windows.Forms.Label))
                {
                    
                    c.Width = panelMes.Width / 7;
                    
                    UCDia diasMes = (UCDia)c;

                    if (diasMes.lblDia.Size.Height > c.Height)
                    {
                        while(diasMes.lblDia.Size.Height > c.Height)
                        {
                            diasMes.lblDia.Font = new Font("Microsoft Sans Serif", diasMes.lblDia.Font.Size - 0.5f, FontStyle.Bold);
                        }
                    }else if ( diasMes.lblDia.Size.Height < c.Height)
                    {

                        while (diasMes.lblDia.Size.Height < c.Height)
                        {
                            diasMes.lblDia.Font = new Font("Microsoft Sans Serif", diasMes.lblDia.Font.Size + 0.5f, FontStyle.Bold);
                        }
                    }

                }
                else
                {
                    c.Width = panelMes.Width / 7;
                    float fontSize = Math.Min(c.Width / 6.5f, c.Height / 2.0f);
                    if (fontSize <= 7)
                    {
                        fontSize = 7;
                    }
                    else if (fontSize > 30)
                    {
                        fontSize = 30;
                    }
                    c.Font = new Font(c.Font.Name,
                    fontSize, c.Font.Style);
                    
                }
                

            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Windows.Forms.Label[] labels = { lblDo, lblLu, lblMa, lblMi, lblJu, lblVi, lblSa };
            foreach (var label in labels)
            {
                label.ForeColor = fuenteDiasColor;
            }
            foreach (var label in labels)
            {
                label.Font = fuenteDias;
            }
        }


        private void Calendario_Load(object sender, EventArgs e)
        {
            //parentForm = (Form)this.FindForm();
            //parentForm.ResizeEnd += new EventHandler(Calendario_ResizeEnd);
            GenerarDias();
            //ResizeElementos();

            foreach (UCDia diasMes in listaDias)
            {
                if (diasMes.lblDia.Text == DateTime.Now.Day.ToString())
                {
                    diasMes.panel1.BackColor = colorDiaSeleccionado;
                }
            }
        }
    }
}
