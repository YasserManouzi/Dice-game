using System.Media;
namespace Atelier_5
{
    public partial class Form1 : Form
    {

        string fichierSon = "sonDebutPartie.wav";

        string fichierSonMenu = "sonMenuPrincipal.wav";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            try
            {

          
            DialogResult resultat;
            if (TxtNomJoueur1.Text == "" || TxtNomJoueur2.Text == "")
            {
                MessageBox.Show("Erreur! Les nom des joueurs sont vides ou incorrectes", "Nom des joueurs invalides", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                resultat=  MessageBox.Show("Bienvenue au jeux des 5 points! Les règles du jeux sont simple : " + "\n" +"Chaque joueur aura 1 dés à faire brasser en même temps. Celui qui obtient le plus grand nombre gagne 1 points." + 
                    "Le premier joueur qui atteint 5 point remporte la partie. Bonne chance :) ", "Règles du jeu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information );

                if(resultat == DialogResult.OK)
                {

                    SoundPlayer sonDebutPartie = new SoundPlayer();
                    sonDebutPartie.SoundLocation = Application.StartupPath + "\\" + fichierSon;
                    sonDebutPartie.Play();

                Form2 interfaceJeu = new Form2(this);

                    interfaceJeu.Afficher(TxtNomJoueur1, TxtNomJoueur2);

            interfaceJeu.ShowDialog();

                }
            }
            }catch(FileNotFoundException)
            {

            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vraiment quittez le jeu ?", "Quitter", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(resultat == DialogResult.OK)
            {
                Application.Exit();
            }


            
        }

        private void TxtNomJoueur1_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char toucheClavier = e.KeyChar;

            if (Char.IsLetter(toucheClavier) || Char.IsControl(toucheClavier)
                || Char.IsSeparator(toucheClavier) || Char.IsWhiteSpace(toucheClavier) || toucheClavier == '-' ||  toucheClavier == '_' || Char.IsNumber(toucheClavier))

            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtNomJoueur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char toucheClavier = e.KeyChar;

            if (Char.IsLetter(toucheClavier) || Char.IsControl(toucheClavier)
                || Char.IsSeparator(toucheClavier) || Char.IsWhiteSpace(toucheClavier) || toucheClavier == '-' || toucheClavier == '_' || Char.IsNumber(toucheClavier))

            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SoundPlayer sonmMenu = new SoundPlayer();
            sonmMenu.SoundLocation = Application.StartupPath + "\\" + fichierSonMenu;
            sonmMenu.Play();

        }

        
    }
}