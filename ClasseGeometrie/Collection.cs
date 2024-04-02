using System;
using System.Collections.Generic;

namespace ClasseGeometrie.Forme
{
    public class Collection
    {
        /***********************************************************************************************
         * Ici l'astuce des tuples fonctionne, mais les tuples peuvent causer des problèmes à moyen terme
         * Peux-tu penser à une autre façon de gérer la donnée position ?
         */
        private List<(CalculerForme forme, Vecteur2 position)> listeForme;

        /// <summary>
        /// Constructeur de collection
        /// </summary>
        public Collection()
        {
            listeForme = new List<(CalculerForme forme, Vecteur2 position)>();
        }



        /// <summary>
        /// Méthode permettant d'ajouter une nouvelle forme a la liste.
        /// </summary>
        /// <param name="forme">La forme à ajouter.</param>
        /// <param name="position">La ^position de la forme</param>
        public void ajouterForme(CalculerForme forme, Vecteur2 position)
        {
            listeForme.Add((forme, position));
        }
        /// <summary>
        /// Méthode permetant de calculer l'aire totale de toute les formes de la collection.
        /// </summary>
        /// <returns>L'aire totale.</returns>
        public double AireTotale()
        {
            double aireTotale = 0;

            foreach (var (formes, position) in listeForme)
            {
                aireTotale += formes.Aire();
            }

            /***********************************************************************************************
             * Je comprends ici que tu te sers de l'arrondi à 3 chiffres pour les tests. Il y a une 
             * autre technique que je t'explique dans le projet de tests pour gérer le problème des nombres décimaux)
             */
            aireTotale = Math.Round(aireTotale, 3);
            return aireTotale;
        }
        /// <summary>
        /// Méthode permetant de calculer le périmetre totale de toute les formes de la collection.
        /// </summary>
        /// <returns>Le périmètre totale.</returns>
        public double PerimetreTotale()
        {
            double perimetreTotale = 0;
            foreach (var (forme, position) in listeForme)
            {
                perimetreTotale += forme.Perimetre();
            }
            perimetreTotale = Math.Round(perimetreTotale, 3);
            return perimetreTotale;
        }
    }
}
