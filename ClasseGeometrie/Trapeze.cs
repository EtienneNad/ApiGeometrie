using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Trapeze
    {
        private double _grandeBase;
        private double _petiteBase;
        private double _hauteur;
        private double _coteA;
        private double _coteB;



        public Trapeze(double grandeBase, double petiteBase, double hauteur, double coteA, double coteB)
        {
            _grandeBase = grandeBase;
            _petiteBase = petiteBase;
            _hauteur = hauteur;
            _coteA = coteA;
            _coteB = coteB;
        }
        public double GrandeBase { get => _grandeBase; set => _grandeBase = value; }
        public double PetiteBase { get => _petiteBase; set => _petiteBase = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }
        public double CoteA { get => _coteA; set => _coteA = value; }
        public double CoteB { get => _coteB; set => _coteB = value; }

        public double CalculerPerimetreTrapeze()
        {
            double perimetre = this.CoteA + this.CoteB + this.PetiteBase + this.GrandeBase;
            return perimetre;
        }

        public double CalculerAireTrapeze()
        {
            double calculeBases = this.GrandeBase +this.PetiteBase;
            double aire = (calculeBases) * this.Hauteur/2;
            return aire;
        }
        public override string ToString()
        {

            return "Trapèze - Grande Base (g): " + this.GrandeBase + "Petite Base (p):" + this.PetiteBase + ", Hauteur (h): " + this.Hauteur + ", Côté (a): " + this._coteA + 
                ", Côté (b): " + this.CoteB + ", Périmètre: " + CalculerPerimetreTrapeze() + ", Aire: " + CalculerAireTrapeze();
        }

        
    }
}
