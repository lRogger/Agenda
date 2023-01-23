namespace Visual
{
    partial class Foto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(112, 66);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(111, 190);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(310, 87);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(155, 52);
            this.btnSubir.TabIndex = 1;
            this.btnSubir.Text = "button1";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(311, 175);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(154, 67);
            this.btnBajar.TabIndex = 2;
            this.btnBajar.Text = "button1";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(518, 103);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(150, 23);
            this.tbLink.TabIndex = 3;
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.pbFoto);
            this.Name = "Foto";
            this.Text = "Foto";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbFoto;
        private Button btnSubir;
        private Button btnBajar;
        private TextBox tbLink;
    }
}