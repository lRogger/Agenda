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
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void panelMod10_DoubleClick(object sender, EventArgs e)
        {
            new Foto().Show();
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
    }
}
