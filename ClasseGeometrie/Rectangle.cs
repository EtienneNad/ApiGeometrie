using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Rectangle : FormeGeometrique
    {
        private double _largeur;
        private double _hauteur;

        /// <summary>
        /// Constructeur du rectangle.
        /// </summary>
        /// <param name="largeur">Taille de la Largeur.</param>
        /// <param name="hauteur">Taille de la hauteur.</param>
        /// <param name="position">Position du rectangle.</param>

        public Rectangle(double largeur, double hauteur, Vecteur2 position) : base(position)
        {
            _largeur = largeur;
            _hauteur = hauteur;
        }

        public double Largeur { get => _largeur; set => _largeur = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }

        public override double Perimetre()
        {
            double perimetre = 2 * (this.Largeur + this.Hauteur);
            return perimetre;
        }
        public override double Aire()
        {
            double aire = this.Largeur * this.Hauteur;
            return aire;
        }
        /// <summary>
        /// Méthode permettant d'afficher les informations du rectangle.
        /// </summary>
        /// <returns>Les informations d'un rectangle. </returns>
        public override string ToString()
        {
            return "Rectangle - Largeur (l): " + this.Largeur + ", Hauteur (h): " + this.Hauteur + ", Périmètre: " + Perimetre() + ", Aire: " + Aire();
        }
    }

}
