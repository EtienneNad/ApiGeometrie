using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Trapeze:FormeGeometrique
    {
        private double _grandeBase;
        private double _petiteBase;
        private double _hauteur;
        private double _coteA;
        private double _coteB;


        /// <summary>
        /// Constructeur du trapèze.
        /// </summary>
        /// <param name="grandeBase">Taille de la grande base.</param>
        /// <param name="petiteBase">Taille de la petite base.</param>
        /// <param name="hauteur">Taille de la hauteur.</param>
        /// <param name="coteA">Taille du côté A.</param>
        /// <param name="coteB">Taille du côté B.</param>
        /// <param name="position">Position du trapèse.</param>
        public Trapeze(double grandeBase, double petiteBase, double hauteur, double coteA, double coteB, Vecteur2 position) : base(position)
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

        public override double Perimetre()
        {
            double perimetre = this.CoteA + this.CoteB + this.PetiteBase + this.GrandeBase;
            return perimetre;
        }

        public override double Aire()
        {
            double calculeBases = this.GrandeBase +this.PetiteBase;
            double aire = (calculeBases) * this.Hauteur/2;
            return aire;
        }
        /// <summary>
        /// Méthode permettant d'afficher les informations du trapèze.
        /// </summary>
        /// <returns>Les informations d'un trapèze. </returns>
        public override string ToString()
        {

            return "Trapèze - Grande Base (g): " + this.GrandeBase + "Petite Base (p):" + this.PetiteBase + ", Hauteur (h): " + this.Hauteur + ", Côté (a): " + this._coteA + 
                ", Côté (b): " + this.CoteB + ", Périmètre: " + Perimetre() + ", Aire: " + Aire();
        }

        
    }
}
