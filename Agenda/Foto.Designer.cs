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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foto));
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(310, 87);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(155, 52);
            this.btnSubir.TabIndex = 1;
            this.btnSubir.Text = "Enviar";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(311, 175);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(154, 67);
            this.btnBajar.TabIndex = 2;
            this.btnBajar.Text = "Cargar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(511, 198);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(150, 23);
            this.tbLink.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbHash
            // 
            this.tbHash.Location = new System.Drawing.Point(511, 280);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(100, 23);
            this.tbHash.TabIndex = 5;
            // 
            // pbImg
            // 
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(77, 119);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(155, 138);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 6;
            this.pbImg.TabStop = false;
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Name = "Foto";
            this.Text = "Foto";
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSubir;
        private Button btnBajar;
        private TextBox tbLink;
        private Button button1;
        private TextBox tbHash;
        private PictureBox pbImg;
    }
}