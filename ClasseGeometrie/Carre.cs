using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Carre : FormeGeometrique
    {
        private double _cote;

        /// <summary>
        /// Constructeur du carré.
        /// </summary>
        /// <param name="cote">Taille d'un côté.</param>
        public Carre(double cote)
        {
            _cote = cote;
        }

        public double Cote { get => _cote; set => _cote = value; }

        public override double Perimetre()
        {
            double perimetre = 4 * this.Cote;
            return perimetre;
        }
        public  override double Aire()
        {
            double aire = Math.Pow(this.Cote, 2);
            return aire;
        }
        /// <summary>
        /// Méthode permettant d'afficher les informations du carré
        /// </summary>
        /// <returns>Les informations d'un carré.</returns>
        public override string ToString()
        {
            return "Carré - Coté (c): " + this.Cote  + ", Périmètre: " + Perimetre() + ", Aire: " + Aire();
        }
    }
}
