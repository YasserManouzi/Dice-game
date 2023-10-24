using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Media;
using Application = System.Windows.Forms.Application;

namespace Atelier_5
{
    public partial class Form2 : Form
    {
        string fichierImageCourrone = "imageVictoireCourronne.png";

        string fichierSon = "sonVictoire.wav";

       string fichierSonMenu = "sonMenuPrincipal.wav";

        Thread joueur1, joueur2;
        Random aleatoire = new Random();

        string numeroDe, numeroDe2;

        int nombreVictoireJoueur1;
        int nombreVictoireJoueur2;

        TextBox nombreVictoire1;
        TextBox nombreVictoire2;


        int nombrePointsJoueur1;
        int nombrePointsJoueur2;
        string[] donneImage = new string[6] { @"1.png",
        @"2.png",
        @"3.png",
        @"4.png",
        @"5.png",
        @"6.png",};

        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            nombreVictoire1 = form1.TxtVictoire1;
            nombreVictoire2 = form1.TxtVictoire2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BtnRecommencer.Enabled = false;
          
        }
        public void Afficher(TextBox textBox1, TextBox textBox2)
        {
            LblNomJoueur1.Text = textBox1.Text;
            LblNomJoueur2.Text = textBox2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnRecommencer.Enabled = false;
            joueur2 = new Thread(t =>
            {
                try
                {
              
                    while (joueur2.IsAlive)
                    {
                        for (int i = 0; i < 6; i++)
                        {


                            pictureBoxImage2.ImageLocation = donneImage[i];

                            

                            numeroDe2 = donneImage[i].Remove(1, 4);

                            
                            Thread.Sleep(2);


                           
                        }


                    }


              }
                 catch (ThreadInterruptedException) { }
              


            })
            { IsBackground = true };

            joueur2.Start();

            BtnRetourMenuPrincipal.Enabled = false;
            Debug.WriteLine("Le joueur 1 viens de brasser son dé");
            TxtPointJoueur2.Text = "Brassage de " + LblNomJoueur2.Text;

            BtnBrasser2.Enabled = false;


        }
   
        private void BtnStop_Click(object sender, EventArgs e)
        {

            BtnRetourMenuPrincipal.Enabled = true;
            BtnBrasser1.Enabled = true;
            BtnBrasser2.Enabled = true;

            if (joueur1 != null && joueur2 != null && joueur1.IsAlive && joueur2.IsAlive && int.Parse(numeroDe) > int.Parse(numeroDe2))
            {
                
                joueur1.Interrupt();
                joueur2.Interrupt();
                TxtPointJoueur1.Text = numeroDe.ToString();
                TxtPointJoueur2.Text = numeroDe2.ToString();
              
               

               
                nombrePointsJoueur1++;
                TxtPoint1.Text = nombrePointsJoueur1.ToString();
             



            }
            else if(joueur1 != null && joueur2 != null && joueur1.IsAlive && joueur2.IsAlive && int.Parse(numeroDe) < int.Parse(numeroDe2))
            {
                joueur1.Interrupt();
                joueur2.Interrupt();
                TxtPointJoueur1.Text = numeroDe.ToString();
                TxtPointJoueur2.Text = numeroDe2.ToString();

               
                    nombrePointsJoueur2++;
                    TxtPoints2.Text = nombrePointsJoueur2.ToString();


            }
            else if(joueur1 != null && joueur2 != null && joueur1.IsAlive && joueur2.IsAlive && int.Parse(numeroDe) == int.Parse(numeroDe2))
            {
                joueur1.Interrupt();
                joueur2.Interrupt();
                TxtPointJoueur1.Text = numeroDe.ToString();
                TxtPointJoueur2.Text = numeroDe2.ToString();
                MessageBox.Show("Égalité !");
            }
            if (nombrePointsJoueur1 == 5)
            {
                

                    SoundPlayer sonVictoire = new SoundPlayer();
                    sonVictoire.SoundLocation = Application.StartupPath + "\\" + fichierSon;
                    sonVictoire.Play();

                    MessageBox.Show("Bravo ! " + LblNomJoueur1.Text + " remporte la partie ");
                    MessageBox.Show("La partie est terminée. Si vous voulez recommencez le jeu, cliquer sur le boutton " + '\u0022' + " Recommencer la partie !" + '\u0022');


                    pictureBoxCouronne.ImageLocation = Application.StartupPath + "\\" + fichierImageCourrone;

                    BtnRecommencer.Enabled = true;
                    BtnBrasser1.Enabled = false;
                    BtnBrasser2.Enabled = false;
                    BtnStop.Enabled = false;

                    nombreVictoireJoueur1++;

                    nombreVictoire1.Text = nombreVictoireJoueur1.ToString();
              
            }
            else if (nombrePointsJoueur2 == 5)
            {
               
                 SoundPlayer sonVictoire = new SoundPlayer();
                sonVictoire.SoundLocation = Application.StartupPath + "\\" + fichierSon;
                sonVictoire.Play();

                MessageBox.Show("Bravo ! " + LblNomJoueur2.Text + " remporte la partie ");
                MessageBox.Show("La partie est terminée. Si vous voulez recommencez le jeu, cliquer sur le boutton " + '\u0022' + " Recommencer la partie !" + '\u0022');

               

                pictureBoxCourronneVictoire2.ImageLocation = Application.StartupPath + "\\" + fichierImageCourrone;

                BtnRecommencer.Enabled = true;
                BtnBrasser1.Enabled = false;
                BtnBrasser2.Enabled = false;
                BtnStop.Enabled = false;

                nombreVictoireJoueur2++;

                nombreVictoire2.Text = nombreVictoireJoueur2.ToString();

                }
              
            


        }

