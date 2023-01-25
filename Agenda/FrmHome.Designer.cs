namespace Visual
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUser = new Individual.Visual.ComponentesMod.RJButton();
            this.pbUser = new CustomControls.RJControls.RJCircularPictureBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLista = new System.Windows.Forms.Panel();
            this.tPanelCheckList = new System.Windows.Forms.TableLayoutPanel();
            this.lblCheckList = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMod10 = new Individual.Visual.ComponentesMod.PanelMod();
            this.panelMod1 = new Individual.Visual.ComponentesMod.PanelMod();
            this.panelMod12 = new Individual.Visual.ComponentesMod.PanelMod();
            this.panelMod14 = new Individual.Visual.ComponentesMod.PanelMod();
            this.calendario1 = new Visual.UserControls.Calendario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCrearTarea = new Individual.Visual.ComponentesMod.RJButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelLista.SuspendLayout();
            this.tPanelCheckList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.rjTextBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 45);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnUser);
            this.flowLayoutPanel1.Controls.Add(this.pbUser);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(880, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 45);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUser.BorderRadius = 0;
            this.btnUser.BorderSize = 0;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.Location = new System.Drawing.Point(327, 7);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnUser.MinimumSize = new System.Drawing.Size(110, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUser.Size = new System.Drawing.Size(113, 34);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Rogger Párraga 🔻";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.TextColor = System.Drawing.Color.Black;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // pbUser
            // 
            this.pbUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbUser.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbUser.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbUser.BorderSize = 0;
            this.pbUser.GradientAngle = 50F;
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(287, 2);
            this.pbUser.Margin = new System.Windows.Forms.Padding(0);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(40, 40);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 7;
            this.pbUser.TabStop = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(232)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(232)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderRadius = 10;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox2.ForeColor = System.Drawing.Color.White;
            this.rjTextBox2.Location = new System.Drawing.Point(0, 6);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.White;
            this.rjTextBox2.PlaceholderText = "🔎 Buscar";
            this.rjTextBox2.Size = new System.Drawing.Size(447, 35);
            this.rjTextBox2.TabIndex = 0;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.calendario1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 55);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1330, 664);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panelLista, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(960, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 658);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.Color.Transparent;
            this.panelLista.Controls.Add(this.tPanelCheckList);
            this.panelLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLista.Location = new System.Drawing.Point(0, 104);
            this.panelLista.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panelLista.Name = "panelLista";
            this.panelLista.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelLista.Size = new System.Drawing.Size(367, 548);
            this.panelLista.TabIndex = 6;
            // 
            // tPanelCheckList
            // 
            this.tPanelCheckList.BackColor = System.Drawing.Color.White;
            this.tPanelCheckList.ColumnCount = 1;
            this.tPanelCheckList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tPanelCheckList.Controls.Add(this.lblCheckList, 0, 0);
            this.tPanelCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tPanelCheckList.Location = new System.Drawing.Point(10, 0);
            this.tPanelCheckList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.tPanelCheckList.Name = "tPanelCheckList";
            this.tPanelCheckList.RowCount = 11;
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tPanelCheckList.Size = new System.Drawing.Size(347, 548);
            this.tPanelCheckList.TabIndex = 0;
            // 
            // lblCheckList
            // 
            this.lblCheckList.AutoSize = true;
            this.lblCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckList.Location = new System.Drawing.Point(10, 0);
            this.lblCheckList.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblCheckList.Name = "lblCheckList";
            this.lblCheckList.Size = new System.Drawing.Size(334, 54);
            this.lblCheckList.TabIndex = 0;
            this.lblCheckList.Text = "CheckList";
            this.lblCheckList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelMod10);
            this.panel3.Controls.Add(this.panelMod1);
            this.panel3.Controls.Add(this.panelMod12);
            this.panel3.Controls.Add(this.panelMod14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 92);
            this.panel3.TabIndex = 7;
            // 
            // panelMod10
            // 
            this.panelMod10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMod10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.panelMod10.BorderRadius = 10;
            this.panelMod10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMod10.ForeColor = System.Drawing.Color.Black;
            this.panelMod10.GradientAngle = 90F;
            this.panelMod10.GradientBottomColor = System.Drawing.Color.Transparent;
            this.panelMod10.GradientTopColor = System.Drawing.Color.Transparent;
            this.panelMod10.Location = new System.Drawing.Point(77, 63);
            this.panelMod10.Margin = new System.Windows.Forms.Padding(0);
            this.panelMod10.Name = "panelMod10";
            this.panelMod10.Size = new System.Drawing.Size(70, 92);
            this.panelMod10.TabIndex = 3;
            this.panelMod10.Click += new System.EventHandler(this.panelMod10_Click_2);
            // 
            // panelMod1
            // 
            this.panelMod1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMod1.BackColor = System.Drawing.Color.White;
            this.panelMod1.BorderRadius = 10;
            this.panelMod1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMod1.ForeColor = System.Drawing.Color.Black;
            this.panelMod1.GradientAngle = 90F;
            this.panelMod1.GradientBottomColor = System.Drawing.Color.White;
            this.panelMod1.GradientTopColor = System.Drawing.Color.White;
            this.panelMod1.Location = new System.Drawing.Point(7, 63);
            this.panelMod1.Margin = new System.Windows.Forms.Padding(0);
            this.panelMod1.Name = "panelMod1";
            this.panelMod1.Size = new System.Drawing.Size(70, 92);
            this.panelMod1.TabIndex = 5;
            this.panelMod1.Click += new System.EventHandler(this.panelMod1_Click_1);
            // 
            // panelMod12
            // 
            this.panelMod12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMod12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.panelMod12.BorderRadius = 10;
            this.panelMod12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMod12.ForeColor = System.Drawing.Color.Black;
            this.panelMod12.GradientAngle = 90F;
            this.panelMod12.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.panelMod12.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(240)))));
            this.panelMod12.Location = new System.Drawing.Point(146, 63);
            this.panelMod12.Margin = new System.Windows.Forms.Padding(0);
            this.panelMod12.Name = "panelMod12";
            this.panelMod12.Size = new System.Drawing.Size(70, 92);
            this.panelMod12.TabIndex = 4;
            this.panelMod12.Click += new System.EventHandler(this.panelMod12_Click_1);
            // 
            // panelMod14
            // 
            this.panelMod14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMod14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.panelMod14.BorderRadius = 10;
            this.panelMod14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMod14.ForeColor = System.Drawing.Color.Black;
            this.panelMod14.GradientAngle = 90F;
            this.panelMod14.GradientBottomColor = System.Drawing.Color.Transparent;
            this.panelMod14.GradientTopColor = System.Drawing.Color.Transparent;
            this.panelMod14.Location = new System.Drawing.Point(215, 63);
            this.panelMod14.Margin = new System.Windows.Forms.Padding(0);
            this.panelMod14.Name = "panelMod14";
            this.panelMod14.Size = new System.Drawing.Size(70, 92);
            this.panelMod14.TabIndex = 5;
            this.panelMod14.Click += new System.EventHandler(this.panelMod14_Click_1);
            // 
            // calendario1
            // 
            this.calendario1.BordeColor = System.Drawing.Color.Silver;
            this.calendario1.ColorDia = System.Drawing.Color.White;
            this.calendario1.ColorDiaSeleccionado = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.SetColumnSpan(this.calendario1, 3);
            this.calendario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendario1.FuenteDias = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendario1.FuenteDiasColor = System.Drawing.Color.Empty;
            this.calendario1.Location = new System.Drawing.Point(3, 69);
            this.calendario1.MinimumSize = new System.Drawing.Size(150, 100);
            this.calendario1.Name = "calendario1";
            this.tableLayoutPanel1.SetRowSpan(this.calendario1, 2);
            this.calendario1.Size = new System.Drawing.Size(951, 592);
            this.calendario1.TabIndex = 4;
            this.calendario1.TipoDias = Visual.UserControls.Calendario.LabelTextOptions.Completo;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.btnCrearTarea);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 60);
            this.panel2.TabIndex = 5;
            // 
            // btnCrearTarea
            // 
            this.btnCrearTarea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearTarea.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCrearTarea.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCrearTarea.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrearTarea.BorderRadius = 0;
            this.btnCrearTarea.BorderSize = 0;
            this.btnCrearTarea.FlatAppearance.BorderSize = 0;
            this.btnCrearTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTarea.ForeColor = System.Drawing.Color.White;
            this.btnCrearTarea.Location = new System.Drawing.Point(785, 23);
            this.btnCrearTarea.Name = "btnCrearTarea";
            this.btnCrearTarea.Size = new System.Drawing.Size(153, 26);
            this.btnCrearTarea.TabIndex = 2;
            this.btnCrearTarea.Text = "+ Añadir Tarea";
            this.btnCrearTarea.TextColor = System.Drawing.Color.White;
            this.btnCrearTarea.UseVisualStyleBackColor = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(0, 23);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(207, 37);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = " 01 Enero 2023";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmHome";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.Resize += new System.EventHandler(this.FrmHome_Resize);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelLista.ResumeLayout(false);
            this.tPanelCheckList.ResumeLayout(false);
            this.tPanelCheckList.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;

        /*  Aún no tienen uso
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Individual.Visual.ComponentesMod.PanelMod panelMod1;
        private Individual.Visual.ComponentesMod.RJButton btnPerfil;
        private CustomControls.RJControls.RJDropdownMenu menuPerfil;
        private Individual.Visual.ComponentesMod.PanelMod panelMod8;
        private Individual.Visual.ComponentesMod.PanelMod panelMod9;
        private Individual.Visual.ComponentesMod.PanelMod panelMod6;
        private Individual.Visual.ComponentesMod.PanelMod panelMod7;
        private Individual.Visual.ComponentesMod.PanelMod panelMod4;
        private Individual.Visual.ComponentesMod.PanelMod panelMod5;
        private Individual.Visual.ComponentesMod.PanelMod panelMod2;
        private Individual.Visual.ComponentesMod.PanelMod panelMod3;
        */

        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Individual.Visual.ComponentesMod.RJButton btnUser;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJCircularPictureBox pbUser;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelLista;
        private TableLayoutPanel tPanelCheckList;
        private Label lblCheckList;
        private Panel panel3;
        private Individual.Visual.ComponentesMod.PanelMod panelMod1;
        private Individual.Visual.ComponentesMod.PanelMod panelMod12;
        private Individual.Visual.ComponentesMod.PanelMod panelMod14;
        private Individual.Visual.ComponentesMod.PanelMod panelMod10;
        private Panel panel2;
        private Individual.Visual.ComponentesMod.RJButton btnCrearTarea;
        private Label lblFecha;
        private UserControls.Calendario calendario1;
    }
}