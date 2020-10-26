using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Cueva_1
{
    public partial class FormSegmentacion : Form
    {
        bool coinc = false;
        int intensidad = 128;
        int yin = 0;
        int yan = 1;
        int aba;
        int der;
        int izq;
        int[,] matrizImage;
        int[,] ubicacion=new int[4,2];
        Image<Bgr, Byte> My_Image;
        Image<Gray, Byte> imageGray;
        Graphics papel;
        Pen pluma = new Pen(Color.DarkRed);
        

        public FormSegmentacion()
        {
            InitializeComponent();
            for (int i = 0; i <= 255; i++)
                comboSensibilidad.Items.Add(i);
            comboForma.Items.Add("Cuirculo");
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                //Image<Gray, Byte> My_gray = My_Image.Convert<Gray, byte>();
                //GrayImage = My_Image.Convert<Gray, byte>();
                //pictureBox1.Image = DemoImage.ToBitmap();
                //btnBuscar.Enabled = true;
                coinc = false;
                matrizImage = new int[My_Image.Height,My_Image.Width];
                pictureBox1.Image = My_Image.ToBitmap();

            }

        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //matrizImage = new int[(My_Image.Width)+1, (My_Image.Height)+1];
            
            blancoNegro(My_Image);
            vaciarMatriz();    
           
            
        }


        private void blancoNegro(Image<Bgr,byte> imagen)
        {
            if(imagen != null)
            {
                imageGray = imagen.Convert<Gray, byte>();
            }
            else
            {
                OpenFileDialog Openfile = new OpenFileDialog();
                if (Openfile.ShowDialog() == DialogResult.OK)
                {
                    My_Image = new Image<Bgr, byte>(Openfile.FileName);
                    imageGray = new Image<Gray, byte>(Openfile.FileName);

                    pictureBox1.Image = My_Image.ToBitmap();
                    matrizImage = new int[(imageGray.Height), (imageGray.Width)];
                }
            }
          
            for (int i = 0; i < imageGray.Height; i++)
            {
                for (int j = 0; j < imageGray.Width; j++)
                {
                    if((int)imageGray[i,j].Intensity<intensidad)
                    {
                        imageGray[i, j] = new Gray(0);
                        matrizImage[i, j] = 0;
                    }
                    else
                    {
                        imageGray[i, j] = new Gray(255);
                        matrizImage[i, j] = 1;
                    }

                    
                }
            }
            //pictureBox1.Image = imageGray.ToBitmap();
            //Busqueda
            for (int i = 0; i < imageGray.Height; i++)
            {
                for (int j = 0; j < imageGray.Width; j++)
                {
                    if (yin == matrizImage[i, j])
                    {
                        
                        //Verifica abajo
                        aba = abajo(i,j);
                        if(aba>6)
                        {
                            
                            //MessageBox.Show("Abajo"+aba.ToString() + " i" + i.ToString()+"j" +j.ToString());
                            
                            
                            izq = izquierda(i + (aba / 2), j);
                            
                            if (izq>6)
                            {
                               // MessageBox.Show("izq" + izq.ToString() );
                                der = derecha(i + (aba / 2), j);
                                if(der>6)
                                {
                                   // MessageBox.Show("der " + der.ToString());
                                    ubicacion [0, 0] = i;
                                    ubicacion [0, 1] = j-izq;
                                    ubicacion [1, 0] = izq+der;
                                    ubicacion [1, 1] = aba;
                                    coinc = true;
                                    break;
                                    

                                }
                            }
                        }
                    }

                }
                if(coinc)
                {
                    break;
                }
            }

            if(coinc)
            {
                lbAnuncio.Text = "Localizado";
                
                papel = pictureBox1.CreateGraphics();
                papel.DrawRectangle(pluma,ubicacion[0,1],ubicacion[0,0],ubicacion[1,0],ubicacion[1,1]);
                 //papel.DrawRectangle(pluma, 613, 57, 10, 10);
            }
            else
            {
                lbAnuncio.Text = "No encontrado";
            }


            //pictureBox1.Image = imageGray.ToBitmap();
        }
 

        private int abajo(int i, int j)
        {
            int resultado=0;
            while(matrizImage[i,j]==yin & i<My_Image.Height)
            {
                i++;                
                resultado++;
            }

            return resultado;
        }
        private int izquierda(int i, int j)
        {
            int resultado = 0;
            while (matrizImage[i, j] == yin & j > 0)
            {
                j--;
                resultado++;
            }

            return resultado;
        }
        private int derecha(int i, int j)
        {
            int resultado = 0;
            while (matrizImage[i, j] == yin & j < My_Image.Width)
            {
                j++;
                resultado++;
            }

            return resultado;
        }

        private void comboSensibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(comboSensibilidad.Text) < 0)
                    intensidad = 0;
                if (int.Parse(comboSensibilidad.Text) > 255)
                    intensidad = 255;
                intensidad = (int)comboSensibilidad.SelectedItem;
                vaciarMatriz();

            }catch(Exception)
            {
                intensidad = 128;
            }

        }
        private void vaciarMatriz()
        {
            for(int i =0;i<imageGray.Height;i++)
            {
                for (int j = 0; j < imageGray.Width; j++)
                {
                    matrizImage[i, j] = 0;
                }
            }

            ubicacion[0, 0] = 0;
            ubicacion[0, 1] = 0;
            ubicacion[1, 0] = 0;
            ubicacion[1, 1] = 0;
            coinc = false;

        }
    }
}
