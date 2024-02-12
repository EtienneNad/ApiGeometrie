using System.Reflection.Metadata.Ecma335;

namespace ClasseGeometrie.Forme
{
    public class Triangle
    {
        private double _baseB;
        private double _hauteur;
        private double _coteA;
        private double _coteC;

        

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


        public double CalculerPerimetreTriangle()
        {
            double perimetre = this.CoteA + this.BaseB + this.CoteC;
            perimetre = Math.Round(perimetre, 4);
            return perimetre;
        }

        public double CalculerAireTriangle()
        {
            double aire = ( this.BaseB * this.Hauteur)/2;
            aire = Math.Round(aire, 4);
            return aire;
        }

        public override string ToString()
        {

            return "Triangle - Base (b): " + this.BaseB + ", Hauteur (h): "+ this.Hauteur + ", Côté (a): "+ this._coteA + ", Côté (c): " + this.CoteC + ", Périmètre: " + CalculerPerimetreTriangle() + ", Aire: " + CalculerAireTriangle();
        }

    }
}