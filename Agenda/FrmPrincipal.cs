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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmPrincipal_SizeChanged(object sender, EventArgs e)
        {
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Size minSize = new Size(10, 10);

            // Recorre cada uno de los controles dentro del TableLayoutPanel
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                minSize = control.MinimumSize + minSize;
            }

            // Establece el tamaño mínimo del formulario
            this.MinimumSize = minSize;
        }
    }
}
