using Datos;
using Entidades;
using Individual.Visual.ComponentesMod;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private List<Tarea> checkList;

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

            LoadCheckList();
            
        }

        private void LoadCheckList()
        {
            int count = 1;

            checkList = new List<Tarea>();
            for (int i = 0; i < 10; i++)
            {
                //CheckList
                Tarea t = new Tarea();
                t.lblFecha.Visible = false;
                t.lblTarea.Text = "Prueba Tarea " + i;
                t.tPanelPrim.Click += new EventHandler(Tarea_Click!);
                t.lblTarea.Click += new EventHandler(Tarea_Click!);
                tPanelCheckList.Controls.Add(t, 0, count);
                t.Dock = DockStyle.Fill;
                checkList.Add(t);
                
                count++;
            }

            if (tPanelCheckList.Controls.Count < 11) {
                LinkLabel addTarea = new LinkLabel();
                addTarea.Text = "+ Agregar Tarea";
                addTarea.Dock = DockStyle.Fill;
                using(Tarea font = new Tarea())
                {
                    addTarea.Font = font.lblTarea.Font;
                    addTarea.TextAlign = font.lblTarea.TextAlign;
                    addTarea.ForeColor = font.lblTarea.ForeColor;
                }
                
                tPanelCheckList.Controls.Add(addTarea,0,count);
                addTarea.LinkClicked += addTarea_LinkClicked;
                addTarea.TextAlign = ContentAlignment.MiddleCenter;
                count++;
            }
        }

        private void Tarea_Click(object sender, EventArgs e)
        {
            Tarea t = new Tarea();

            if(sender is Panel)
            {
                Panel tPanel = (Panel)sender;
                t = (Tarea)tPanel.Parent.Parent;
            }else if(sender is Label)
            {
                Label tLabel = (Label)sender;
                t = (Tarea)tLabel.Parent.Parent.Parent.Parent;
            }
            
            foreach (Tarea tareas in checkList)
            {
                
                if (tareas.lblTarea.Text == t.lblTarea.Text)
                {
                    tareas.tPanelPrim.BackColor = Color.Gray;
                }
                else
                {
                    tareas.tPanelPrim.BackColor = Color.White;


                }
            }

        }

        private void addTarea_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            MessageBox.Show("Nueva Tarea debería ser creada");
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
