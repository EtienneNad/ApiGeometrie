using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Losange
    {
        private double _grandeDiagonale;
        private double _petiteDiagonale;

        public Losange(double grandeDiagonale, double petiteDiagonale)
        {
            GrandeDiagonale = grandeDiagonale;
            PetiteDiagonale = petiteDiagonale;
        }

        public double GrandeDiagonale { get => _grandeDiagonale; set => _grandeDiagonale = value; }
        public double PetiteDiagonale { get => _petiteDiagonale; set => _petiteDiagonale = value; }

        public double CalculerPerimetreLosange()
        {
            double diagonaleG = Math.Pow(this.GrandeDiagonale, 2);
            double diagonaleP = Math.Pow(this.PetiteDiagonale, 2);
            double racineCarre = Math.Sqrt(diagonaleG + diagonaleP);
            double perimetre = 2 * racineCarre;
            return perimetre;
            
        }
        public double CalculerAireLosange()
        {
            double aire = this.GrandeDiagonale * this.PetiteDiagonale / 2;
            return aire;
        }
        public override string ToString()
        {
            return "Losange - Grande Diagonale (g): " + this.GrandeDiagonale + ", Petite Diagonale (p): " + this.PetiteDiagonale + ", Périmètre: " + CalculerPerimetreLosange() + ", Aire: " + CalculerAireLosange();
        }

       
    }
}
