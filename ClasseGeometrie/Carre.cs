using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Carre
    {
        private double _cote;

        public Carre(double cote)
        {
            _cote = cote;
        }

        public double Cote { get => _cote; set => _cote = value; }

        public double CalculerPerimetreCarre()
        {
            double perimetre = 4 * this.Cote;
            return perimetre;
        }
        public double CalculerAireCarre()
        {
            double aire = Math.Pow(this.Cote, 2);
            return aire;
        }
        public override string ToString()
        {
            return "Carré - Coté (c): " + this.Cote  + ", Périmètre: " + CalculerPerimetreCarre() + ", Aire: " + CalculerAireCarre();
        }
    }
}
