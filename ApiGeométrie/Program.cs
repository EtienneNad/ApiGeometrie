using System;
using ClasseGeometrie.Forme;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cercle cercle = new Cercle(2);
            Triangle triangle = new Triangle(2,3,3.1,3.25);
            Carre carre = new Carre(3);
            Rectangle rectangle = new Rectangle(2,3);
            Losange losange = new Losange(4, 3);
            Trapeze trapeze = new Trapeze(4, 2, 1, 1.1, 1.8);

            Console.WriteLine(cercle);
            Console.WriteLine(triangle);
            Console.WriteLine(carre);
            Console.WriteLine(rectangle);
            Console.WriteLine(losange);
            Console.WriteLine(trapeze);

            //double resultatAire = Cercle.CalculerAireCercle(2);

            //Console.WriteLine(resultatAire + '\n');
        }
    }
}