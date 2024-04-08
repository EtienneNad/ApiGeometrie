using System.Xml.Serialization;
using ClasseGeometrie.Forme;
namespace TestGeometrie
{
    [TestClass]
    public class TestFormeGeometrique
    {
        /// <summary>
        /// Test pour le périmètre et l'aire du Cercle
        /// </summary>

        [TestMethod]


        public void TestCalculerPerimetreCercle()
        {
            double rayon = 2;

            Cercle cercle = new Cercle(rayon, new Vecteur2(0, 0));
            double resultat = cercle.Perimetre();

            Assert.AreEqual(12.566, resultat, 0.01 );
        }

        [TestMethod]
        public void TestCalculerAireCercle()
        {

            double rayon = 2;

            Cercle cercle = new Cercle(rayon, new Vecteur2(0, 0));
            double resultat = cercle.Aire();

            Assert.AreEqual(12.566, resultat, 0.01);
        }
        /// <summary>
        /// Test pour le périmètre et l'aire du Triangle
        /// </summary>

        [TestMethod]


        public void TestCalculerPerimetreTriangle()
        {
            double baseB = 2;
            double hauteur = 3;
            double coteA = 3.1;
            double coteC = 3.25;
            Triangle triangle = new Triangle(baseB, hauteur,coteA,coteC, new Vecteur2(0, 0));

            double resultat = triangle.Perimetre();
            Assert.AreEqual(8.35, resultat, 0.01);
        }

        [TestMethod]
        public void TestCalculerAireTriangle()
        {
            double baseB = 2;
            double hauteur = 3;
            double coteA = 3.1;
            double coteC = 3.25;
            Triangle triangle = new Triangle(baseB, hauteur, coteA, coteC, new Vecteur2(0, 0));

            double resultat = triangle.Aire();
            Assert.AreEqual(3, resultat, 0.01);
        }
        /// <summary>
        /// Test pour le périmètre et l'aire du carré
        /// </summary>

        [TestMethod]


        public void TestCalculerPerimetreCarre()
        {
            double cote = 3;
            
            Carre carre = new Carre(cote, new Vecteur2(0, 0));
            double resultat = carre.Perimetre();

            Assert.AreEqual(12, resultat, 0.01);
        }

        [TestMethod]
        public void TestCalculerAireCarre()
        {

            double cote = 3;
            Carre carre = new Carre(cote, new Vecteur2(0, 0));

            double resultat = carre.Aire();
            Assert.AreEqual(9,resultat, 0.01);
        }

        /// <summary>
        /// Test pour le périmètre et l'aire du rectangle
        /// </summary>
       
        [TestMethod]
        
      
            public void TestCalculerPerimetreRectangle()
            {
                double largeur = 2;
                double hauteur = 3;
                Rectangle rectangle = new Rectangle(largeur, hauteur, new Vecteur2(0, 0));
                double resultat = rectangle.Perimetre();

                Assert.AreEqual(10, resultat, 0.01);
            }
     
            [TestMethod]
            public void TestCalculerAireRectangle()
            {
                
                double largeur = 2;
                double hauteur = 3;
                Rectangle rectangle = new Rectangle(largeur, hauteur, new Vecteur2(0, 0));

                double resultat = rectangle.Aire();
                Assert.AreEqual(6,resultat, 0.01);
            }
        /// <summary>
        /// Test pour le périmètre et l'aire du Losange
        /// </summary>

        [TestMethod]


        public void TestCalculerPerimetreLosange()
        {
            double grandeDiagonale = 4;
            double petiteDiagonale = 3;
            Losange losange = new Losange(grandeDiagonale, petiteDiagonale, new Vecteur2(0, 0));

            double resultat = losange.Perimetre();
            Assert.AreEqual(10, resultat, 0.01);
        }

        [TestMethod]
        public void TestCalculerAireLosange()
        {
            double grandeDiagonale = 4;
            double petiteDiagonale = 3;
            Losange losange = new Losange(grandeDiagonale, petiteDiagonale, new Vecteur2(0, 0));

            double resultat = losange.Aire();
            Assert.AreEqual(6, resultat, 0.01);
        }

        /// <summary>
        /// Test pour le périmètre et l'aire du Trapèze
        /// </summary>

        [TestMethod]


        public void TestCalculerPerimetreTrapeze()
        {
            double grandeBase = 4;
            double petiteBase = 2;
            double hauteur = 1;
            double coteA = 1.1;
            double coteB = 1.8;
            Trapeze trapeze = new Trapeze(grandeBase, petiteBase, hauteur, coteA, coteB, new Vecteur2(0, 0));

            double resultat = trapeze.Perimetre();
            Assert.AreEqual(8.9, resultat, 0.01);
        }

        [TestMethod]
        public void TestCalculerAireTrapeze()
        {
            double grandeBase = 4;
            double petiteBase = 2;
            double hauteur = 1;
            double coteA = 1.1;
            double coteB = 1.8;
            Trapeze trapeze = new Trapeze(grandeBase,petiteBase,hauteur,coteA, coteB, new Vecteur2(0, 0));

            double resultat = trapeze.Aire();
            Assert.AreEqual(3, resultat, 0.01);
        }

    }
}