using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    // 8. classe Immeuble
    class Immeuble : Batiment
    {
        private int nAppartement;

        // 9. constructeur
        public Immeuble(int anConstruction, double surface, string adresse, int nAppartement) : base(anConstruction, surface, adresse)
        {
            this.nAppartement = nAppartement;
        }
        // 10. redéfinition de la methode toString()
        public new string toString()
        {
            return base.toString() + "\nle nombre d'appartement est : " + nAppartement;
        }
    }
}
