namespace Visual.UserControls
{
    partial class Calendario
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMes = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDias = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblLu = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblMi = new System.Windows.Forms.Label();
            this.lblJu = new System.Windows.Forms.Label();
            this.lblVi = new System.Windows.Forms.Label();
            this.lblSa = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelDias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.panelMes);
            this.panelPrincipal.Controls.Add(this.panelDias);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(490, 460);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelMes
            // 
            this.panelMes.Location = new System.Drawing.Point(1, 70);
            this.panelMes.Margin = new System.Windows.Forms.Padding(0);
            this.panelMes.Name = "panelMes";
            this.panelMes.Size = new System.Drawing.Size(490, 303);
            this.panelMes.TabIndex = 4;
            // 
            // panelDias
            // 
            this.panelDias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDias.Controls.Add(this.lblDo);
            this.panelDias.Controls.Add(this.lblLu);
            this.panelDias.Controls.Add(this.lblMa);
            this.panelDias.Controls.Add(this.lblMi);
            this.panelDias.Controls.Add(this.lblJu);
            this.panelDias.Controls.Add(this.lblVi);
            this.panelDias.Controls.Add(this.lblSa);
            this.panelDias.Location = new System.Drawing.Point(0, 29);
            this.panelDias.Name = "panelDias";
            this.panelDias.Size = new System.Drawing.Size(490, 37);
            this.panelDias.TabIndex = 3;
            // 
            // lblDo
            // 
            this.lblDo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDo.Location = new System.Drawing.Point(0, 0);
            this.lblDo.Margin = new System.Windows.Forms.Padding(0);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(70, 37);
            this.lblDo.TabIndex = 6;
            this.lblDo.Text = "DO";
            this.lblDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLu
            // 
            this.lblLu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLu.Location = new System.Drawing.Point(70, 0);
            this.lblLu.Margin = new System.Windows.Forms.Padding(0);
            this.lblLu.Name = "lblLu";
            this.lblLu.Size = new System.Drawing.Size(70, 37);
            this.lblLu.TabIndex = 1;
            this.lblLu.Text = "LU";
            this.lblLu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMa
            // 
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMa.Location = new System.Drawing.Point(140, 0);
            this.lblMa.Margin = new System.Windows.Forms.Padding(0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(70, 37);
            this.lblMa.TabIndex = 2;
            this.lblMa.Text = "MA";
            this.lblMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMi
            // 
            this.lblMi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMi.Location = new System.Drawing.Point(210, 0);
            this.lblMi.Margin = new System.Windows.Forms.Padding(0);
            this.lblMi.Name = "lblMi";
            this.lblMi.Size = new System.Drawing.Size(70, 37);
            this.lblMi.TabIndex = 3;
            this.lblMi.Text = "MI";
            this.lblMi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJu
            // 
            this.lblJu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJu.Location = new System.Drawing.Point(280, 0);
            this.lblJu.Margin = new System.Windows.Forms.Padding(0);
            this.lblJu.Name = "lblJu";
            this.lblJu.Size = new System.Drawing.Size(70, 37);
            this.lblJu.TabIndex = 4;
            this.lblJu.Text = "JU";
            this.lblJu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVi
            // 
            this.lblVi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVi.Location = new System.Drawing.Point(350, 0);
            this.lblVi.Margin = new System.Windows.Forms.Padding(0);
            this.lblVi.Name = "lblVi";
            this.lblVi.Size = new System.Drawing.Size(70, 37);
            this.lblVi.TabIndex = 5;
            this.lblVi.Text = "VI";
            this.lblVi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSa
            // 
            this.lblSa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSa.Location = new System.Drawing.Point(420, 0);
            this.lblSa.Margin = new System.Windows.Forms.Padding(0);
            this.lblSa.Name = "lblSa";
            this.lblSa.Size = new System.Drawing.Size(70, 37);
            this.lblSa.TabIndex = 7;
            this.lblSa.Text = "SA";
            this.lblSa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Name = "Calendario";
            this.Size = new System.Drawing.Size(490, 463);
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelDias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelPrincipal;
        private FlowLayoutPanel panelMes;
        private FlowLayoutPanel panelDias;
        private Label lblDo;
        private Label lblLu;
        private Label lblMa;
        private Label lblMi;
        private Label lblJu;
        private Label lblVi;
        private Label lblSa;
    }
}
