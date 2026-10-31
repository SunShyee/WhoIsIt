using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIsIt
{
    class Personnage
    {
        private int id;
        private string nom;
        private bool cheveux;
        private string hairColor;
        private string eyeColor;
        private bool lunette;
        private bool chapeau;
        private bool barbe;
        private bool moustache;
        private string sexe;
        

        // Constructeurs
        public Personnage(int id, string nom, bool cheveux, string hairColor, string eyeColor,bool lunette, bool chapeau, bool barbe, bool moustache, string sexe)
        {
            this.id = id;
            this.nom = nom;
            this.cheveux = cheveux;
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
            this.lunette = lunette;
            this.chapeau = chapeau;
            this.barbe = barbe;
            this.moustache = moustache;
            this.sexe = sexe;
        }
        // Accesseurs
        public int getId() { return id; }
        public string getNom() { return nom; }
        public bool getCheveux() {  return cheveux; }
        public string gethairColor() {  return hairColor; }
        public string geteyeColor() { return eyeColor; }
        public bool getLunette() {  return lunette; }
        public bool getChapeau() {  return chapeau; }
        public bool getBarbe() {  return barbe; }
        public bool getMoustache() {  return moustache; }
        public string getSexe() {  return sexe; }
        // Modificateurs
        public void setId(int id) { this.id = id;}
        public void setNom(string nom) { this.nom = nom;}
        public void setCheveux(bool cheveux) { this.cheveux = cheveux;}
        public void sethairColor(string hairColor) { this.hairColor = hairColor;}
        public void seteyeColor(string eyeColor) { this.eyeColor = eyeColor;}
        public void setLunette(bool lunette) { this.lunette = lunette;}
        public void setChapeau(bool chapeau) { this.chapeau = chapeau;}
        public void setBarbe(bool barbe) { this.barbe = barbe;}
        public void setMoustache(bool moustache) { this.moustache = moustache;}
        public void setSexe(string sexe) { this.sexe = sexe;}
        public string toString()
        {
            string text = null;
            text = "Id : " + getId();
            text += "\nNom : " + getNom();
            text += "\nCheveux : " + getCheveux();
            text += "\nCouleur de cheveux : " + gethairColor();
            text += "\nCouleur des yeux : " + geteyeColor();
            text += "\nLunette : " + getLunette();
            text += "\nChapeau : " + getChapeau();
            text += "\nBarbe : " + getBarbe();
            text += "\nMoustache : " + getMoustache();
            text += "\nSexe : " + getSexe();
            return text;
        }
    }
}
