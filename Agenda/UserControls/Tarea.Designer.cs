namespace Visual.UserControls
{
    partial class Tarea
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjRadioButton1 = new CustomControls.RJControls.RJRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.panelMod1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMod1.BorderRadius = 10;
            this.panelMod1.Controls.Add(this.panel1);
            this.panelMod1.Controls.Add(this.panel2);
            this.panelMod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 90F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.panelMod1.GradientTopColor = System.Drawing.Color.Transparent;
            this.panelMod1.Location = new System.Drawing.Point(0, 0);
            this.panelMod1.Margin = new System.Windows.Forms.Padding(0);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(270, 50);
            this.panelMod1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.rjRadioButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(32, 50);
            this.panel1.TabIndex = 4;
            // 
            // rjRadioButton1
            // 
            this.rjRadioButton1.AutoSize = true;
            this.rjRadioButton1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRadioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjRadioButton1.Location = new System.Drawing.Point(8, 0);
            this.rjRadioButton1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rjRadioButton1.Name = "rjRadioButton1";
            this.rjRadioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rjRadioButton1.Size = new System.Drawing.Size(24, 50);
            this.rjRadioButton1.TabIndex = 5;
            this.rjRadioButton1.TabStop = true;
            this.rjRadioButton1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblTarea);
            this.panel2.Location = new System.Drawing.Point(26, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 50);
            this.panel2.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFecha.Location = new System.Drawing.Point(0, 35);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFecha.Size = new System.Drawing.Size(244, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTarea
            // 
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarea.Font = new System.Drawing.Font("Mazzard H SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarea.Location = new System.Drawing.Point(0, 0);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(244, 50);
            this.lblTarea.TabIndex = 5;
            this.lblTarea.Text = "Titulo de la Tarea";
            this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMod1);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Name = "Tarea";
            this.Size = new System.Drawing.Size(270, 50);
            this.Load += new System.EventHandler(this.Tarea_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Tarea_Paint);
            this.panelMod1.ResumeLayout(false);
            this.panelMod1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        public Label lblFecha;
        public Label lblTarea;
        private Panel panel1;
        private CustomControls.RJControls.RJRadioButton rjRadioButton1;
        public Individual.Visual.ComponentesMod.PanelMod panelMod1;
    }
}
