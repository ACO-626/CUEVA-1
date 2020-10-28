using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Cueva_1
{
    public partial class FormPrincipal : Form
    {


        #region Inicio

        Bitmap img;
        SoundPlayer player = new SoundPlayer();
        public FormPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();

            try
            {
                player.SoundLocation = @"..\..\sound\main.wav";
                player.Play();               
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan Archivos de sonido, error: 1001");
            }

        }

        private void personalizarDiseño()
        {
            panelDibujo.Visible = false;
            panelTrans.Visible = false;
            panelIA.Visible = false;
            panelAmb.Visible = false;
            
        }


        #endregion

        #region Comportamiento Submenú

        //Mostrar
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
                img = new Bitmap(Application.StartupPath + @"/../../img/mostrar.png");
                btnShow.Image = img;

            }
            else
            {
                panelMenu.Visible = true;
                img = new Bitmap(Application.StartupPath + @"/../../img/esconder.png");
                btnShow.Image = img;
            }

        }

        //Comportamiento de submenu
        private void ocultaSubMenus()
        {
            if (panelDibujo.Visible==true)
                panelDibujo.Visible=false;
            if (panelTrans.Visible == true)
                panelTrans.Visible = false;
            if (panelIA.Visible == true)
                panelIA.Visible = false;
            if (panelAmb.Visible == true)
                panelAmb.Visible = false;
        }

        //Submenú
        private void muestraSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultaSubMenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnAmbiente_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelAmb);
        }
        #endregion

        #region Dibujo
        //Muestra submenu dibujo
        private void btnDibujo_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelDibujo);
        }
        #endregion

        #region Transformar

        //Muestra submenu transformar
        private void btnTransformar_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelTrans);
        }

        #endregion

        #region IA
        //Muestra submenu IA
        private void btnIA_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelIA);
        }
        #endregion

        #region Ambiente
        private void btnPixelPark_Click(object sender, EventArgs e)
        {
            img = new Bitmap(Application.StartupPath + @"/../../img/celulaPark.png");
            pictureLogo.Image = img;
            
            crearHijo(new Cueva_1.FormCelula());

        }




        #endregion

        #region Hijos

        private Form activeForm = null;
        private void crearHijo(Form FormHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(FormHijo);
            panelHijo.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }



        #endregion

        private void btnSegmenta_Click(object sender, EventArgs e)
        {
            crearHijo(new Cueva_1.FormSegmentacion());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crearHijo(new Cueva_1.btnTransformar());
        }
    }
}
