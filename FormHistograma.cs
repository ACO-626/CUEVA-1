using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Cueva_1
{
    public partial class btnTransformar : Form
    {
        Image<Gray, Byte> My_Image;
        Series serie;
        

        public btnTransformar()
        {
            InitializeComponent();
            int[] valor = new int[256];

            chart1.Titles.Add("NIVELES");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Gray, byte>(Openfile.FileName);
                //Image<Gray, Byte> My_gray = My_Image.Convert<Gray, byte>();
                //GrayImage = My_Image.Convert<Gray, byte>();
                //pictureBox1.Image = DemoImage.ToBitmap();
                //btnBuscar.Enabled = true;

                pictureBox1.Image = My_Image.ToBitmap();
                crearHistograma();
            }
        }

        private void crearHistograma()
        {
            if(serie != null)
            {
                serie.Points.Clear();
            }
            
            //limpiarContador();
            int[] contador = new int[256];
            for (int i =0; i<My_Image.Height; i++)
            {
                for(int j=0;j<My_Image.Width; j++)
                {
                    contador[(int)My_Image[i, j].Intensity]++;              
                }
            }
            for (int i = 0; i < 256; i++)
            {
                //serie = chart1.Series.Add(i.ToString());
                serie = chart1.Series["Intensidades"];
                serie.Points.Add(contador[i]);
            }

        }

        private void limpiarContador()
        {
            //for[
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = scrollCero.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = scrollAlto.Value.ToString();
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < My_Image.Height; i++)
            {
                for (int j = 0; j < My_Image.Width; j++)
                {
                    if ((int)My_Image[i, j].Intensity < scrollCero.Value)
                    {
                        My_Image[i, j] = new Gray(0);
                    }
                    if ((int)My_Image[i, j].Intensity > scrollAlto.Value)
                    {
                        My_Image[i, j] = new Gray(255);
                    }
                }
            }
            //crearHistograma();
            if (serie != null)
            {
                serie.Points.Clear();
            }

            //limpiarContador();
            int[] contador = new int[256];
            for (int i = 0; i < My_Image.Height; i++)
            {
                for (int j = 0; j < My_Image.Width; j++)
                {
                    if((int)My_Image[i,j].Intensity>=scrollCero.Value & (int)My_Image[i,j].Intensity<=scrollAlto.Value)
                    {
                        contador[(int)My_Image[i, j].Intensity]++;
                    }
                    
                }
            }
            for (int i = 0; i < 256; i++)
            {
                //serie = chart1.Series.Add(i.ToString());
                serie = chart1.Series["Intensidades"];
                serie.Points.Add(contador[i]);
            }



            pictureBox1.Image = My_Image.ToBitmap();
        }
    }
}
