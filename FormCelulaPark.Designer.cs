namespace Cueva_1
{
    partial class FormCelula
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCelula));
            this.isla = new System.Windows.Forms.PictureBox();
            this.btnAzar = new System.Windows.Forms.Button();
            this.btnCreacion = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboTamaño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtincion = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolcan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.isla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAudio)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolcan)).BeginInit();
            this.SuspendLayout();
            // 
            // isla
            // 
            this.isla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.isla.Location = new System.Drawing.Point(155, 12);
            this.isla.Name = "isla";
            this.isla.Size = new System.Drawing.Size(400, 400);
            this.isla.TabIndex = 0;
            this.isla.TabStop = false;
            // 
            // btnAzar
            // 
            this.btnAzar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAzar.FlatAppearance.BorderSize = 0;
            this.btnAzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAzar.Location = new System.Drawing.Point(226, 33);
            this.btnAzar.Name = "btnAzar";
            this.btnAzar.Size = new System.Drawing.Size(59, 46);
            this.btnAzar.TabIndex = 1;
            this.btnAzar.Text = "CAOS";
            this.btnAzar.UseVisualStyleBackColor = false;
            this.btnAzar.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCreacion
            // 
            this.btnCreacion.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCreacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreacion.Enabled = false;
            this.btnCreacion.FlatAppearance.BorderSize = 0;
            this.btnCreacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreacion.ForeColor = System.Drawing.Color.Azure;
            this.btnCreacion.Location = new System.Drawing.Point(101, 33);
            this.btnCreacion.Name = "btnCreacion";
            this.btnCreacion.Size = new System.Drawing.Size(119, 46);
            this.btnCreacion.TabIndex = 2;
            this.btnCreacion.Text = "VIDA";
            this.btnCreacion.UseVisualStyleBackColor = false;
            this.btnCreacion.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStop.Location = new System.Drawing.Point(31, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 47);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboTamaño
            // 
            this.comboTamaño.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTamaño.FormattingEnabled = true;
            this.comboTamaño.Location = new System.Drawing.Point(307, 45);
            this.comboTamaño.Name = "comboTamaño";
            this.comboTamaño.Size = new System.Drawing.Size(161, 33);
            this.comboTamaño.TabIndex = 4;
            this.comboTamaño.SelectedIndexChanged += new System.EventHandler(this.comboTamaño_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tamaño de células";
            // 
            // btnExtincion
            // 
            this.btnExtincion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExtincion.BackColor = System.Drawing.Color.Maroon;
            this.btnExtincion.FlatAppearance.BorderSize = 0;
            this.btnExtincion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtincion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtincion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExtincion.Location = new System.Drawing.Point(499, 41);
            this.btnExtincion.Name = "btnExtincion";
            this.btnExtincion.Size = new System.Drawing.Size(162, 37);
            this.btnExtincion.TabIndex = 6;
            this.btnExtincion.Text = "¡EXTINCIÓN!";
            this.btnExtincion.UseVisualStyleBackColor = false;
            this.btnExtincion.Click += new System.EventHandler(this.btnExtincion_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudio.BackColor = System.Drawing.Color.Transparent;
            this.btnAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnAudio.Image")));
            this.btnAudio.Location = new System.Drawing.Point(670, 73);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(28, 27);
            this.btnAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAudio.TabIndex = 8;
            this.btnAudio.TabStop = false;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAzar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAudio);
            this.panel1.Controls.Add(this.comboTamaño);
            this.panel1.Controls.Add(this.btnCreacion);
            this.panel1.Controls.Add(this.btnExtincion);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 100);
            this.panel1.TabIndex = 9;
            // 
            // btnVolcan
            // 
            this.btnVolcan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolcan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolcan.Image = ((System.Drawing.Image)(resources.GetObject("btnVolcan.Image")));
            this.btnVolcan.Location = new System.Drawing.Point(652, 2);
            this.btnVolcan.Name = "btnVolcan";
            this.btnVolcan.Size = new System.Drawing.Size(46, 40);
            this.btnVolcan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolcan.TabIndex = 10;
            this.btnVolcan.TabStop = false;
            this.btnVolcan.Click += new System.EventHandler(this.btnVolcan_Click);
            // 
            // FormCelula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(698, 520);
            this.Controls.Add(this.btnVolcan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.isla);
            this.Name = "FormCelula";
            this.Text = "Celular Park";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.isla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAudio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolcan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox isla;
        private System.Windows.Forms.Button btnAzar;
        private System.Windows.Forms.Button btnCreacion;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtincion;
        private System.Windows.Forms.PictureBox btnAudio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnVolcan;
    }
}

