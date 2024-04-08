using System.Reflection.Metadata.Ecma335;

namespace ClasseGeometrie.Forme
{
    public class Triangle : FormeGeometrique
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
        /// <param name="position">Position du triangle.</param>
        public Triangle(double baseB, double hauteur, double coteA, double coteC, Vecteur2 position) : base(position)
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
            return perimetre;
        }

        public override double Aire()
        {
            double aire = ( this.BaseB * this.Hauteur)/2;
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