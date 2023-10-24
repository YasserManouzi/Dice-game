namespace Atelier_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImageAccueil = new System.Windows.Forms.PictureBox();
            this.LblNomJeux = new System.Windows.Forms.Label();
            this.TxtNomJoueur1 = new System.Windows.Forms.TextBox();
            this.LblNomJoueur1 = new System.Windows.Forms.Label();
            this.LblNomJoueur2 = new System.Windows.Forms.Label();
            this.TxtNomJoueur2 = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.TxtVictoire1 = new System.Windows.Forms.TextBox();
            this.TxtVictoire2 = new System.Windows.Forms.TextBox();
            this.LblVictoire1 = new System.Windows.Forms.Label();
            this.LblVictoire2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageAccueil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImageAccueil
            // 
            this.pictureBoxImageAccueil.Image = global::Atelier_5.Properties.Resources.imageJeux;
            this.pictureBoxImageAccueil.Location = new System.Drawing.Point(240, 84);
            this.pictureBoxImageAccueil.Name = "pictureBoxImageAccueil";
            this.pictureBoxImageAccueil.Size = new System.Drawing.Size(301, 166);
            this.pictureBoxImageAccueil.TabIndex = 0;
            this.pictureBoxImageAccueil.TabStop = false;
            // 
            // LblNomJeux
            // 
            this.LblNomJeux.AutoSize = true;
            this.LblNomJeux.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNomJeux.Location = new System.Drawing.Point(291, 28);
            this.LblNomJeux.Name = "LblNomJeux";
            this.LblNomJeux.Size = new System.Drawing.Size(207, 30);
            this.LblNomJeux.TabIndex = 1;
            this.LblNomJeux.Text = "Jeu des 5 points";
            // 
            // TxtNomJoueur1
            // 
            this.TxtNomJoueur1.Location = new System.Drawing.Point(12, 344);
            this.TxtNomJoueur1.Name = "TxtNomJoueur1";
            this.TxtNomJoueur1.Size = new System.Drawing.Size(294, 23);
            this.TxtNomJoueur1.TabIndex = 2;
            this.TxtNomJoueur1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomJoueur1_KeyPress);
            // 
            // LblNomJoueur1
            // 
            this.LblNomJoueur1.AutoSize = true;
            this.LblNomJoueur1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNomJoueur1.Location = new System.Drawing.Point(83, 304);
            this.LblNomJoueur1.Name = "LblNomJoueur1";
            this.LblNomJoueur1.Size = new System.Drawing.Size(147, 20);
            this.LblNomJoueur1.TabIndex = 3;
            this.LblNomJoueur1.Text = "Nom du joueur 1";
            // 
            // LblNomJoueur2
            // 
            this.LblNomJoueur2.AutoSize = true;
            this.LblNomJoueur2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNomJoueur2.Location = new System.Drawing.Point(596, 304);
            this.LblNomJoueur2.Name = "LblNomJoueur2";
            this.LblNomJoueur2.Size = new System.Drawing.Size(139, 18);
            this.LblNomJoueur2.TabIndex = 4;
            this.LblNomJoueur2.Text = "Nom du joueur 2";
            // 
            // TxtNomJoueur2
            // 
            this.TxtNomJoueur2.Location = new System.Drawing.Point(494, 344);
            this.TxtNomJoueur2.Name = "TxtNomJoueur2";
            this.TxtNomJoueur2.Size = new System.Drawing.Size(294, 23);
            this.TxtNomJoueur2.TabIndex = 5;
            this.TxtNomJoueur2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomJoueur2_KeyPress);
            // 
            // BtnGo
            // 
            this.BtnGo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGo.Location = new System.Drawing.Point(330, 328);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(142, 52);
            this.BtnGo.TabIndex = 6;
            this.BtnGo.Text = "Commencer le jeu";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnQuitter.Location = new System.Drawing.Point(330, 395);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(142, 43);
            this.BtnQuitter.TabIndex = 7;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // TxtVictoire1
            // 
            this.TxtVictoire1.Location = new System.Drawing.Point(3, 407);
            this.TxtVictoire1.Name = "TxtVictoire1";
            this.TxtVictoire1.ReadOnly = true;
            this.TxtVictoire1.Size = new System.Drawing.Size(289, 23);
            this.TxtVictoire1.TabIndex = 8;
            this.TxtVictoire1.Text = "0";
            // 
            // TxtVictoire2
            // 
            this.TxtVictoire2.Location = new System.Drawing.Point(494, 407);
            this.TxtVictoire2.Name = "TxtVictoire2";
            this.TxtVictoire2.ReadOnly = true;
            this.TxtVictoire2.Size = new System.Drawing.Size(294, 23);
            this.TxtVictoire2.TabIndex = 9;
            this.TxtVictoire2.Text = "0";
            // 
            // LblVictoire1
            // 
            this.LblVictoire1.AutoSize = true;
            this.LblVictoire1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVictoire1.Location = new System.Drawing.Point(108, 384);
            this.LblVictoire1.Name = "LblVictoire1";
            this.LblVictoire1.Size = new System.Drawing.Size(96, 20);
            this.LblVictoire1.TabIndex = 10;
            this.LblVictoire1.Text = "Victoire #";
            // 
            // LblVictoire2
            // 
            this.LblVictoire2.AutoSize = true;
            this.LblVictoire2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVictoire2.Location = new System.Drawing.Point(609, 384);
            this.LblVictoire2.Name = "LblVictoire2";
            this.LblVictoire2.Size = new System.Drawing.Size(96, 20);
            this.LblVictoire2.TabIndex = 11;
            this.LblVictoire2.Text = "Victoire #";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblVictoire2);
            this.Controls.Add(this.LblVictoire1);
            this.Controls.Add(this.TxtVictoire2);
            this.Controls.Add(this.TxtVictoire1);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.TxtNomJoueur2);
            this.Controls.Add(this.LblNomJoueur2);
            this.Controls.Add(this.LblNomJoueur1);
            this.Controls.Add(this.TxtNomJoueur1);
            this.Controls.Add(this.LblNomJeux);
            this.Controls.Add(this.pictureBoxImageAccueil);
            this.Name = "Form1";
            this.Text = "Accueil - Jeux des 5 points";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageAccueil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxImageAccueil;
        private Label LblNomJeux;
        public TextBox TxtNomJoueur1;
        private Label LblNomJoueur1;
        private Label LblNomJoueur2;
        public TextBox TxtNomJoueur2;
        private Button BtnGo;
        private Button BtnQuitter;
        public TextBox TxtVictoire1;
        public TextBox TxtVictoire2;
        private Label LblVictoire1;
        private Label LblVictoire2;
    }
}