using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Cueva_1
{
    public partial class FormCelula : Form
    {
        private int longitud = 400;
        private int longitudPixel = 1;
        int[,] celulas;
        Bitmap img;
        bool audio;
        SoundPlayer player = new SoundPlayer();

        public FormCelula()
        {
            InitializeComponent();

            //Inicializamos 
            celulas = new int[longitud, longitud];
           
            try
            {
                player.SoundLocation = @"..\..\sound\indoCelula.wav";
                player.Play();
                audio = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan Archivos de sonido, error: 1001");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<10;i++)
            {
                comboTamaño.Items.Add(i + 1 + " px");
            }
        }

        private void PintarMatriz()
        {
            Bitmap bmp = new Bitmap(isla.Width, isla.Height);
            for(int x=0; x<longitud;x++)
            {
                for(int y=0;y<longitud;y++)
                {
                    if(celulas[x,y]==0)
                    {
                        PintarPixel(bmp, x, y, Color.FromArgb(15,15,18));
                    }
                    else
                    {
                        PintarPixel(bmp, x, y, Color.White);
                    }
                }
            }
         

        }

        private void PintarPixel(Bitmap bmp, int x, int y, Color color)
        {
            for(int i=0;i<longitudPixel;i++)
            {
                for(int j=0;j<longitudPixel; j++)
                {
                    bmp.SetPixel(i + (x*longitudPixel), j + (y * longitudPixel),color);
                }
            }

            isla.Image = bmp;
        }

        private void JuegodeLaVida()
        {
            int[,] celulasTemporal = new int[longitud, longitud];
            for(int x=0;x<longitud;x++)
            {
                for (int y = 0; y < longitud; y++)
                {
                    if (celulas[x,y]==0)
                    {
                        celulasTemporal[x, y] = ReglaJuegoVida(x,y,false);
                    }
                    else
                    {
                        celulasTemporal[x, y] = ReglaJuegoVida(x, y, true);
                    }
                }
            }
            celulas = celulasTemporal;
        }

        private int ReglaJuegoVida(int x, int y, bool Vive)
        {
            int VecinasVivas = 0;
            if (x > 0&&y>0)
                if (celulas[x - 1, y - 1] == 1)
                    VecinasVivas++;

            //Celula de arriba
            if (y > 0)
                if (celulas[x, y - 1] == 1)
                    VecinasVivas++;

            //Celula derecha arriba
            if (x < longitud - 1&&y>0)
                if (celulas[x + 1, y - 1] == 1)
                    VecinasVivas++;
            //Celula de la izq
            if (x > 0)
                if (celulas[x - 1, y] == 1)
                    VecinasVivas++;
            //Celula derecha
            if (x < longitud - 1)
                if (celulas[x + 1, y] == 1)
                    VecinasVivas++;
            //Celula inf izq
            if (x > 0 && y < longitud - 1)
                if (celulas[x - 1, y + 1] == 1)
                    VecinasVivas++;

            //Celula inferior
            if (y < longitud - 1)
                if (celulas[x, y + 1] == 1)
                    VecinasVivas++;
            //Cel inf derecha
            if (x < longitud - 1&&y<longitud-1)
                if (celulas[x + 1, y+1] == 1)
                    VecinasVivas++;

            if (Vive)
                return (VecinasVivas == 2 || VecinasVivas == 3) ? 1 : 0;
            else
                return VecinasVivas == 3 ? 1 : 0;
        
                
        }
        

        private void btnRandom_Click(object sender, EventArgs e)
        {
            celulas = new int[longitud, longitud];
            btnCreacion.Enabled = true;
            for(int i=0; i< longitud;i++)
            {
                for(int j=0;j<longitud;j++)
                {
                    celulas[i, j] = 0;
                }
            }

            Random r = new Random();
            for(int i =0;i<longitud;i++)
            {
                for(int j =0; j<longitud;j++)
                {
                    celulas[i, j] = r.Next(0, 2);
                }
            }

            PintarMatriz();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            JuegodeLaVida();
            PintarMatriz();
        }

        private void comboTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            extincion();           
            timer1.Enabled = false;
            longitudPixel = comboTamaño.SelectedIndex+1;
            longitud = 400/longitudPixel;
            
        }

        private void extincion()
        {
            Bitmap bmp = new Bitmap(isla.Width, isla.Height);
            for (int x = 0; x < longitud; x++)
            {
                for (int y = 0; y < longitud; y++)
                {
                    PintarPixel(bmp, x, y, Color.FromArgb(15,15,18));
                }
            }

            btnCreacion.Enabled = false;
        }

        private void btnExtincion_Click(object sender, EventArgs e)
        {
            btnCreacion.Enabled = false;
            timer1.Enabled = false;
            extincion();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            if(audio==true)
            {
                player.Stop();
                img = new Bitmap(Application.StartupPath + @"/../../img/au_off.png");
                btnAudio.Image = img;
                audio = false;
            }
            else
            {
                player.Play();
                img = new Bitmap(Application.StartupPath + @"/../../img/au_on.png");
                btnAudio.Image = img;
                audio = true;
            }
           
        }

        private void btnVolcan_Click(object sender, EventArgs e)
        {
            audio = false;
            player.Stop();
            this.Close();
        }
    }
}
