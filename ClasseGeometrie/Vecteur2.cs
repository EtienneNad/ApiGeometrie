using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGeometrie.Forme
{
    public class Vecteur2
    {
        private double positionX;
        private double positionY;

        /// <summary>
        /// Constructeur d'un vecteur 2D
        /// </summary>
        /// <param name="positionX">Coordonnée en x</param>
        /// <param name="positionY">Coordonnée en Y</param>
        public Vecteur2(double positionX, double positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }
       
        public double PositionX { get => positionX; set => positionX = value; }
        public double PositionY { get => positionY; set => positionY = value; }
    }
}
