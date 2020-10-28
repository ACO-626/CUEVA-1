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
using System.Windows.Forms.DataVisualization.Charting;
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
        bool error=false;
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
            comboForma.SelectedIndex = 0;
            comboForma.Items.Add("Cerebro");
        }

        #region botonImportar
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
                btnR.Image = My_Image.ToBitmap();

            }

        }
        #endregion



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            //matrizImage = new int[(My_Image.Width)+1, (My_Image.Height)+1];
            switch(comboForma.SelectedIndex)
            {
                case 0:
                    blancoNegro(My_Image);
                    vaciarMatriz();
                    break;
                case 1:
                   
                    BuscarTumor(My_Image);
                    break;
            }

            
        }



        #region BlancoNegro()
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

                    btnR.Image = My_Image.ToBitmap();
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

            if(coinc & lbAnuncio.Text!= "Verificar el tipo de búsqueda")
            {
                lbAnuncio.Text = "Localizado";
                
                papel = btnR.CreateGraphics();
                
                papel.DrawRectangle(pluma,ubicacion[0,1],ubicacion[0,0],ubicacion[1,0],ubicacion[1,1]);
                 //papel.DrawRectangle(pluma, 613, 57, 10, 10);
            }
            else
            {
                MessageBox.Show("Verificar tipo de búsqueda");
                lbAnuncio.Text = "No encontrado";
            }
            


            //pictureBox1.Image = imageGray.ToBitmap();
        }

        #endregion

        #region Direcciones
        private int abajo(int i, int j)
        {
            int resultado=0;
            try
            {
                while (matrizImage[i, j] == yin & i < My_Image.Height)
                {
                    i++;
                    resultado++;
                }
            }catch(Exception)
            {
                lbAnuncio.Text = "Verificar el tipo de búsqueda";
                
            }


            return resultado;
        }
        private int izquierda(int i, int j)
        {
            int resultado = 0;
            try
            {
                while (matrizImage[i, j] == yin & j > 0)
                {
                    j--;
                    resultado++;
                }
            }catch(Exception)
            {
                lbAnuncio.Text = "Verificar el tipo de búsqueda";
            }


            return resultado;
        }
        private int derecha(int i, int j)
        {
            int resultado = 0;
            try
            {
                while (matrizImage[i, j] == yin & j < My_Image.Width)
                {
                    j++;
                    resultado++;
                }
            }catch(Exception)
            {
                lbAnuncio.Text = "Verificar el tipo de búsqueda";
            }
 

            return resultado;
        }
        #endregion

        #region comboSensibilidad
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
        #endregion

        #region VaciarMatriz
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
        #endregion

        #region CheckBoxBuscarBlancos
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                yin = 1;
                pluma.Color = Color.Green;
                pluma.Width = 5;
            }
            else
            {
                yin = 0;
                pluma.Color = Color.DarkRed;
                pluma.Width = 5;
            }
        }
        #endregion

        #region TransformarForm
        private void TransformaraFormas()
        {
            btnR.Visible = true;
            pictureBrain.Visible = false;
            pictureRadio.Visible = false;
            pictureTumor.Visible = false;
            comboSensibilidad.Visible = true;
            checkBox1.Visible = true;
            lbSensibilidad.Visible = true;
            lbCerebro.Visible = false;
            lbTumor.Visible = false;
            btnRadioGraf.Visible = false;
            btnImportar.Visible = true;
            
        }

        private void TransformaraCerebro()
        {
            btnBuscar.Text = "ANALIZAR";
            lbSensibilidad.Visible = false;
            btnR.Visible = false;
            pictureBrain.Visible = true;
            pictureRadio.Visible = true;
            pictureTumor.Visible = true;
            comboSensibilidad.Visible = false;
            checkBox1.Visible = false;
            lbCerebro.Visible = true;
            lbTumor.Visible = true;
            btnRadioGraf.Visible = true;
            btnImportar.Visible = false;
        }
        #endregion

        #region comboForma
        private void comboForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboForma.SelectedIndex)
            {
                case 0:
                    TransformaraFormas();
                    break;
                case 1:
                    TransformaraCerebro();
                    break;
            }
        }
        #endregion

        #region ImportarRadiografía
        private void btnRadioGraf_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                imageGray = new Image<Gray, byte>(Openfile.FileName);

                btnR.Image = My_Image.ToBitmap();
                matrizImage = new int[(imageGray.Height), (imageGray.Width)];
            }

            pictureRadio.Image = My_Image.ToBitmap();
        }
        #endregion

        //CEREBRO
        private void BuscarTumor(Image<Bgr,byte> imagen)
        {
            if (imagen != null)
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

                    pictureRadio.Image = My_Image.ToBitmap();
                    //matrizImage = new int[(imageGray.Height), (imageGray.Width)];
                }
            }
            for (int i = 0; i < imageGray.Height; i++)
            {
                for (int j = 0; j < imageGray.Width; j++)
                {
                    if ((int)imageGray[i, j].Intensity < 50)
                    {
                        imageGray[i, j] = new Gray((int)imageGray[i, j].Intensity-40);
                        //matrizImage[i, j] = 0;
                    }
                    else
                    {
                        imageGray[i, j] = new Gray((int)imageGray[i, j].Intensity + 10);
                        //imageGray[i, j] = new Gray(255);
                        //matrizImage[i, j] = 1;
                    }


                }
            }
            discriminarCraneo(imageGray);
            identificarCerebro(imageGray);
        }

        private void discriminarCraneo(Image<Gray,byte> imagenA)
        {
         //   bool icerebro = false;
            bool taladro = false;

            for(int i=0;i<imagenA.Height;i++)
            {
                int contador = 0;
                int contador2 = 0;
                for (int j=0;j<imagenA.Width;j++)
                {

                    
                    if (((int)imagenA[i, j].Intensity <= 1) & taladro)
                    {
                        if((int)imagenA[i,j+1].Intensity>1 | (int)imagenA[i, j + 2].Intensity > 1 )
                        {
                            taladro = true;
                            contador++;
                        }else
                        {
                            taladro = false;
                            break;
                        }
                        
                    }
                    if (((int)imagenA[i, j].Intensity > 0))
                    {
                        taladro = true;
                        imagenA[i, j] = new Gray(0);
                        try
                        {
                            if ((int)imagenA[i - 1, j].Intensity > 0)
                            {
                                contador2++;
                            }
                            if (contador2 > 1)
                            {
                                contador = 0;
                                contador2 = 0;
                                taladro = false;
                                break;
                            }
                        }catch(Exception)
                        {
                            MessageBox.Show("Imagen inválida o no completa");
                            error = true;
                            break;
                        }
                        
                        

                        if (contador>1)
                        {
                            contador = 0;
                            taladro = false;
                            break;
                        }
                    }


                }
                //icerebro = false;
                if (error)
                {
                    break;
                }
            }

            //icerebro = false;
            taladro = false;

            for (int i = 0; i < imagenA.Height; i++)
            {
                int contador = 0;
                int contador2 = 0;
                for (int j = 0; j < imagenA.Width; j++)
                {


                    if (((int)imagenA[i, imagenA.Width-j-1].Intensity <= 1) & taladro)
                    {
                        if((int)imagenA[i,imagenA.Width-j-2].Intensity >1 | (int)imagenA[i, imagenA.Width - j - 3].Intensity > 1 )
                        {
                            contador++;
                            taladro = true;
                            contador2 = 0;
                        }else
                        {
                            taladro = false;
                            break;
                        }
                        
                    }
                    if (((int)imagenA[i, imagenA.Width - j - 1].Intensity > 0))
                    {
                        taladro = true;
                        imagenA[i, imagenA.Width - j - 1] = new Gray(0);

                        try
                        {
                            if ((int)imagenA[i - 1, j].Intensity > 0)
                            {
                                contador2++;
                            }
                            if (contador2 > 1)
                            {
                                contador = 0;
                                contador2 = 0;
                                taladro = false;
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Debe cambiar la imagen");
                            error = true;
                            break;
                        }

                        if (contador>1)
                        {
                            taladro = false;
                            break;
                        }
                    }   
                }
                //icerebro = false;
                if(error)
                {
                    break;
                }
            }
            if(!error)
            {
                pictureBrain.Image = imagenA.ToBitmap();

            }else
            {
                error = false;
            }
            
            //identificarCerebro(imagenA);
            
        }
        
        private void identificarCerebro(Image<Gray,byte> imagenB)
        {
            for(int i=0;i<imagenB.Height;i++)
            {
                for(int j =0;j<imagenB.Width;j++)
                {
                    if((int)imagenB[i,j].Intensity<150)
                    {
                        imagenB[i, j] = new Gray(0);
                    }

                }
            }
            pictureTumor.Image = imagenB.ToBitmap();
        }
        

    }
}
