using System.Xml.Serialization;
using ClasseGeometrie.Forme;
namespace TestGeometrie
{
    [TestClass]
    public class TestCollection
    {
        [TestMethod]


        public void TestCalculerMaison()
        {
            Collection maison = new Collection();
            maison.ajouterForme(new Carre(2), new Vecteur2(0, 0));
            maison.ajouterForme(new Triangle(2, 1.5, 2.5, 2.5), new Vecteur2(0, 1.75));


            double resultatPerimeteMaison = maison.PerimetreTotale();
            double resultatAireMaison = maison.AireTotale();
            Assert.AreEqual(15, resultatPerimeteMaison);
            Assert.AreEqual(5.5, resultatAireMaison);
        }

        [TestMethod]


        public void TestCalculerNouvelleForme1()
        {
            Collection carreLozange = new Collection();
            carreLozange.ajouterForme(new Carre(3), new Vecteur2(0, 0));
            carreLozange.ajouterForme(new Losange(3,4), new Vecteur2(0, 1.75));


            double resultatPerimeteCarreLosange = carreLozange.PerimetreTotale();
            double resultatAireCarreLosange = carreLozange.AireTotale();
            Assert.AreEqual(22.0, resultatPerimeteCarreLosange);
            Assert.AreEqual(15.0, resultatAireCarreLosange);
        }

        [TestMethod]


        public void TestCalculerNouvelleForme2()
        {
            Collection tete = new Collection();
            tete.ajouterForme(new Rectangle(3, 2), new Vecteur2(0, 0));
            tete.ajouterForme(new Cercle(2), new Vecteur2(0, 1.75));


            double resultatPerimeteTete = tete.PerimetreTotale();
            double resultatAireTete = tete.AireTotale();
            Assert.AreEqual(22.566, resultatPerimeteTete);
            Assert.AreEqual(18.566, resultatAireTete);
        }

        [TestMethod]


        public void TestCalculerNouvelleForme3()
        {
            Collection triangleTrapeze = new Collection();

            triangleTrapeze.ajouterForme(new Triangle(2, 1.5, 2.5, 2.5), new Vecteur2(0, 0));
            triangleTrapeze.ajouterForme(new Trapeze(4,2,1,1.1,1.8), new Vecteur2(0, 1.75));

            double resultatPerimeteTriangleTrapeze = triangleTrapeze.PerimetreTotale();
            double resultatAireTriangleTrapeze = triangleTrapeze.AireTotale();
            Assert.AreEqual(17.25, resultatPerimeteTriangleTrapeze);
            Assert.AreEqual(6, resultatAireTriangleTrapeze);
        }
    }

}
