using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_practico_integrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        Int32 jugador = 0;
        Int32 oponente = 0;
        int puntajefinal = 0;
        Int32 aciertos = 0;
        Int32 fallas = 0;
       



        private void imgoso_Click(object sender, EventArgs e)
        {


        }

        private void cmdjugar_Click(object sender, EventArgs e)
        {
            int n = r.Next(1, 10);
            int n2 = r.Next(1, 10);

         

            Numero1(n);
            Numero1(n);
            Numero2(n);


            DesbloquearBotones();
         



        }

        private void cmdmayor_Click(object sender, EventArgs e)
        {
            if (jugador > oponente)

                JugadorGana();
            else
            {
                OponenteGana();
            }

            ResetearValores();



            ControlarSiUnJugadorGano();
            BloquearBotones();
            cmdjugar.Enabled = true;

        }

        private void cmdigual_Click(object sender, EventArgs e)
        {
            if (jugador == oponente)
            {
                JugadorGana();
            }
            else
            {
                OponenteGana();
            }
            ResetearValores();



            ControlarSiUnJugadorGano();
            BloquearBotones();
            cmdjugar.Enabled = true;


        }

        private void cmdmenor_Click(object sender, EventArgs e)
        {
            if (jugador < oponente)
            {
                JugadorGana();
            }
            else
            {
                OponenteGana();
            }
            ResetearValores();



            ControlarSiUnJugadorGano();
            BloquearBotones();
            cmdjugar.Enabled = true;

        }

        private void cmdvolver_Click(object sender, EventArgs e)

        {
            BloquearBotones();
            
          
            fallas = 0;
            aciertos = 0;
            puntajefinal = 0;
            lblaciertos.Text = Convert.ToString(aciertos);
            lblfallas.Text = Convert.ToString(fallas);
            lblpuntajefinal.Text = Convert.ToString(puntajefinal);
            imgoso.Image = trabajo_practico_integrado.Properties.Resources.Coco;
            imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._0;
            imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._0;

            cmdjugar.Visible = true;
            cmdvolver.Visible = false;

            ResetearValores();



        }
        private void Numero1(int n)
        {
            
            switch (n)
            {
                case 1:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._0;

                    break;
                case 2:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._1;
                    jugador = jugador + 1;
                    break;
                case 3:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._2;
                    jugador = jugador + 2;
                    break;
                case 4:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._3;
                    jugador = jugador + 3;
                    break;
                case 5:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._4;
                    jugador = jugador + 4;
                    break;
                case 6:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._5;
                    jugador = jugador + 5;
                    break;
                case 7:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._6;
                    jugador = jugador + 6;
                    break;
                case 8:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._7;
                    jugador = jugador + 7;
                    break;
                case 9:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._8;
                    jugador = jugador + 8;
                    break;
                case 10:
                    imgnumero1.Image = trabajo_practico_integrado.Properties.Resources._9;
                    jugador = jugador + 9;
                    break;
            }





        }
        private void Numero2(int n)
        {
            int n2 = r.Next(1, 10);
            switch (n2)
            {
                case 1:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._0;

                    break;
                case 2:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._1;
                    oponente = oponente + 1;
                    break;
                case 3:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._2;
                    oponente = oponente + 2;
                    break;
                case 4:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._3;
                    oponente = oponente + 3;
                    break;
                case 5:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._4;
                    oponente = oponente + 4;
                    break;
                case 6:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._5;
                    oponente = oponente + 5;
                    break;
                case 7:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._6;
                    oponente = oponente + 6;
                    break;
                case 8:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._7;
                    oponente = oponente + 7;
                    break;
                case 9:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._8;
                    oponente = oponente + 8;
                    break;
                case 10:
                    imgnumero2.Image = trabajo_practico_integrado.Properties.Resources._9;
                    oponente = oponente + 9;
                    break;
            }



        }
        
        
       

        void JugadorGana()
        {
            
            puntajefinal = puntajefinal + 2;
            aciertos = aciertos + 1;
            lblaciertos.Text = Convert.ToString(aciertos);
            lblpuntajefinal.Text = Convert.ToString(puntajefinal);
            imgelegida.Image = trabajo_practico_integrado.Properties.Resources.Bien;


        }
        void OponenteGana()
        {
                 puntajefinal= puntajefinal - 1;
                imgelegida.Image = trabajo_practico_integrado.Properties.Resources.Mal;
            fallas = fallas + 1;
            lblfallas.Text = Convert.ToString(fallas);
            lblpuntajefinal.Text = Convert.ToString(puntajefinal);

        }
        void ControlarSiUnJugadorGano()
        {
            if (puntajefinal >= 10)
            {
                cmdjugar.Visible = false;
                cmdvolver.Visible = true;
                imgoso.Image = trabajo_practico_integrado.Properties.Resources.CocoFeliz;

                BloquearBotones();

            }

            if (puntajefinal <= -1)
            {
                cmdjugar.Visible = false;
                cmdvolver.Visible = true;
                imgoso.Image = trabajo_practico_integrado.Properties.Resources.CocoTriste;

                BloquearBotones();

            }
        }


        void DesbloquearBotones()
        {
            cmdmayor.Enabled = true;
            cmdigual.Enabled = true;
            cmdmenor.Enabled = true;
            cmdjugar.Enabled = true;
        
            


        }
        void BloquearBotones()
        {
            cmdmayor.Enabled = false;
            cmdigual.Enabled = false;
            cmdmenor.Enabled = false;

        }

        void ResetearValores()
        {
            jugador = 0;
            oponente = 0;
           
        }




    }
    

    
   
}

