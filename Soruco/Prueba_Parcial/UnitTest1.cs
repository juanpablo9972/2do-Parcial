using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soruco;
namespace Prueba_Parcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Save()
        {
            //organizar
            Company person = new Company("Juan", 1000);
            double valoresperado = 1500;
            //actuar
            person.Save(500);
            double valorobtenido = person.SaveProject;
            //afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }

        [TestMethod]
        public void Spend()
        {
            //organizar
            Company person = new Company("Juan", 1000);
            double valoresperado = 500;
            //actuar
            person.Spend(500);
            double valorobtenido = person.SaveProject;
            //afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }
        [TestMethod]
        public void ChangeName()
        {
            //organizar
            Company person = new Company("Juan", 1000);
            string valoresperado = "Pedro" ;
            //actuar
            person.ChangeName("Pedro");
            string valorobtenido = person.Name;
            //afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }
    }
}
