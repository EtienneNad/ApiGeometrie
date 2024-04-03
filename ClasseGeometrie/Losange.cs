using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Losange : FormeGeometrique
    {
        private double _grandeDiagonale;
        private double _petiteDiagonale;
        /// <summary>
        /// Constructeur du losange.
        /// </summary>
        /// <param name="grandeDiagonale">Taille de la grande diagonale.</param>
        /// <param name="petiteDiagonale">Taille de la petite diagonale.</param>
        public Losange(double grandeDiagonale, double petiteDiagonale)
        {
            GrandeDiagonale = grandeDiagonale;
            PetiteDiagonale = petiteDiagonale;
        }

        public double GrandeDiagonale { get => _grandeDiagonale; set => _grandeDiagonale = value; }
        public double PetiteDiagonale { get => _petiteDiagonale; set => _petiteDiagonale = value; }

        public override double Perimetre()
        {
            double diagonaleG = Math.Pow(this.GrandeDiagonale, 2);
            double diagonaleP = Math.Pow(this.PetiteDiagonale, 2);
            double racineCarre = Math.Sqrt(diagonaleG + diagonaleP);
            double perimetre = 2 * racineCarre;
            return perimetre;
            
        }
        public override double Aire()
        {
            double aire = this.GrandeDiagonale * this.PetiteDiagonale / 2;
            return aire;
        }
        /// <summary>
        /// Méthode permettant d'afficher les informations du losange.
        /// </summary>
        /// <returns>Les informations d'un losange. </returns>
        public override string ToString()
        {
            return "Losange - Grande Diagonale (g): " + this.GrandeDiagonale + ", Petite Diagonale (p): " + this.PetiteDiagonale + ", Périmètre: " + Perimetre() + ", Aire: " + Aire();
        }

       
    }
}
