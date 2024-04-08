using System;
using System.Collections.Generic;

namespace ClasseGeometrie.Forme
{
    public class Collection
    {
        /***********************************************************************************************
         * Ici l'astuce des tuples fonctionne, mais les tuples peuvent causer des problèmes à moyen terme
         * 
         * Peux-tu penser à une autre façon de gérer la donnée position ?
         */
        private List<FormeGeometrique> listeForme;

        /// <summary>
        /// Constructeur de collection
        /// </summary>
        public Collection()
        {
            listeForme = new List<FormeGeometrique>();
        }



        /// <summary>
        /// Méthode permettant d'ajouter une nouvelle forme a la liste.
        /// </summary>
        /// <param name="forme">La forme à ajouter.</param>
        /// <param name="position">La ^position de la forme</param>
        public void ajouterForme(FormeGeometrique forme)
        {
            listeForme.Add((forme));
        }
        /// <summary>
        /// Méthode permetant de calculer l'aire totale de toute les formes de la collection.
        /// </summary>
        /// <returns>L'aire totale.</returns>
        public double AireTotale()
        {
            double aireTotale = 0;

            foreach (var forme in listeForme)
            {
                aireTotale += forme.Aire();
            }
            return aireTotale;
        }
        /// <summary>
        /// Méthode permetant de calculer le périmetre totale de toute les formes de la collection.
        /// </summary>
        /// <returns>Le périmètre totale.</returns>
        public double PerimetreTotale()
        {
            double perimetreTotale = 0;
            foreach (var forme in listeForme)
            {
                perimetreTotale += forme.Perimetre();
            }
            return perimetreTotale;
        }
    }
}
