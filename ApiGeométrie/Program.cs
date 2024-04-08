using System;
using ClasseGeometrie.Forme;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            Cercle cercle = new Cercle(2, new Vecteur2(0, 0));
            Triangle triangle = new Triangle(2,3,3.1,3.25, new Vecteur2(0, 0));
            Carre carre = new Carre(3, new Vecteur2(0, 0));
            Rectangle rectangle = new Rectangle(2,3, new Vecteur2(0, 0));
            Losange losange = new Losange(4, 3, new Vecteur2(0, 0));
            Trapeze trapeze = new Trapeze(4, 2, 1, 1.1, 1.8, new Vecteur2(0, 0));

            Console.WriteLine(cercle);
            Console.WriteLine(triangle);
            Console.WriteLine(carre);
            Console.WriteLine(rectangle);
            Console.WriteLine(losange);
            Console.WriteLine(trapeze);

            Collection maison = new Collection();
            maison.ajouterForme(new Carre(2, new Vecteur2(0, 0)));
            maison.ajouterForme(new Triangle(2, 1.5, 2.5, 2.5, new Vecteur2(0, 1.75)));
            Console.WriteLine( maison.AireTotale());
            Console.WriteLine(maison.PerimetreTotale());

            //Console.WriteLine($"Aire Totale: {maison.AireTotale()}"); // Output: 5.5
            //Console.WriteLine($"Perimetre Total: {maison.PerimetreTotal()}"); // Output: Perimeter of all shapes combined
            //double resultatAire = Cercle.CalculerAireCercle(2);

            //Console.WriteLine(resultatAire + '\n');
        }
    }
}