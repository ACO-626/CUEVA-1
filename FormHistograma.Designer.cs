namespace Cueva_1
{
    partial class btnTransformar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label255 = new System.Windows.Forms.Label();
            this.labelCero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrollAlto = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollCero = new System.Windows.Forms.HScrollBar();
            this.btnImport = new System.Windows.Forms.Button();
            this.btntrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(135, 371);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Intensidades";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(897, 185);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntrans);
            this.panel1.Controls.Add(this.label255);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.labelCero);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.scrollAlto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scrollCero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 100);
            this.panel1.TabIndex = 2;
            // 
            // label255
            // 
            this.label255.AutoSize = true;
            this.label255.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label255.Location = new System.Drawing.Point(932, 17);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(75, 13);
            this.label255.TabIndex = 8;
            this.label255.Text = "Nuevo Blanco";
            // 
            // labelCero
            // 
            this.labelCero.AutoSize = true;
            this.labelCero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCero.Location = new System.Drawing.Point(165, 17);
            this.labelCero.Name = "labelCero";
            this.labelCero.Size = new System.Drawing.Size(71, 13);
            this.labelCero.TabIndex = 7;
            this.labelCero.Text = "Nuevo Negro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(746, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "255";
            // 
            // scrollAlto
            // 
            this.scrollAlto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollAlto.Location = new System.Drawing.Point(554, 39);
            this.scrollAlto.Maximum = 264;
            this.scrollAlto.Name = "scrollAlto";
            this.scrollAlto.Size = new System.Drawing.Size(441, 31);
            this.scrollAlto.TabIndex = 5;
            this.scrollAlto.Value = 255;
            this.scrollAlto.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(347, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // scrollCero
            // 
            this.scrollCero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scrollCero.Location = new System.Drawing.Point(157, 39);
            this.scrollCero.Maximum = 264;
            this.scrollCero.Name = "scrollCero";
            this.scrollCero.Size = new System.Drawing.Size(397, 31);
            this.scrollCero.TabIndex = 3;
            this.scrollCero.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(43, 17);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 62);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btntrans
            // 
            this.btntrans.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btntrans.Location = new System.Drawing.Point(1050, 17);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(83, 62);
            this.btntrans.TabIndex = 3;
            this.btntrans.Text = "Transformar";
            this.btntrans.UseVisualStyleBackColor = true;
            this.btntrans.Click += new System.EventHandler(this.btntrans_Click);
            // 
            // btnTransformar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1145, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Name = "btnTransformar";
            this.Text = "FormHistograma";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.HScrollBar scrollCero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar scrollAlto;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label labelCero;
        private System.Windows.Forms.Button btntrans;
    }
}