        private void BtnRetourMenuPrincipal_Click(object sender, EventArgs e)
        {
            
           DialogResult resultat = MessageBox.Show(" Voulez-vous revenir au menu principal ?", "Revenir menu principal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(resultat == DialogResult.OK)
            {

                this.Close();

                form1.TxtNomJoueur1.Text = "";
                form1.TxtNomJoueur2.Text = "";

                nombreVictoireJoueur1 = 0;
                nombreVictoireJoueur2 = 0;

                nombreVictoire1.Text = nombreVictoireJoueur1.ToString();
                nombreVictoire2.Text = nombreVictoireJoueur2.ToString();

                SoundPlayer sonmMenu = new SoundPlayer();
                sonmMenu.SoundLocation = Application.StartupPath + "\\" + fichierSonMenu;
                sonmMenu.Play();

            }

        }

        private void BtnRecommencer_Click(object sender, EventArgs e)
        {
            TxtPointJoueur1.Text = "";
            TxtPointJoueur2.Text = "";
            nombrePointsJoueur1 = 0;

            TxtPoint1.Text = nombrePointsJoueur1.ToString();

            nombrePointsJoueur2 = 0;

            TxtPoints2.Text = nombrePointsJoueur2.ToString();

            BtnBrasser1.Enabled = true;
            BtnBrasser2.Enabled = true;
            BtnStop.Enabled = true;

            pictureBoxCouronne.ImageLocation = "";

            pictureBoxCourronneVictoire2.ImageLocation = "";
        }

       

        private void BtnBrasser1_Click(object sender, EventArgs e)
        {

            BtnRecommencer.Enabled = false;

            joueur1 = new Thread(t =>
           {
                
               try
               {
                
                   while (joueur1.IsAlive)
                   {
                      for(int i = 0; i < 6; i++)
                       {
                       
                           
                           pictureBoxImage1.ImageLocation = donneImage[i];

                           numeroDe = donneImage[i].Remove(1,4);

                           Thread.Sleep(2);

                          
                       }
                     

                   }
                 

               }
               catch (ThreadInterruptedException ) { }

              

           })
            { IsBackground = true };

            joueur1.Start();

            BtnRetourMenuPrincipal.Enabled = false;
            Debug.WriteLine("Le joueur 1 viens de brasser son dé");
            TxtPointJoueur1.Text = "Brassage de "+ LblNomJoueur1.Text;

            BtnBrasser1.Enabled = false;

    }


    }

}
