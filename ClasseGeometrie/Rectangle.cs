using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Rectangle
    {
        private double _largeur;
        private double _hauteur;

        public Rectangle(double largeur, double hauteur)
        {
            _largeur = largeur;
            _hauteur = hauteur;
        }

        public double Largeur { get => _largeur; set => _largeur = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }

        public double CalculerPerimetreRectangle()
        {
            double perimetre = 2 * (this.Largeur + this.Hauteur);
            return perimetre;
        }
        public double CalculerAireRectangle()
        {
            double aire = this.Largeur * this.Hauteur;
            return aire;
        }
        public override string ToString()
        {
            return "Rectangle - Largeur (l): " + this.Largeur + ", Hauteur (h): " + this.Hauteur + ", Périmètre: " + CalculerPerimetreRectangle() + ", Aire: " + CalculerAireRectangle();
        }
    }

}
