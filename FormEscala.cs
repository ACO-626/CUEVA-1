using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

using Emgu.CV.Structure;
using System.Globalization;
using Emgu.CV.ImgHash;

namespace Cueva_1
{
    public partial class FormEscala : Form
    {

        Image<Bgr, Byte> My_Image;
        
        //Image<Gray, Byte> My_Gray;

        public FormEscala()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                //My_Gray = new Image<Gray, byte>(Openfile.FileName);
                
                pictureBox1.Image = My_Image.ToBitmap();
                //matrizImage = new int[(imageGray.Height), (imageGray.Width)];
            }
        }

        private void btnReducir_Click(object sender, EventArgs e)
        {
            
            Image<Bgr, Byte> My_Image2 = new Image<Bgr, byte>((int)(My_Image.Width /2), (int)(My_Image.Height / 2));
            for (int i=0; i<My_Image.Height-1;i+=2)
            {
                for(int j = 0; j<My_Image.Width-1;j+=2)
                {
                    My_Image2[i/2, j/2] = My_Image[i,j];
                    //My_Gray[i, j] = new Gray(0);
                }
            }

            pictureBox2.Image = My_Image2.ToBitmap();

            Image<Bgr, Byte> My_Image3 = new Image<Bgr, byte>((int)(My_Image2.Width / 2), (int)(My_Image2.Height / 2));

            for (int i = 0; i < My_Image2.Height - 1; i += 2)
            {
                for (int j = 0; j < My_Image2.Width - 1; j += 2)
                {
                    My_Image3[i / 2, j / 2] = My_Image2[i, j];
                    //My_Gray[i, j] = new Gray(0);
                }
            }

            pictureBox3.Image = My_Image3.ToBitmap();

            Image<Bgr, Byte> My_Image4 = new Image<Bgr, byte>((int)(My_Image.Width * 2+1), (int)(My_Image.Height * 2+1));
            int[,] matrizImagenx2 = new int[(int)(My_Image.Height * 2 + 1), (int)(My_Image.Width * 2 + 1)]; 

            for (int i = 0; i < My_Image.Height; i++)
            {
                for (int j = 0; j < My_Image.Width; j++)
                {
                    My_Image4[i * 2, j * 2] = My_Image[i, j];
                    matrizImagenx2[i * 2, j * 2] = 1;
                }
            }
            for (int i = 0; i < My_Image4.Height; i++)
            {
                for (int j = 0; j < My_Image4.Width; j++)
                {
                    //Para superior e inferior
                    if((i==0|i==My_Image4.Height-1)&matrizImagenx2[i,j]==0)
                    {
                        My_Image4[i, j] = new Bgr(costados(i,j,My_Image4));
                    }else if((j==0|j==My_Image4.Width-1)&matrizImagenx2[i,j]==0)
                    {
                        My_Image4[i, j] = new Bgr(parados(i, j, My_Image4));
                    }
                    else if(j!=0 & i!=0 & i != My_Image4.Height - 1 & j != My_Image4.Width - 1 & matrizImagenx2[i,j]==0)
                    {
                        My_Image4[i, j] = new Bgr(promedio(i, j, My_Image4, matrizImagenx2));
                        //My_Image4[i, j] = new Bgr(0, 0, 0);
                    }
                    //Para los lados

                }
            }
            pictureBox4.Image = My_Image4.ToBitmap();

            

            Image<Bgr, Byte> My_Image5 = new Image<Bgr, byte>((int)(My_Image.Width * 2+1), (int)(My_Image.Height * 2+1));

            for (int i = 0; i < My_Image.Height ; i++)
            {
                for (int j = 0; j < My_Image.Width ; j++)
                {
                    My_Image5[i* 2, j * 2] = My_Image[i, j];
                    try
                    {
                        My_Image5[i * 2 , j * 2+1] = My_Image[i, j];
                        My_Image5[i * 2+1, j * 2 + 1] = My_Image[i, j];
                        My_Image5[i * 2 + 1, j * 2 ] = My_Image[i, j];
                    }
                    catch
                    {
                        try
                        {
                            My_Image5[i * 2, j * 2 + 1] = My_Image[i, j];
                            //My_Image5[i * 2 + 1, j * 2 + 1] = My_Image[i, j];
                            //My_Image5[i * 2 + 1, j * 2] = My_Image[i, j];

                        }catch
                        {
                            My_Image5[i * 2 + 1, j * 2] = My_Image[i, j];
                        }
                        
                    }
                }
            }
            pictureBox5.Image = My_Image5.ToBitmap();

        }
        private Color promedio(int i, int j, Image<Bgr,Byte> img, int[,] mat)
        {
            Color color;
            int R;
            int G;
            int B;
            if(mat[i-1,j-1]==1)
            {
                B = ((int)(img[i - 1, j - 1].Blue) + (int)(img[i - 1, j + 1].Blue) + (int)(img[i + 1, j - 1].Blue) + (int)(img[i + 1, j + 1].Blue))/4;
                G = ((int)(img[i - 1, j - 1].Green) + (int)(img[i - 1, j + 1].Green) + (int)(img[i + 1, j - 1].Green) + (int)(img[i + 1, j + 1].Green))/4;
                R = ((int)(img[i - 1, j - 1].Red) + (int)(img[i - 1, j + 1].Red) + (int)(img[i + 1, j - 1].Red) + (int)(img[i + 1, j + 1].Red))/4;
                //R = 255;
                //B = 255;
                //G = 255;
            }
            else 
            {
             /*  B = ((int)(img[i - 1, j].Blue) + (int)(img[i + 1, j ].Blue) + (int)(img[i, j - 1].Blue) + (int)(img[i, j + 1].Blue))/4;
                R = ((int)(img[i - 1, j].Red) + (int)(img[i + 1, j].Red) + (int)(img[i, j - 1].Red) + (int)(img[i, j + 1].Red))/4;
                G = ((int)(img[i - 1, j].Green) + (int)(img[i + 1, j].Green) + (int)(img[i, j - 1].Green) + (int)(img[i, j + 1].Green))/4;*/
               if(mat[i-1,j]==1)
                {
                    B = ((int)(img[i - 1, j].Blue) + (int)(img[i + 1, j].Blue)) / 2;
                    R = ((int)(img[i - 1, j].Red) + (int)(img[i + 1, j].Red)) / 2;
                    G = ((int)(img[i - 1, j].Green) + (int)(img[i + 1, j].Green)) / 2;
                    //R =255;
                    //B = 255;
                    //G = 255;
                }
                else
                {
                    B = ((int)(img[i, j-1].Blue) + (int)(img[i, j+1].Blue)) / 2;
                    R = ((int)(img[i, j-1].Red) + (int)(img[i , j+1].Red)) / 2;
                    G = ((int)(img[i, j-1].Green) + (int)(img[i, j+1].Green)) / 2;
                    //R = 255;
                    //B = 255;
                    //G = 255;
                }
            }


            color = Color.FromArgb(0, R, G, B);
            return color;
        }
        private Color parados(int i, int j, Image<Bgr,byte> img)
        {
            Color color;
            int R;
            int G;
            int B;

            B = ((int)(img[i-1, j].Blue) + (int)(img[i+1, j ].Blue)) / 2;
            R = ((int)(img[i-1, j].Red) + (int)(img[i+1, j ].Red)) / 2;
            G = ((int)(img[i-1, j].Green) + (int)(img[i+1, j].Green)) / 2;

            color = Color.FromArgb(0, R, G, B);
            return color;
        }

        private Color costados(int i, int j, Image<Bgr,byte> img)
        {
            Color color;
            int R;
            int G;
            int B;
            try
            {
                B = ((int)(img[i, j - 1].Blue) + (int)(img[i, j + 1].Blue)) / 2;
                R = ((int)(img[i, j - 1].Red) + (int)(img[i, j + 1].Red)) / 2;
                G = ((int)(img[i, j - 1].Green) + (int)(img[i, j + 1].Green)) / 2;
            }catch(Exception)
            {
                try
                {
                    B = ((int)(img[i, j - 1].Blue));
                    R = ((int)(img[i, j - 1].Red));
                    G = ((int)(img[i, j - 1].Green));
                }catch(Exception)
                {
                    B = ((int)(img[i, j + 1].Blue));
                    R = ((int)(img[i, j + 1].Red));
                    G = ((int)(img[i, j + 1].Green));
                }
                
            }
           
            color = Color.FromArgb(0, R, G, B);          
            return color;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(My_Image.Width.ToString() +"   "+ My_Image.Height.ToString());
            MessageBox.Show((((int)(My_Image.Width/2)).ToString())+"   "+((int)(My_Image.Height/2)).ToString());
        }
    }
}
