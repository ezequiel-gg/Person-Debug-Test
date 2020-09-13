using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {

        private Person person;


        [SetUp]
        public void Setup()
        {
            person = new Person("Nombre", "5.286.500-6");
        }

        [Test]
        public void Person_Test()
        {
            this.person = new Person("Nombre", "5.286.500-6");
            Assert.IsNotNull(this.person.ID);
            Assert.IsNotNull(this.person.Name);
        }

        [Test]
        public void Doc_Clean_Test()
        {
            this.person = new Person("Nombre", "52865006");
            Assert.IsNotNull(this.person.ID);
            Assert.IsNotNull(this.person.Name);
        }
        [Test]
        public void Doc_Dot_Test()
        {
            this.person = new Person("Nombre", "5.286.5006");
            Assert.IsNotNull(this.person.ID);
            Assert.IsNotNull(this.person.Name);
        }

        [Test]
        public void Doc_Character_Test()
        {
            this.person = new Person("Nombre", "5-286-500-6");
            Assert.IsNotNull(this.person.ID);
            Assert.IsNotNull(this.person.Name);
        }

        [Test]
        public void Empty_Test()
        {
            this.person = new Person("", "");
            Assert.IsNull(this.person.ID);
            Assert.IsNull(this.person.Name);
        }
    }
}