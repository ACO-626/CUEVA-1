namespace Cueva_1
{
    partial class FormSegmentacion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboSensibilidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboForma = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbAnuncio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.lbForma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(277, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 570);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.Location = new System.Drawing.Point(95, 159);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(116, 53);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbForma);
            this.panel1.Controls.Add(this.comboSensibilidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboForma);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.lbAnuncio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 88);
            this.panel1.TabIndex = 3;
            // 
            // comboSensibilidad
            // 
            this.comboSensibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSensibilidad.FormattingEnabled = true;
            this.comboSensibilidad.Location = new System.Drawing.Point(321, 22);
            this.comboSensibilidad.Name = "comboSensibilidad";
            this.comboSensibilidad.Size = new System.Drawing.Size(121, 21);
            this.comboSensibilidad.TabIndex = 8;
            this.comboSensibilidad.SelectedIndexChanged += new System.EventHandler(this.comboSensibilidad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(326, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sensibilidad";
            // 
            // comboForma
            // 
            this.comboForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboForma.FormattingEnabled = true;
            this.comboForma.Location = new System.Drawing.Point(489, 22);
            this.comboForma.Name = "comboForma";
            this.comboForma.Size = new System.Drawing.Size(121, 21);
            this.comboForma.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(84, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "buscar blancos";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lbAnuncio
            // 
            this.lbAnuncio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAnuncio.AutoSize = true;
            this.lbAnuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnuncio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnuncio.Location = new System.Drawing.Point(982, 31);
            this.lbAnuncio.Name = "lbAnuncio";
            this.lbAnuncio.Size = new System.Drawing.Size(215, 31);
            this.lbAnuncio.TabIndex = 0;
            this.lbAnuncio.Text = "COINCIDENCIA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(95, 228);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 53);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.btnBuscar);
            this.panelleft.Controls.Add(this.btnImportar);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(214, 599);
            this.panelleft.TabIndex = 4;
            // 
            // lbForma
            // 
            this.lbForma.AutoSize = true;
            this.lbForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbForma.Location = new System.Drawing.Point(512, 47);
            this.lbForma.Name = "lbForma";
            this.lbForma.Size = new System.Drawing.Size(61, 22);
            this.lbForma.TabIndex = 9;
            this.lbForma.Text = "Forma";
            // 
            // FormSegmentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1209, 687);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSegmentacion";
            this.Text = "Segmentación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAnuncio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboForma;
        private System.Windows.Forms.ComboBox comboSensibilidad;
        private System.Windows.Forms.Label lbForma;
    }
}