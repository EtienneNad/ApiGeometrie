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

            /***********************************************************************************************
             * Dans la surchage du AreEqual, si l'on travaille avec des double ou float, il y a un troisième 
             * paramètre (appelé delta) qui vérifie la précision avec la laquelle faire la vérification. Si la 
             * différence entre les deux valeurs est plus petite que delta, alors le test est accepté
             * 
             * Par exemple 
             * Assert.AreEqual(10.0, 9.9999, 0.01) est considéré correct, car 10.0 - 9.99999 = 0.0001 < 0.01 => TEST OK
             * Assert.AreEqual(10.0, 9.9, 0.01) est considéré incorrect, car 10.0 - 9.9 = 0.1 > 0.01 ERREUR
             * 
             * La vérification avec un nombre plus grand fonctionne aussi Assert.AreEqual(10.0, 10.0001, 0.001) est correct.
             * 
             * Peux-tu réécrire tes tests avec des doubles en utilisant le paramètre delta ?
             */

            Assert.AreEqual(15, resultatPerimeteMaison, 0.01);
            Assert.AreEqual(5.5, resultatAireMaison,0.01);
        }

        [TestMethod]


        public void TestCalculerNouvelleForme1()
        {
            Collection carreLozange = new Collection();
            carreLozange.ajouterForme(new Carre(3), new Vecteur2(0, 0));
            carreLozange.ajouterForme(new Losange(3,4), new Vecteur2(0, 1.75));


            double resultatPerimeteCarreLosange = carreLozange.PerimetreTotale();
            double resultatAireCarreLosange = carreLozange.AireTotale();
            Assert.AreEqual(22.0, resultatPerimeteCarreLosange, 0.01);
            Assert.AreEqual(15.0, resultatAireCarreLosange, 0.01);
        }

        [TestMethod]


        public void TestCalculerNouvelleForme2()
        {
            Collection tete = new Collection();
            tete.ajouterForme(new Rectangle(3, 2), new Vecteur2(0, 0));
            tete.ajouterForme(new Cercle(2), new Vecteur2(0, 1.75));


            double resultatPerimeteTete = tete.PerimetreTotale();
            double resultatAireTete = tete.AireTotale();
            Assert.AreEqual(22.566, resultatPerimeteTete, 0.01);
            Assert.AreEqual(18.566, resultatAireTete, 0.01);
        }

        [TestMethod]


        public void TestCalculerNouvelleForme3()
        {
            Collection triangleTrapeze = new Collection();

            triangleTrapeze.ajouterForme(new Triangle(2, 3, 3.1, 3.25), new Vecteur2(0, 0));
            triangleTrapeze.ajouterForme(new Trapeze(4,2,1,1.1,1.8), new Vecteur2(0, 1.75));

            double resultatPerimeteTriangleTrapeze = triangleTrapeze.PerimetreTotale();
            double resultatAireTriangleTrapeze = triangleTrapeze.AireTotale();
            Assert.AreEqual(17.25, resultatPerimeteTriangleTrapeze, 0.01);
            Assert.AreEqual(6, resultatAireTriangleTrapeze, 0.01);
        }
    }

}
