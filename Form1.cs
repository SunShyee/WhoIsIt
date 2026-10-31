using System.Collections.Generic;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WhoIsIt
{
    public partial class WhoIsIt : Form
    {
        public string nomPerso;
        public bool cheveuxPerso;
        public string hairColorPerso;
        public string eyeColorPerso;
        public bool lunettePerso;
        public bool chapeauPerso;
        public bool barbePerso;
        public bool moustachePerso;
        public string sexePerso;
        public WhoIsIt()
        {
            InitializeComponent();
        }
        public void LancementPartie()
        {
            flpPerso.Controls.Clear();
            List<Personnage> lesPersonnages = new List<Personnage>();
            //     Création des personnages     //
            Personnage Carmen = new Personnage(1, "Carmen", true, "Marron", "Marron", false, false, false, false, "Feminin");
            lesPersonnages.Add(Carmen);
            Personnage Roger = new Personnage(2, "Roger", false, "", "Marron", false, false, true, true, "Masculin");
            lesPersonnages.Add(Roger);
            Personnage Bernard = new Personnage(3, "Bernard", true, "Marron", "Marron", false, true, false, false, "Masculin");
            lesPersonnages.Add(Bernard);
            Personnage Max = new Personnage(4, "Max", true, "Noir", "Marron", false, false, true, false, "Masculin");
            lesPersonnages.Add(Max);
            Personnage Sophie = new Personnage(5, "Sophie", true, "Noir", "Marron", true, false, false, false, "Masculin");
            lesPersonnages.Add(Sophie);
            Personnage Theo = new Personnage(6, "Theo", true, "Noir", "Marron", false, false, false, true, "Masculin");
            lesPersonnages.Add(Theo);
            Personnage Frank = new Personnage(7, "Frank", true, "Noir", "Marron", false, true, false, false, "Masculin");
            lesPersonnages.Add(Frank);
            Personnage Daniel = new Personnage(8, "Daniel", false, "", "Bleu", true, false, false, false, "Masculin");
            lesPersonnages.Add(Daniel);
            Personnage Isabelle = new Personnage(9, "Isabelle", true, "Rouge", "Marron", false, false, false, false, "Feminin");
            lesPersonnages.Add(Isabelle);
            Personnage Herman = new Personnage(10, "Herman", false, "", "Marron", false, false, false, false, "Masculin");
            lesPersonnages.Add(Herman);
            Personnage Phillipe = new Personnage(11, "Philippe", false, "", "Marron", false, false, true, false, "Masculin");
            lesPersonnages.Add(Phillipe);
            Personnage Stephen = new Personnage(12, "Stephen", true, "Rouge", "Bleu", false, false, false, true, "Masculin");
            lesPersonnages.Add(Stephen);
            Personnage Sarah = new Personnage(13, "Sarah", true, "Jaune", "Marron", true, true, false, false, "Feminin");
            lesPersonnages.Add(Sarah);
            Personnage Joe = new Personnage(14, "Joe", true, "Jaune", "Bleu", false, false, false, false, "Masculin");
            lesPersonnages.Add(Joe);
            Personnage Hans = new Personnage(15, "Hans", true, "Jaune", "Marron", false, false, false, true, "Masculin");
            lesPersonnages.Add(Hans);
            Personnage Anita = new Personnage(16, "Anita", true, "Jaune", "Bleu", false, false, false, false, "Feminin");
            lesPersonnages.Add(Anita);
            Personnage Lucas = new Personnage(17, "Lucas", true, "Jaune", "Marron", false, false, true, true, "Masculin");
            lesPersonnages.Add(Lucas);
            Personnage Eric = new Personnage(18, "Eric", true, "Jaune", "Marron", false, true, false, false, "Masculin");
            lesPersonnages.Add(Eric);
            Personnage Victor = new Personnage(19, "Victor", true, "Blanc", "Marron", false, false, false, false, "Masculin");
            lesPersonnages.Add(Victor);
            Personnage Anne = new Personnage(20, "Anne", true, "Blanc", "Bleu", true, false, false, false, "Feminin");
            lesPersonnages.Add(Anne);
            Personnage Charles = new Personnage(21, "Charles", false, "", "Marron", true, false, false, true, "Masculin");
            lesPersonnages.Add(Charles);
            Personnage Paul = new Personnage(22, "Paul", true, "Blanc", "Marron", true, false, true, false, "Masculin");
            lesPersonnages.Add(Paul);
            Personnage Katrin = new Personnage(23, "Katrin", true, "Marron", "Marron", false, false, false, false, "Feminin");
            lesPersonnages.Add(Katrin);
            Personnage Maria = new Personnage(24, "Maria", true, "Marron", "Marron", false, true, false, false, "Feminin");
            lesPersonnages.Add(Maria);
            //     Fin de la création des personnages     //
            Random rdm = new Random();
            int nbRdm = rdm.Next(0, lesPersonnages.Count);
            //
            nomPerso = lesPersonnages[nbRdm].getNom();
            cheveuxPerso = lesPersonnages[nbRdm].getCheveux();
            hairColorPerso = lesPersonnages[nbRdm].gethairColor();
            eyeColorPerso = lesPersonnages[nbRdm].geteyeColor();
            lunettePerso = lesPersonnages[nbRdm].getLunette();
            chapeauPerso = lesPersonnages[nbRdm].getChapeau();
            barbePerso = lesPersonnages[nbRdm].getBarbe();
            moustachePerso = lesPersonnages[nbRdm].getMoustache();
            sexePerso = lesPersonnages[nbRdm].getSexe();
            //
            foreach (Personnage unPerso in lesPersonnages)
            {
                string nomPerso = unPerso.getNom();
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(120, 120);
                pictureBox.ImageLocation = nomPerso + ".png";
                pictureBox.Click += (_sender, _e) => { pictureBox_Click(_sender, _e); };
                flpPerso.Controls.Add(pictureBox);
            }
        }
        private void pictureBox_Click(object _sender, EventArgs _e)
        {
            PictureBox pictureBox = (PictureBox)_sender;
            MouseEventArgs e = (MouseEventArgs)_e;
            if (e.Button == MouseButtons.Left)
            {
                string nomDuPersoClic = Path.GetFileNameWithoutExtension(pictureBox.ImageLocation);
                if (nomDuPersoClic == nomPerso)
                {
                    MessageBox.Show("Bien jouée, tu as deviné mon personnage ;)");
                    RestartGame();
                }
                else
                {
                    MessageBox.Show("Tu as perdu, tu n'as pas réussi à trouver mon personnage :'( \nC'était : " + nomPerso);
                    RestartGame();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                pictureBox.Visible = false;
            }


        }

        private void WhoIsIt_Load(object sender, EventArgs e)
        {
            cmbBoxQuestions.DropDownStyle = ComboBoxStyle.DropDownList;
            LancementPartie();
            pboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pboxLogo.ImageLocation = "Logo-QuiEstce.png";
        }

        private void btnPoserQuestion_Click(object sender, EventArgs e)
        {
            // Vérifier si l'utilisateur a sélectionner une question.
            if (cmbBoxQuestions.SelectedItem == null)
            {
                MessageBox.Show("Vous devez selectionner une question !");
            }
            // S'il a selectionner une question laquelle ?
            else
            {
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ton personnage a des cheveux ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (cheveuxPerso == false)
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont blanc ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont marron ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont noir ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont rouge ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont jaune ?");
                        lblReponse.Text += "\n Mon personnage n'a pas de cheuveux.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage a des cheuveux.";
                    }

                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ton personnage a une moustache ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (moustachePerso == false)
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas de moustache.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage a une moustache.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ton personnage a une barbe ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (barbePerso == false)
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas de barbe.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage a une barbe.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses cheveux sont blanc ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (hairColorPerso == "Blanc")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont marron ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont noir ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont rouge ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont jaune ?");
                        lblReponse.Text += "\n Mon personnage a des cheveux blanc.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les cheveux blanc.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses cheveux sont noir ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (hairColorPerso == "Noir")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont blanc ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont marron ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont rouge ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont jaune ?");
                        lblReponse.Text += "\n Mon personnage a des cheveux noir.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les cheveux noir.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses cheveux sont rouge ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (hairColorPerso == "Rouge")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont blanc ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont marron ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont noir ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont jaune ?");
                        lblReponse.Text += "\n Mon personnage a des cheveux rouges.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les cheveux rouges.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses cheveux sont jaune ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (hairColorPerso == "Jaune")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont blanc ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont marron ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont noir ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont rouge ?");
                        lblReponse.Text += "\n Mon personnage a des cheveux jaune.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les cheveux jaune.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses cheveux sont marron ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (hairColorPerso == "Marron")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont blanc ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont noir ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont rouge ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses cheveux sont jaune ?");
                        lblReponse.Text += "\n Mon personnage a des cheveux marrons.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les cheveux marrons.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses yeux sont bleu ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (eyeColorPerso == "Bleu")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses yeux sont noirs ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses yeux sont marrons ?");
                        lblReponse.Text += "\n Mon personnage a des yeux bleu.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les yeux bleu.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses yeux sont noirs ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (eyeColorPerso == "Noir")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses yeux sont bleu ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses yeux sont marrons ?");
                        lblReponse.Text += "\n Mon personnage a des yeux noirs.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les yeux noirs.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce que ses yeux sont marrons ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (eyeColorPerso == "Marron")
                    {
                        cmbBoxQuestions.Items.Remove("Est-ce que ses yeux sont bleu ?");
                        cmbBoxQuestions.Items.Remove("Est-ce que ses yeux sont noirs ?");
                        lblReponse.Text += "\n Mon personnage a des yeux marrons.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas les yeux marrons.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Ton personnage a t-il des lunettes ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (lunettePerso == true)
                    {
                        lblReponse.Text += "\n Mon personnage a des lunettes.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas de lunette.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Ton personnage a t-il un chapeau ?")
                {
                    cmbBoxQuestions.Items.Remove(cmbBoxQuestions.SelectedItem);
                    if (chapeauPerso == true)
                    {
                        lblReponse.Text += "\n Mon personnage a un chapeau.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage n'a pas de chapeau.";
                    }
                }
                if (cmbBoxQuestions.SelectedItem == "Est-ce un homme ?" || cmbBoxQuestions.SelectedItem == "Est-ce une femme ?")
                {
                    cmbBoxQuestions.Items.Remove("Est-ce un homme ?");
                    cmbBoxQuestions.Items.Remove("Est-ce une femme ?");
                    if (sexePerso == "Masculin")
                    {
                        lblReponse.Text += "\n Mon personnage est un Homme.";
                    }
                    else
                    {
                        lblReponse.Text += "\n Mon personnage est une Femme.";
                    }
                }
            }
        }

        public void RestartGame()
        {
            lblReponse.Text = "";
            cmbBoxQuestions.Items.Clear();
            cmbBoxQuestions.Items.Add("Est-ce que ton personnage a des cheveux ?");
            cmbBoxQuestions.Items.Add("Est-ce que ton personnage a une moustache ?");
            cmbBoxQuestions.Items.Add("Est-ce que ton personnage a une barbe ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses cheveux sont blanc ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses cheveux sont marron ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses cheveux sont noir ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses cheveux sont rouge ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses cheveux sont jaune ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses yeux sont bleu ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses yeux sont noirs ?");
            cmbBoxQuestions.Items.Add("Est-ce que ses yeux sont marrons ?");
            cmbBoxQuestions.Items.Add("Ton personnage a t-il des lunettes ?");
            cmbBoxQuestions.Items.Add("Ton personnage a t-il un chapeau ?");
            cmbBoxQuestions.Items.Add("Est-ce un homme ?");
            cmbBoxQuestions.Items.Add("Est-ce une femme ?");
            LancementPartie();
        }

        private void btnRelancer_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnReafficher_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in flpPerso.Controls)
            {
                item.Visible = true;
            }
        }
    }
}
