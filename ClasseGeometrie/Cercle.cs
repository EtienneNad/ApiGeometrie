using System;

namespace ClasseGeometrie.Forme
{
    public class Cercle : CalculerForme
    {
        private double _rayon;


        /// <summary>
        /// Constructeur du cercle.
        /// </summary>
        /// <param name="rayon">Taille du rayon.</param>
        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public double Rayon { get => _rayon; set => _rayon = value; }


        public override double Perimetre()
        {
            double pie = Math.PI;
            double perimetre = 2 * pie * this.Rayon;
            perimetre = Math.Round(perimetre, 3);
            return perimetre;
        }
        public override double Aire()
        {
            double pie = Math.PI;
            double aire = pie * Math.Pow(this.Rayon, 2);
            aire = Math.Round(aire, 3);
            return aire;
        }

        /// <summary>
        /// Méthode permettant d'afficher les informations du cercle.
        /// </summary>
        /// <returns>Les informations d'un cercle.</returns>
        public override string ToString()
        {

            return "Cercle - Rayon: " + this.Rayon + ", Périmètre: " + Perimetre() + ", Aire: " + Aire();
        }
    }
}
