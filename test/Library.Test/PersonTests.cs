using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Testname() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Belen","4.849.224-1","20/07/1600");
            string expected = "Belen";
            Assert.AreEqual(expected,p.Name);
        }

        [Test]
        public void Testid() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Belen","4.849.224-1","20/07/1600");
            string expected = "4.849.224-1";
            Assert.AreEqual(expected,p.ID);
        }

        [Test]
        public void Testfecha() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Belen","4.849.224-1","20/07/1600");
            string expected = "20/07/1600";
            Assert.AreEqual(expected,p.FechaNac);
        }
    }
}