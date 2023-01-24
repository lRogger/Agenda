using Individual.Visual.ComponentesMod;
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
    public partial class Tarea : UserControl
    {
        public Tarea()
        {
            InitializeComponent();
            
        }

        private void Tarea_Load(object sender, EventArgs e)
        {
            
        }

        private void Tarea_Paint(object sender, PaintEventArgs e)
        {
            //this.BackColor = this.FindForm().BackColor;
        }
    }
}
