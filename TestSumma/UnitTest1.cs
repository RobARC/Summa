namespace TestSumma
{
    public class AgenteTests
    {
        private AgenteA agenteA;
        private AgenteB agenteB;
        private AgenteC agenteC;

        [SetUp]
        public void Setup()
        {
            agenteA = new AgenteA();
            agenteB = new AgenteB();
            agenteC = new AgenteC();
        }

        [Test]
        public void TestAgenteAGetMedia()
        {
            var numeros = new List<double> { 25, 40, 32, 47, 56 };
            double resultado = agenteA.GetMedia(numeros);
            Assert.AreEqual(40, resultado);
        }

        [Test]
        public void TestAgenteAGetMediaReturnType()
        {
            var numeros = new List<double> { 25, 40, 32, 47, 56 };
            double resultado = agenteA.GetMedia(numeros);
            Assert.IsInstanceOf(typeof(double), resultado);
        }

        [Test]
        public void TestAgenteAGetStaircaseReturnType()
        {
            string resultado = agenteA.GetStaircase(3);
            Assert.IsInstanceOf(typeof(string), resultado);
        }

        [Test]
        public void TestAgenteAGetMediaWithEmptyList()
        {
            var numeros = new List<double> { };
            Assert.Throws<System.InvalidOperationException>(() => agenteA.GetMedia(numeros));
        }

        [Test]
        public void TestAgenteAGetStaircaseWithZero()
        {
            Assert.Throws<System.ArgumentException>(() => agenteA.GetStaircase(0));
        }

        [Test]
        public void TestAgenteAGetStaircase()
        {
            string resultado = agenteA.GetStaircase(3);
            string esperado = "  #\n ##\n###\n";
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestAgenteBGetMedia()
        {
            
            var numeros = new List<double> { 25, 40, 32, 47, 56 };
            double resultado = agenteB.GetMedia(numeros);
            Assert.AreEqual(36.932057362557181, resultado);
        }
        [Test]
        public void TestAgenteBGetStaircase()
        {
            string resultado = agenteB.GetStaircase(3);
            string esperado = "###\n ##\n  #\n";
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestAgenteCGetMedia()
        {
            var numeros = new List<double> { 25, 40, 32, 47, 56 };
            double resultado = agenteC.GetMedia(numeros);
            Assert.AreEqual(40, resultado);
        }
        [Test]
        public void TestAgenteCGetStaircase()
        {
            string resultado = agenteC.GetStaircase(4);
            string esperado = "   ####\n" +
                              "  ######\n" +
                              " ########\n" +
                              "##########\n" +
                              " ########\n" +
                              "  ######\n" +
                              "   ####\n";
            Assert.AreEqual(esperado, resultado);
        }
    }
}