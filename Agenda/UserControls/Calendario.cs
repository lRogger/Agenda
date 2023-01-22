using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual.UserControls
{
    public partial class Calendario : UserControl
    {
        private int month, year;
        Form parentForm;


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
        [Description("Cambiar el tipo de texto de los dias")]
        [Category("Textos")]
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

        //-------------------------------------------------------------------------------

        private Font fuenteDias;
        [Description("Cambiar la fuente de los días del Calendario")]
        [Category("Textos")]
        [DefaultValue(typeof(Color), "Transparent")]
        public Font FuenteDias
        {
            get { return fuenteDias; }
            set
            {
                fuenteDias = value;
                Invalidate();
            }
        }

        //--
        public Calendario()
        {
            InitializeComponent();
            parentForm = new Form();
            
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
            for (int i = 0; i < diaSemana; i++)
            {
                UCDia diasBlancos = new UCDia();
                diasBlancos.ColorBorder= BordeColor;
                diasBlancos.lblDia.Text = "";
                diasBlancos.Dock = DockStyle.Fill;
                panelMes.Controls.Add(diasBlancos);
            }

            //Controles dias
            for (int i = 1; i<=cantidadDias; i++)
            {
                UCDia diasMes = new UCDia();
                diasMes.ColorBorder = BordeColor;
                diasMes.lblDia.Text = i.ToString();
                diasMes.Dock = DockStyle.Fill;
                panelMes.Controls.Add(diasMes);
                //Color.FromArgb(232, 232, 249)
            }
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

                    /*
                    float fontSize = Math.Min(panelMes.Width / 20.0f, panelMes.Height / 15.0f);
                    if (fontSize <= 0)
                    {
                        fontSize = 1;
                    }
                    else if (fontSize > 17)
                    {
                        fontSize = 17;
                    }
                    diasMes.lblDia.Font = new Font(diasMes.lblDia.Font.Name,
                    fontSize, diasMes.lblDia.Font.Style);
                    */
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
            panelMes.Refresh();
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
        }
    }
}
