using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    // 5. classe Maison
    class Maison : Batiment
    {
        private int nPieces;

        // 6. constructeur
        public Maison(int anConstruction, double surface, string adresse, int nPieces) : base(anConstruction, surface, adresse)
        {
            this.nPieces = nPieces;
        }
        // 7. redéfinition de la methode toString()
        public new string toString()
        {
            return base.toString() + "\nle nombre de pièces est : " + nPieces;
        }
    }
}
