using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testmethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListarMedicos()
        {
            string dato = YarvizApiHospital.Controllers.Medicos.Equals("Listar");
            Assert.AreEqual("Algo", dato);
        }
        [TestMethod]
        public void ListarPacientes()
        {
            string dato = YarvizApiHospital.Functions.Functions.something();
            Assert.AreEqual("Algo", dato);
        }

        [TestMethod]
        public void ListarCitas()
        {
            string dato = YarvizApiHospital.Functions.Functions.something();
            Assert.AreEqual("Algo", dato);
        }
        [TestMethod]
        public void ListarUsuarios()
        {
            string dato = YarvizApiHospital.Functions.Functions.something();
            Assert.AreEqual("Algo", dato);
        }
        [TestMethod]
        public void GrabasMEdicos()
        {
            string dato = YarvizApiHospital.Functions.Functions.something();
            Assert.AreEqual("Algo", dato);
        }
        [TestMethod]
        public void GrabarCita()
        {
            string dato = YarvizApiHospital.Functions.Functions.something();
            Assert.AreEqual("Algo", dato);
        }
        [TestMethod]
        public void GrabasUsuario()
        {
            string dato = YarvizApiHospital.Functions.Functions.something();
            Assert.AreEqual("Algo", dato);
        }
    }
}