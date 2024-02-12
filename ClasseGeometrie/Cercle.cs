using System;

namespace ClasseGeometrie.Forme
{
    public class Cercle
    {
        private double _rayon;

        

        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public double Rayon { get => _rayon; set => _rayon = value; }

        public double CalculerPerimetreCercle()
        {
            double pie = Math.PI;
            double perimetre = 2 * pie * this.Rayon ;
            perimetre = Math.Round(perimetre, 3);
            return perimetre;
        }

        public double CalculerAireCercle()
        {
            double pie = Math.PI;
            double aire = pie * Math.Pow(this.Rayon, 2);
            aire = Math.Round(aire, 3);
            return aire;
        }

        public override string ToString()
        {

            return "Cercle - Rayon: "+ this.Rayon + ", Périmètre: " + CalculerPerimetreCercle() + ", Aire: " + CalculerAireCercle();
        }
    }
}
