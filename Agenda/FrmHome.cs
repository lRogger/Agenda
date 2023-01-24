using Datos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.UserControls;

namespace Visual
{
    public partial class FrmHome : Form
    {
        private Persona sesion;

        public Persona Sesion { get => sesion; set => sesion = value; }

        public FrmHome()
        {
            InitializeComponent();
            sesion = new Persona();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Resize += FrmHome_EndResize;
            lblFecha.Text = DateTime.Now.ToString("M");
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        

        private void panelMod10_Click(object sender, EventArgs e)
        {
            
        }

        private async void FrmHome_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataBase db = new DataBase();


            ds = await db.consultar("Select * FROM User WHERE CEDULA = 0930555420");

            Persona p = new Persona();
            p.Imagen = ds.Tables[0].Rows[0]["Imagen"];

            dynamic json = JsonConvert.DeserializeObject(p.Imagen);
            pbUser.ImageLocation = json.data.link;
        }

        private void FrmHome_Resize(object sender, EventArgs e)
        {
            
        }

        private void FrmHome_EndResize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void panelMod10_DoubleClick(object sender, EventArgs e)
        {

            ListaTareas lt = new ListaTareas();
            lt.ColorForm(panelMod10.BackColor);
            lt.lblFecha.Text = DateTime.Now.ToString();
            lt.lblRgTareas.Text = "Para hoy";
            panelLista.Controls.Clear();
            panelLista.Controls.Add(lt);
            lt.Dock = DockStyle.Fill;
        }

        private void panelMod12_DoubleClick(object sender, EventArgs e)
        {
            
            ListaTareas lt = new ListaTareas();
            lt.ColorForm(panelMod12.BackColor);
            lt.lblFecha.Text = DateTime.Now.ToString();
            lt.lblRgTareas.Text = "Para Mañana";
            panelLista.Controls.Clear();
            panelLista.Controls.Add(lt);
            lt.Dock = DockStyle.Fill;
        }

        private void panelMod14_DoubleClick(object sender, EventArgs e)
        {

            ListaTareas lt = new ListaTareas();
            lt.ColorForm(panelMod14.BackColor);
            lt.lblFecha.Text = DateTime.Now.ToString();
            lt.lblRgTareas.Text = "Esta Semana";
            panelLista.Controls.Clear();
            panelLista.Controls.Add(lt);
            lt.Dock = DockStyle.Fill;
        }
    }
}
