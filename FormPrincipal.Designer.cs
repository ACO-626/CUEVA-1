namespace Cueva_1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelAmb = new System.Windows.Forms.Panel();
            this.btnPixelPark = new System.Windows.Forms.Button();
            this.btnMusica = new System.Windows.Forms.Button();
            this.btnAmbiente = new System.Windows.Forms.Button();
            this.panelIA = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSegmenta = new System.Windows.Forms.Button();
            this.btnIA = new System.Windows.Forms.Button();
            this.panelTrans = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRGB = new System.Windows.Forms.Button();
            this.btnIGrises3 = new System.Windows.Forms.Button();
            this.btnIGrises2 = new System.Windows.Forms.Button();
            this.btnCambColor = new System.Windows.Forms.Button();
            this.btnTransformar = new System.Windows.Forms.Button();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.btnComposicion = new System.Windows.Forms.Button();
            this.btnAsistido = new System.Windows.Forms.Button();
            this.btnLibre = new System.Windows.Forms.Button();
            this.btnDibujo = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelHijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelShow = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelAmb.SuspendLayout();
            this.panelIA.SuspendLayout();
            this.panelTrans.SuspendLayout();
            this.panelDibujo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.panelAmb);
            this.panelMenu.Controls.Add(this.btnAmbiente);
            this.panelMenu.Controls.Add(this.panelIA);
            this.panelMenu.Controls.Add(this.btnIA);
            this.panelMenu.Controls.Add(this.panelTrans);
            this.panelMenu.Controls.Add(this.btnTransformar);
            this.panelMenu.Controls.Add(this.panelDibujo);
            this.panelMenu.Controls.Add(this.btnDibujo);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelAmb
            // 
            this.panelAmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelAmb.Controls.Add(this.btnPixelPark);
            this.panelAmb.Controls.Add(this.btnMusica);
            this.panelAmb.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAmb.Location = new System.Drawing.Point(0, 739);
            this.panelAmb.Name = "panelAmb";
            this.panelAmb.Size = new System.Drawing.Size(233, 109);
            this.panelAmb.TabIndex = 7;
            // 
            // btnPixelPark
            // 
            this.btnPixelPark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPixelPark.FlatAppearance.BorderSize = 0;
            this.btnPixelPark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPixelPark.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPixelPark.Location = new System.Drawing.Point(0, 40);
            this.btnPixelPark.Name = "btnPixelPark";
            this.btnPixelPark.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPixelPark.Size = new System.Drawing.Size(233, 40);
            this.btnPixelPark.TabIndex = 1;
            this.btnPixelPark.Text = "Crear vida";
            this.btnPixelPark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPixelPark.UseVisualStyleBackColor = true;
            this.btnPixelPark.Click += new System.EventHandler(this.btnPixelPark_Click);
            // 
            // btnMusica
            // 
            this.btnMusica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusica.FlatAppearance.BorderSize = 0;
            this.btnMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMusica.Location = new System.Drawing.Point(0, 0);
            this.btnMusica.Name = "btnMusica";
            this.btnMusica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMusica.Size = new System.Drawing.Size(233, 40);
            this.btnMusica.TabIndex = 0;
            this.btnMusica.Text = "Música";
            this.btnMusica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusica.UseVisualStyleBackColor = true;
            // 
            // btnAmbiente
            // 
            this.btnAmbiente.BackColor = System.Drawing.Color.Black;
            this.btnAmbiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmbiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAmbiente.FlatAppearance.BorderSize = 0;
            this.btnAmbiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbiente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAmbiente.Location = new System.Drawing.Point(0, 694);
            this.btnAmbiente.Name = "btnAmbiente";
            this.btnAmbiente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAmbiente.Size = new System.Drawing.Size(233, 45);
            this.btnAmbiente.TabIndex = 6;
            this.btnAmbiente.Text = "Ambiente";
            this.btnAmbiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmbiente.UseVisualStyleBackColor = false;
            this.btnAmbiente.Click += new System.EventHandler(this.btnAmbiente_Click);
            // 
            // panelIA
            // 
            this.panelIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelIA.Controls.Add(this.btn1);
            this.panelIA.Controls.Add(this.btnSegmenta);
            this.panelIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIA.Location = new System.Drawing.Point(0, 594);
            this.panelIA.Name = "panelIA";
            this.panelIA.Size = new System.Drawing.Size(233, 100);
            this.panelIA.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(0, 40);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn1.Size = new System.Drawing.Size(233, 40);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnSegmenta
            // 
            this.btnSegmenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSegmenta.FlatAppearance.BorderSize = 0;
            this.btnSegmenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegmenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSegmenta.Location = new System.Drawing.Point(0, 0);
            this.btnSegmenta.Name = "btnSegmenta";
            this.btnSegmenta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSegmenta.Size = new System.Drawing.Size(233, 40);
            this.btnSegmenta.TabIndex = 0;
            this.btnSegmenta.Text = "Segmentación";
            this.btnSegmenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSegmenta.UseVisualStyleBackColor = true;
            this.btnSegmenta.Click += new System.EventHandler(this.btnSegmenta_Click);
            // 
            // btnIA
            // 
            this.btnIA.BackColor = System.Drawing.Color.Black;
            this.btnIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIA.FlatAppearance.BorderSize = 0;
            this.btnIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIA.Location = new System.Drawing.Point(0, 549);
            this.btnIA.Name = "btnIA";
            this.btnIA.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIA.Size = new System.Drawing.Size(233, 45);
            this.btnIA.TabIndex = 4;
            this.btnIA.Text = "Inteligencia Artificial";
            this.btnIA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIA.UseVisualStyleBackColor = false;
            this.btnIA.Click += new System.EventHandler(this.btnIA_Click);
            // 
            // panelTrans
            // 
            this.panelTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelTrans.Controls.Add(this.button1);
            this.panelTrans.Controls.Add(this.btnRGB);
            this.panelTrans.Controls.Add(this.btnIGrises3);
            this.panelTrans.Controls.Add(this.btnIGrises2);
            this.panelTrans.Controls.Add(this.btnCambColor);
            this.panelTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrans.Location = new System.Drawing.Point(0, 334);
            this.panelTrans.Name = "panelTrans";
            this.panelTrans.Size = new System.Drawing.Size(233, 215);
            this.panelTrans.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 160);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Niveles";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRGB
            // 
            this.btnRGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRGB.FlatAppearance.BorderSize = 0;
            this.btnRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRGB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRGB.Location = new System.Drawing.Point(0, 120);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRGB.Size = new System.Drawing.Size(233, 40);
            this.btnRGB.TabIndex = 3;
            this.btnRGB.Text = "Curvas RGB";
            this.btnRGB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRGB.UseVisualStyleBackColor = true;
            // 
            // btnIGrises3
            // 
            this.btnIGrises3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIGrises3.FlatAppearance.BorderSize = 0;
            this.btnIGrises3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIGrises3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIGrises3.Location = new System.Drawing.Point(0, 80);
            this.btnIGrises3.Name = "btnIGrises3";
            this.btnIGrises3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIGrises3.Size = new System.Drawing.Size(233, 40);
            this.btnIGrises3.TabIndex = 2;
            this.btnIGrises3.Text = "Intensidad cúbica en grises";
            this.btnIGrises3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIGrises3.UseVisualStyleBackColor = true;
            // 
            // btnIGrises2
            // 
            this.btnIGrises2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIGrises2.FlatAppearance.BorderSize = 0;
            this.btnIGrises2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIGrises2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIGrises2.Location = new System.Drawing.Point(0, 40);
            this.btnIGrises2.Name = "btnIGrises2";
            this.btnIGrises2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIGrises2.Size = new System.Drawing.Size(233, 40);
            this.btnIGrises2.TabIndex = 1;
            this.btnIGrises2.Text = "Intensidad en grises";
            this.btnIGrises2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIGrises2.UseVisualStyleBackColor = true;
            // 
            // btnCambColor
            // 
            this.btnCambColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambColor.FlatAppearance.BorderSize = 0;
            this.btnCambColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCambColor.Location = new System.Drawing.Point(0, 0);
            this.btnCambColor.Name = "btnCambColor";
            this.btnCambColor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCambColor.Size = new System.Drawing.Size(233, 40);
            this.btnCambColor.TabIndex = 0;
            this.btnCambColor.Text = "Cambiar color";
            this.btnCambColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambColor.UseVisualStyleBackColor = true;
            // 
            // btnTransformar
            // 
            this.btnTransformar.BackColor = System.Drawing.Color.Black;
            this.btnTransformar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransformar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransformar.FlatAppearance.BorderSize = 0;
            this.btnTransformar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransformar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransformar.Location = new System.Drawing.Point(0, 289);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransformar.Size = new System.Drawing.Size(233, 45);
            this.btnTransformar.TabIndex = 2;
            this.btnTransformar.Text = "Transformar";
            this.btnTransformar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransformar.UseVisualStyleBackColor = false;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelDibujo.Controls.Add(this.btnComposicion);
            this.panelDibujo.Controls.Add(this.btnAsistido);
            this.panelDibujo.Controls.Add(this.btnLibre);
            this.panelDibujo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDibujo.Location = new System.Drawing.Point(0, 145);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(233, 144);
            this.panelDibujo.TabIndex = 1;
            // 
            // btnComposicion
            // 
            this.btnComposicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComposicion.FlatAppearance.BorderSize = 0;
            this.btnComposicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComposicion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnComposicion.Location = new System.Drawing.Point(0, 80);
            this.btnComposicion.Name = "btnComposicion";
            this.btnComposicion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnComposicion.Size = new System.Drawing.Size(233, 40);
            this.btnComposicion.TabIndex = 2;
            this.btnComposicion.Text = "Composiciones";
            this.btnComposicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComposicion.UseVisualStyleBackColor = true;
            // 
            // btnAsistido
            // 
            this.btnAsistido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistido.FlatAppearance.BorderSize = 0;
            this.btnAsistido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAsistido.Location = new System.Drawing.Point(0, 40);
            this.btnAsistido.Name = "btnAsistido";
            this.btnAsistido.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAsistido.Size = new System.Drawing.Size(233, 40);
            this.btnAsistido.TabIndex = 1;
            this.btnAsistido.Text = "Asistido";
            this.btnAsistido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistido.UseVisualStyleBackColor = true;
            // 
            // btnLibre
            // 
            this.btnLibre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibre.FlatAppearance.BorderSize = 0;
            this.btnLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLibre.Location = new System.Drawing.Point(0, 0);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLibre.Size = new System.Drawing.Size(233, 40);
            this.btnLibre.TabIndex = 0;
            this.btnLibre.Text = "Libre";
            this.btnLibre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibre.UseVisualStyleBackColor = true;
            // 
            // btnDibujo
            // 
            this.btnDibujo.BackColor = System.Drawing.Color.Black;
            this.btnDibujo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDibujo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDibujo.FlatAppearance.BorderSize = 0;
            this.btnDibujo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDibujo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDibujo.Location = new System.Drawing.Point(0, 100);
            this.btnDibujo.Name = "btnDibujo";
            this.btnDibujo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDibujo.Size = new System.Drawing.Size(233, 45);
            this.btnDibujo.TabIndex = 1;
            this.btnDibujo.Text = "Dibujo";
            this.btnDibujo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDibujo.UseVisualStyleBackColor = false;
            this.btnDibujo.Click += new System.EventHandler(this.btnDibujo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Location = new System.Drawing.Point(43, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(136, 94);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // panelHijo
            // 
            this.panelHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.panelHijo.Controls.Add(this.pictureBox1);
            this.panelHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHijo.Location = new System.Drawing.Point(250, 0);
            this.panelHijo.Name = "panelHijo";
            this.panelHijo.Size = new System.Drawing.Size(684, 561);
            this.panelHijo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.panelShow.Controls.Add(this.btnShow);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelShow.Location = new System.Drawing.Point(250, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(24, 561);
            this.panelShow.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Location = new System.Drawing.Point(0, 267);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(21, 22);
            this.btnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShow.TabIndex = 0;
            this.btnShow.TabStop = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelHijo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(99, 98);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUEVA-1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelAmb.ResumeLayout(false);
            this.panelIA.ResumeLayout(false);
            this.panelTrans.ResumeLayout(false);
            this.panelDibujo.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelAmb;
        private System.Windows.Forms.Button btnPixelPark;
        private System.Windows.Forms.Button btnMusica;
        private System.Windows.Forms.Button btnAmbiente;
        private System.Windows.Forms.Panel panelIA;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSegmenta;
        private System.Windows.Forms.Button btnIA;
        private System.Windows.Forms.Panel panelTrans;
        private System.Windows.Forms.Button btnRGB;
        private System.Windows.Forms.Button btnIGrises3;
        private System.Windows.Forms.Button btnIGrises2;
        private System.Windows.Forms.Button btnCambColor;
        private System.Windows.Forms.Button btnTransformar;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Button btnComposicion;
        private System.Windows.Forms.Button btnAsistido;
        private System.Windows.Forms.Button btnLibre;
        private System.Windows.Forms.Button btnDibujo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.PictureBox btnShow;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button button1;
    }
}

