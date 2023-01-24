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
            this.tPanelPrim = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelMod1.SuspendLayout();
            this.tPanelPrim.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMod1
            // 
            this.panelMod1.BackColor = System.Drawing.Color.White;
            this.panelMod1.BorderRadius = 10;
            this.panelMod1.Controls.Add(this.tPanelPrim);
            this.panelMod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 90F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.panelMod1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.panelMod1.Location = new System.Drawing.Point(0, 0);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(232, 50);
            this.panelMod1.TabIndex = 0;
            // 
            // tPanelPrim
            // 
            this.tPanelPrim.ColumnCount = 2;
            this.tPanelPrim.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tPanelPrim.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tPanelPrim.Controls.Add(this.panel1, 1, 0);
            this.tPanelPrim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPanelPrim.Location = new System.Drawing.Point(0, 0);
            this.tPanelPrim.Name = "tPanelPrim";
            this.tPanelPrim.RowCount = 1;
            this.tPanelPrim.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPanelPrim.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tPanelPrim.Size = new System.Drawing.Size(232, 50);
            this.tPanelPrim.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTarea);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(46, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(186, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblTarea
            // 
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTarea.Location = new System.Drawing.Point(5, 5);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(176, 25);
            this.lblTarea.TabIndex = 2;
            this.lblTarea.Text = "Titulo de la Tarea";
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFecha.Location = new System.Drawing.Point(5, 30);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(176, 15);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMod1);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Name = "Tarea";
            this.Size = new System.Drawing.Size(232, 50);
            this.Load += new System.EventHandler(this.Tarea_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Tarea_Paint);
            this.panelMod1.ResumeLayout(false);
            this.tPanelPrim.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Individual.Visual.ComponentesMod.PanelMod panelMod1;
        private Panel panel1;
        public Label lblFecha;
        public Label lblTarea;
        public TableLayoutPanel tPanelPrim;
    }
}
