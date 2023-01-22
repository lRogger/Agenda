using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace Visual.UserControls
{
    
    public partial class UCDia : UserControl
    {
        private Color colorBorder;

        public Color ColorBorder { get => colorBorder; set => colorBorder = value; }

        public UCDia()
        {
            InitializeComponent();
            colorBorder = Color.Transparent;
        }

        private void lblDia_Click(object sender, EventArgs e)
        {

        }

        private void UCDia_Load(object sender, EventArgs e)
        {

        }

        private void UCDia_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, colorBorder, ButtonBorderStyle.Solid);

        }
    }
}
