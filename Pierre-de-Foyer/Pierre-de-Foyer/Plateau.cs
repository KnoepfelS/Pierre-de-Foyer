﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierre_de_Foyer
{
    public partial class Plateau : Form
    {
        public Plateau()
        {
            InitializeComponent();
        }

        //Initialisation
        Classes.Hero hero = new Classes.Hero();
        Classes.Hero heroAdverse = new Classes.Hero();
        Carte[] MainHero = new Carte[12];
        Carte[] MainHeroAdverce = new Carte[12];
        bool bTour = true;

        private void Plateau_Load(object sender, EventArgs e)
        {
            //Image des objet (Temporaire)
            pbxHero.BackColor = Color.Green;
            pbxHeroAdverse.BackColor = Color.Red;
            pbxPouvoirHero.BackColor = Color.Yellow;
            pbxPouvoirHeroAdverse.BackColor = Color.Yellow;
            pbxDeck.BackColor = Color.Blue;
            pbxDeckAdverse.BackColor = Color.Blue;

            //Placement des objets
            pbxHero.Location = new Point(this.Width / 2 - pbxHero.Width / 2, this.Height - pbxHeroAdverse.Height);
            pbxHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2, 0);
            pbxPouvoirHero.Location = new Point(this.Width / 2 + pbxHero.Width / 2, this.Height - pbxPouvoirHero.Height);
            pbxPouvoirHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2 - pbxPouvoirHeroAdverse.Width, 0);
            btnPasser.Location = new Point(this.Width - btnPasser.Width, this.Height / 2 - btnPasser.Height / 2);
            btnRetour.Location = new Point(this.Width - btnRetour.Width, 0);

            //Affichage de la main (Temporaire)
            pbxDeck.Location = new Point(this.Width / 4 * 3, 0);
            pbxDeck.Top = this.Height - pbxDeck.Height;
            pbxDeckAdverse.Location = new Point(this.Width / 4, 0);
        }

        private void Plateau_Paint(object sender, PaintEventArgs e)
        {
            //Dessine le trait de séparation du plateau
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, 0, this.Height / 2, this.Width, this.Height / 2);
        }

        // Appelle cette fonction lorsque le joueur utilise sont pouvoir heroique
        private void pbxPouvoirHero_Click(object sender, EventArgs e)
        {
            //hero.getPouvoirHeroique();
        }

        // Appelle cette fonction lorsque le joueur adverse utilise sont pouvoir heroique
        private void pbxPouvoirHeroAdverse_Click(object sender, EventArgs e)
        {
            //heroAdverse.getPouvoirHeroique();
        }

        // Appelle cette fonction lorsque le joueur passe sont tour
        private void btnPasser_Click(object sender, EventArgs e)
        {
            //hero.PiocherCartes();
            //heroAdverse.PiocherCartes();
        }

        // Quitte le plateau de jeu
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void pbxDeckAdverse_Click(object sender, EventArgs e)
        {
            if(bTour == false)
            {
                AfficheCarte(MainHeroAdverce);
            }
        }

        private void pbxDeck_Click(object sender, EventArgs e)
        {
            if(bTour == true)
            {
                AfficheCarte(MainHero);
            }
        }

        private void AfficheCarte(Carte[] main)
        {
            foreach(Carte carte in main)
            {
                int iCompteur = 0;
                PictureBox pbxCarte = new PictureBox();
                pbxCarte.Location = new Point(10 * 100 * iCompteur);
                pbxCarte.Name = carte.getNom();
                pbxCarte.Size = new Size(150, 100);
                Controls.Add(pbxCarte);
            }
        }
    }
}
