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
    public partial class ListaTareas : UserControl
    {
        public ListaTareas()
        {
            InitializeComponent();
            
        }

        public void ColorForm(Color c)
        {
            panel1.BackColor = c;
            panel2.BackColor = c;
            panelMod1.BackColor= c;
            tableLayoutPanel1.BackColor= c;
            tableLayoutPanel2.BackColor= c;
            tableLayoutPanel3.BackColor= c;
            
        }
    }
}
