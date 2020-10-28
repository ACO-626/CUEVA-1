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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSegmentacion));
            this.btnR = new System.Windows.Forms.PictureBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbForma = new System.Windows.Forms.Label();
            this.comboSensibilidad = new System.Windows.Forms.ComboBox();
            this.lbSensibilidad = new System.Windows.Forms.Label();
            this.comboForma = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbAnuncio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.pictureRadio = new System.Windows.Forms.PictureBox();
            this.pictureBrain = new System.Windows.Forms.PictureBox();
            this.pictureTumor = new System.Windows.Forms.PictureBox();
            this.lbTumor = new System.Windows.Forms.Button();
            this.lbCerebro = new System.Windows.Forms.Button();
            this.btnRadioGraf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTumor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnR
            // 
            this.btnR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnR.BackColor = System.Drawing.Color.Silver;
            this.btnR.Location = new System.Drawing.Point(277, 23);
            this.btnR.MaximumSize = new System.Drawing.Size(920, 571);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(920, 570);
            this.btnR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnR.TabIndex = 1;
            this.btnR.TabStop = false;
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
            this.panel1.Controls.Add(this.lbSensibilidad);
            this.panel1.Controls.Add(this.comboForma);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.lbAnuncio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 88);
            this.panel1.TabIndex = 3;
            // 
            // lbForma
            // 
            this.lbForma.AutoSize = true;
            this.lbForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbForma.Location = new System.Drawing.Point(517, 47);
            this.lbForma.Name = "lbForma";
            this.lbForma.Size = new System.Drawing.Size(61, 22);
            this.lbForma.TabIndex = 9;
            this.lbForma.Text = "Forma";
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
            // lbSensibilidad
            // 
            this.lbSensibilidad.AutoSize = true;
            this.lbSensibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSensibilidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSensibilidad.Location = new System.Drawing.Point(326, 47);
            this.lbSensibilidad.Name = "lbSensibilidad";
            this.lbSensibilidad.Size = new System.Drawing.Size(107, 22);
            this.lbSensibilidad.TabIndex = 7;
            this.lbSensibilidad.Text = "Sensibilidad";
            // 
            // comboForma
            // 
            this.comboForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboForma.FormattingEnabled = true;
            this.comboForma.Location = new System.Drawing.Point(489, 22);
            this.comboForma.Name = "comboForma";
            this.comboForma.Size = new System.Drawing.Size(121, 21);
            this.comboForma.TabIndex = 6;
            this.comboForma.SelectedIndexChanged += new System.EventHandler(this.comboForma_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(82, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "buscar blancos";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbAnuncio
            // 
            this.lbAnuncio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAnuncio.AutoSize = true;
            this.lbAnuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnuncio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnuncio.Location = new System.Drawing.Point(817, 23);
            this.lbAnuncio.Name = "lbAnuncio";
            this.lbAnuncio.Size = new System.Drawing.Size(89, 20);
            this.lbAnuncio.TabIndex = 0;
            this.lbAnuncio.Text = "MENSAJE:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(95, 237);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 53);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelleft
            // 
            this.panelleft.Controls.Add(this.btnRadioGraf);
            this.panelleft.Controls.Add(this.btnBuscar);
            this.panelleft.Controls.Add(this.btnImportar);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(214, 599);
            this.panelleft.TabIndex = 4;
            // 
            // pictureRadio
            // 
            this.pictureRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureRadio.Location = new System.Drawing.Point(244, 23);
            this.pictureRadio.Name = "pictureRadio";
            this.pictureRadio.Size = new System.Drawing.Size(432, 562);
            this.pictureRadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRadio.TabIndex = 5;
            this.pictureRadio.TabStop = false;
            this.pictureRadio.Visible = false;
            // 
            // pictureBrain
            // 
            this.pictureBrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBrain.Location = new System.Drawing.Point(682, 23);
            this.pictureBrain.Name = "pictureBrain";
            this.pictureBrain.Size = new System.Drawing.Size(244, 293);
            this.pictureBrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBrain.TabIndex = 6;
            this.pictureBrain.TabStop = false;
            this.pictureBrain.Visible = false;
            // 
            // pictureTumor
            // 
            this.pictureTumor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureTumor.Location = new System.Drawing.Point(932, 23);
            this.pictureTumor.Name = "pictureTumor";
            this.pictureTumor.Size = new System.Drawing.Size(244, 293);
            this.pictureTumor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTumor.TabIndex = 7;
            this.pictureTumor.TabStop = false;
            this.pictureTumor.Visible = false;
            // 
            // lbTumor
            // 
            this.lbTumor.Image = ((System.Drawing.Image)(resources.GetObject("lbTumor.Image")));
            this.lbTumor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTumor.Location = new System.Drawing.Point(722, 447);
            this.lbTumor.Name = "lbTumor";
            this.lbTumor.Size = new System.Drawing.Size(133, 33);
            this.lbTumor.TabIndex = 12;
            this.lbTumor.Text = "COINCIDENCIA";
            this.lbTumor.UseVisualStyleBackColor = true;
            this.lbTumor.Visible = false;
            // 
            // lbCerebro
            // 
            this.lbCerebro.Image = ((System.Drawing.Image)(resources.GetObject("lbCerebro.Image")));
            this.lbCerebro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCerebro.Location = new System.Drawing.Point(722, 408);
            this.lbCerebro.Name = "lbCerebro";
            this.lbCerebro.Size = new System.Drawing.Size(133, 33);
            this.lbCerebro.TabIndex = 13;
            this.lbCerebro.Text = "CEREBRO";
            this.lbCerebro.UseVisualStyleBackColor = true;
            this.lbCerebro.Visible = false;
            // 
            // btnRadioGraf
            // 
            this.btnRadioGraf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRadioGraf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRadioGraf.Location = new System.Drawing.Point(95, 159);
            this.btnRadioGraf.Name = "btnRadioGraf";
            this.btnRadioGraf.Size = new System.Drawing.Size(116, 53);
            this.btnRadioGraf.TabIndex = 4;
            this.btnRadioGraf.Text = "RADIOGRAFÍA";
            this.btnRadioGraf.UseVisualStyleBackColor = true;
            this.btnRadioGraf.Visible = false;
            this.btnRadioGraf.Click += new System.EventHandler(this.btnRadioGraf_Click);
            // 
            // FormSegmentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1209, 687);
            this.Controls.Add(this.lbCerebro);
            this.Controls.Add(this.lbTumor);
            this.Controls.Add(this.pictureTumor);
            this.Controls.Add(this.pictureBrain);
            this.Controls.Add(this.pictureRadio);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnR);
            this.Name = "FormSegmentacion";
            this.Text = "Segmentación";
            ((System.ComponentModel.ISupportInitialize)(this.btnR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTumor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnR;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAnuncio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbSensibilidad;
        private System.Windows.Forms.ComboBox comboForma;
        private System.Windows.Forms.ComboBox comboSensibilidad;
        private System.Windows.Forms.Label lbForma;
        private System.Windows.Forms.PictureBox pictureRadio;
        private System.Windows.Forms.PictureBox pictureBrain;
        private System.Windows.Forms.PictureBox pictureTumor;
        private System.Windows.Forms.Button lbTumor;
        private System.Windows.Forms.Button lbCerebro;
        private System.Windows.Forms.Button btnRadioGraf;
    }
}