using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    /***********************************************************************************************
     * C'est excellent d'avoir vu la classe abstraite !
     * 
     * Par contre son nom est composé d'un verbe « Calculer ». Normalement on associe aux actions
     * (verbes) les méthodes et non les classes. Les classes devraient être simplement des noms.
     * 
     * Peux-tu penser à un meilleur nom pour ta classe abstraite ?
     */
    public abstract class FormeGeometrique
    {
        private Vecteur2 _position;

        /// <summary>
        /// Constructeur de la forme géométrique.
        /// </summary>
        /// <param name="position">Position de la forme.</param>
        protected FormeGeometrique(Vecteur2 position)
        {
            _position = position;
        }

        public Vecteur2 Position { get => _position; set => _position = value; }

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
