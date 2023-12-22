using LR2;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            Assert.False(flower1.isWilted());
        }
        [Test]
        public void Test2()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            flower1.setInWater();
            Assert.True(flower1.inWater);
        }
        [Test]
        public void Test3()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            flower1.setOutWater();
            Assert.False(flower1.inWater);
        }
        [Test]
        public void Test4()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            Assert.False(flower1.isWilted());
        }
        [Test]
        public void Test5()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            flower1.diffTime(10);
            Assert.True(flower1.isWilted());
        }
        [Test]
        public void Test6()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            flower1.diffTime(5);
            Assert.AreEqual(flower1.State, 0.5);
        }
        [Test]
        public void Test7()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            flower1.diffTime(5);
            Assert.AreEqual(flower1.realPrice(), 50);
        }
        [Test]
        public void Test8()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            Flower flower2 = new Flower("Роза", colors.red, 0.02, 0.2, 150);
            Flower flower3 = new Flower("Лилия", colors.blue, 0.001, 0.01, 300);
            Bouquet bouquet = new Bouquet();
            bouquet.addFlower(flower1);
            bouquet.addFlower(flower2);
            bouquet.addFlower(flower3);
            Assert.AreEqual(bouquet.flowersCount(), 3);
            Assert.AreEqual(bouquet.wiltedCount(), 0);
        }
        [Test]
        public void Test9()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            Flower flower2 = new Flower("Роза", colors.red, 0.02, 0.2, 150);
            Flower flower3 = new Flower("Лилия", colors.blue, 0.001, 0.01, 300);
            Bouquet bouquet = new Bouquet();
            bouquet.addFlower(flower1);
            bouquet.addFlower(flower2);
            bouquet.addFlower(flower3);
            bouquet.diffTime(5);
            Assert.AreEqual(bouquet.flowersCount(), 3);
            Assert.AreEqual(bouquet.wiltedCount(), 1);
            Assert.AreEqual(bouquet.price(), 550);
            Assert.AreEqual(bouquet.realPrice(), 335);
        }        
        [Test]
        public void Test10()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            Flower flower2 = new Flower("Роза", colors.red, 0.02, 0.2, 150);
            Flower flower3 = new Flower("Лилия", colors.blue, 0.001, 0.01, 300);
            Bouquet bouquet = new Bouquet();
            bouquet.addFlower(flower1);
            bouquet.addFlower(flower2);
            bouquet.addFlower(flower3);
            bouquet.diffTime(500);
            Assert.AreEqual(bouquet.flowersCount(), 3);
            Assert.AreEqual(bouquet.wiltedCount(), 3);
            Assert.AreEqual(bouquet.price(), 550);
            Assert.AreEqual(bouquet.realPrice(), 0);
        }
        [Test]
        public void Test11()
        {
            Flower flower1 = new Flower("Роза", colors.white, 0.01, 0.1, 100);
            Flower flower2 = new Flower("Роза", colors.red, 0.02, 0.2, 150);
            Flower flower3 = new Flower("Лилия", colors.blue, 0.001, 0.01, 300);
            Bouquet bouquet = new Bouquet();
            bouquet.addFlower(flower1);
            bouquet.addFlower(flower2);
            bouquet.addFlower(flower3);
            bouquet.delFlower(1);
            bouquet.diffTime(500);
            Assert.AreEqual(bouquet.flowersCount(), 2);
            Assert.AreEqual(bouquet.wiltedCount(), 2);
            Assert.AreEqual(bouquet.price(), 400);
            Assert.AreEqual(bouquet.realPrice(), 0);
        }
    }
}