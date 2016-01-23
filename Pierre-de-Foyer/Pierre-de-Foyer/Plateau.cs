﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pierre_de_Foyer.Classes;

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
        List<Carte> MainHero = new List<Carte>();
        List<Carte> MainHeroAdverce = new List<Carte>();
        bool bTour = true, bDejaUtilise = false;

        List<Carte> DeckHero = new List<Carte>();

        Serviteur ServiteurTest = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest2 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest3 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest4 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest5 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest6 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest7 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest8 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest9 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest10 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest11 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest12 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest13 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest14 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest15 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest16 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest17 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest18 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest19 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest20 = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);
        Serviteur ServiteurTest21 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest22 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest23 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest24 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest25 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest26 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest27 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest28 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest29 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);
        Serviteur ServiteurTest30 = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);

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

            /*Création d'une carte test
            Serviteur ServiteurTest = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest2 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest3 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest4 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest5 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest6 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest7 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest8 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest9 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest10 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest11 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest12 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            */

            DeckHero.Add(ServiteurTest);
            DeckHero.Add(ServiteurTest2);
            DeckHero.Add(ServiteurTest3);
            DeckHero.Add(ServiteurTest2);
            DeckHero.Add(ServiteurTest3);
            DeckHero.Add(ServiteurTest4);
            DeckHero.Add(ServiteurTest5);
            DeckHero.Add(ServiteurTest6);
            DeckHero.Add(ServiteurTest7);
            DeckHero.Add(ServiteurTest8);
            DeckHero.Add(ServiteurTest9);
            DeckHero.Add(ServiteurTest10);
            DeckHero.Add(ServiteurTest11);
            DeckHero.Add(ServiteurTest12);
            DeckHero.Add(ServiteurTest13);
            DeckHero.Add(ServiteurTest14);
            DeckHero.Add(ServiteurTest15);
            DeckHero.Add(ServiteurTest16);
            DeckHero.Add(ServiteurTest17);
            DeckHero.Add(ServiteurTest18);
            DeckHero.Add(ServiteurTest19);
            DeckHero.Add(ServiteurTest20);
            DeckHero.Add(ServiteurTest21);
            DeckHero.Add(ServiteurTest22);
            DeckHero.Add(ServiteurTest23);
            DeckHero.Add(ServiteurTest24);
            DeckHero.Add(ServiteurTest25);
            DeckHero.Add(ServiteurTest26);
            DeckHero.Add(ServiteurTest27);
            DeckHero.Add(ServiteurTest28);
            DeckHero.Add(ServiteurTest29);
            DeckHero.Add(ServiteurTest30);

            for (int i = 0; i < 4; i++)
            {
                MainHero.Add(hero.PiocherCartes(DeckHero));
                PictureBox pbxCarte = new PictureBox();
                pbxCarte.Size = new Size(200, 250);
                pbxCarte.Location = new Point(this.Width / 2 + (5 + pbxCarte.Width) * i, (this.Height / 3) * 2 - pbxCarte.Height / 2);
                pbxCarte.Name = hero.PiocherCartes(DeckHero).strNom;
                pbxCarte.BackColor = Color.White;
                pbxCarte.Image = hero.PiocherCartes(DeckHero)._imageCarte;
                Controls.Add(pbxCarte);
            }

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
            if (bTour == true && bDejaUtilise == false)
            {
                bDejaUtilise = true;
            }
        }

        // Appelle cette fonction lorsque le joueur adverse utilise sont pouvoir heroique
        private void pbxPouvoirHeroAdverse_Click(object sender, EventArgs e)
        {
            if(bTour == false && bDejaUtilise == false)
            {
                bDejaUtilise = true;
            }
        }

        // Appelle cette fonction lorsque le joueur passe sont tour
        private void btnPasser_Click(object sender, EventArgs e)
        {
            if(bTour == true)
            {
                heroAdverse.PiocherCartes(DeckHero);
                bTour = false;
            }
            else
            {
                hero.PiocherCartes(DeckHero);
                bTour = true;
            }
            bDejaUtilise = false;
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

        private void AfficheCarte(List<Carte> main)
        {
            int iCompteur = 0;
            foreach (Carte carte in main)
            {
                PictureBox pbxCarte = new PictureBox();
                pbxCarte.Size = new Size(200, 250);
                pbxCarte.Location = new Point((5 + pbxCarte.Width) * iCompteur, (this.Height  / 3) * 2 - pbxCarte.Height / 2);
                pbxCarte.Name = carte.strNom;
                pbxCarte.BackColor = Color.White;
                pbxCarte.Image = carte._imageCarte;
                Controls.Add(pbxCarte);
                iCompteur++;
            }
        }
    }
}
