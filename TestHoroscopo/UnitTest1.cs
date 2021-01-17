using NUnit.Framework;
using ProyectoHoroscopo.Controllers;

namespace TestHoroscopo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestHoroscopo1()
        {
            //Arrange=preparacion
            int dia = 5;
            int mes = 12;
            string esperado = "Sagitario: sos buena gente, te va a ir bien en la vida";
            HoroscopoController fort = new HoroscopoController();

            //Act=ejecucion
            string resultado = fort.horoscopoget(dia, mes);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
        [Test]
        public void TestHoroscopo2()
        {
            //Arrange=preparacion
            int dia = 50;
            int mes = -2;
            string esperado = "error";
            HoroscopoController fort = new HoroscopoController();

            //Act=ejecucion
            string resultado = fort.horoscopopost(dia, mes);

            //Assert=verificacion
            Assert.AreEqual(esperado, resultado);
        }
    }
}