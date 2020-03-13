using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    // 1. classe Batiment
    class Batiment
    {
        private int anConstruction;
        private double surface;
        private string adresse;

        // 2. constructeur
        public Batiment(int anConstruction, double surface, string adresse)
        {
            this.anConstruction = anConstruction;
            this.surface = surface;
            this.adresse = adresse;
        }
        // 3. accesseurs et manipulateurs
        public int AnConstruction
        {
            get { return anConstruction; }
            set { anConstruction = value; }
        }
        public double Surface
        {
            get { return surface; }
            set { surface = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        // 4. methode qui retourne tous les attributs
        public string toString()
        {
            return "l'annee de construction est : " + anConstruction + "\nla surface est : " +
                surface +" pieds carrés" + "\nl'adresse est : " + adresse ;
        }
    }
}
