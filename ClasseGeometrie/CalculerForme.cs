using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public abstract class CalculerForme
    {
        /// <summary>
        /// Méthode permettant de calculer l'aire de la forme.
        /// </summary>
        /// <returns>Le périmètre</returns>
        public abstract double Aire();
        /// <summary>
        /// Méthode permettant de calculer le périmètre de la forme.
        /// </summary>
        /// <returns>L'aire</returns>
        public abstract double Perimetre();
    }
}
