using System.Reflection.Metadata.Ecma335;

namespace ClasseGeometrie.Forme
{
    public class Triangle : CalculerForme
    {
        private double _baseB;
        private double _hauteur;
        private double _coteA;
        private double _coteC;

        
        /// <summary>
        /// Constructeur du triangle. 
        /// </summary>
        /// <param name="baseB">Taille de la base.</param>
        /// <param name="hauteur">Taille de la hauteur.</param>
        /// <param name="coteA">Taille du côté A.</param>
        /// <param name="coteC">Taille du côté C.</param>
        public Triangle(double baseB, double hauteur, double coteA, double coteC)
        {
            _baseB = baseB;
            _hauteur = hauteur;
            _coteA = coteA;
            _coteC = coteC;
        }

        public double BaseB { get => _baseB; set => _baseB = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }
        public double CoteA { get => _coteA; set => _coteA = value; }
        public double CoteC { get => _coteC; set => _coteC = value; }


        public override double Perimetre()
        {
            double perimetre = this.CoteA + this.BaseB + this.CoteC;
            perimetre = Math.Round(perimetre, 4);
            return perimetre;
        }

        public override double Aire()
        {
            double aire = ( this.BaseB * this.Hauteur)/2;
            aire = Math.Round(aire, 4);
            return aire;
        }
        /// <summary>
        /// Méthode permettant d'afficher les informations du triangle.
        /// </summary>
        /// <returns>Les informations d'un triangle. </returns>

        public override string ToString()
        {

            return "Triangle - Base (b): " + this.BaseB + ", Hauteur (h): "+ this.Hauteur + ", Côté (a): "+ this._coteA + ", Côté (c): " + this.CoteC + ", Périmètre: " + Perimetre() + ", Aire: " + Aire();
        }

    }
}