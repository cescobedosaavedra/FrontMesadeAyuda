//using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.ServiceRefUser;
using principal.ServiceRefUser;
namespace Test
{
    [TestClass]
    public class ObtenerUsuarioTest
    {
        [TestMethod]
        public void TestObtenerUsuario()
        {

            // Invocar la clase
            ServiceRefUser.IEmpleados usuarios = new ServiceRefUser.EmpleadosClient();

            // Invocar el metodo a probar
            Empleado empleado = new Empleado();
            empleado = usuarios.ObtenerEmpleado(int.Parse("1"));
            string user = empleado.NombreEmpleado;
            //Verificar el resultado
            Assert.AreEqual("Chrsitan", user);

        }
         [TestMethod]
        public void TestObtenerUsuario2()
        {

            // Invocar la clase
            ServiceRefUser.IEmpleados usuarios = new ServiceRefUser.EmpleadosClient();

            // Invocar el metodo a probar
            Empleado empleado = new Empleado();
            empleado = usuarios.ObtenerEmpleado(int.Parse("1"));
            string user = empleado.ApellidoEmpleado;
            //Verificar el resultado
            Assert.AreEqual("Escobedo", user);

        }

         [TestMethod]
         public void TestObtenerUsuario3()
         {

             // Invocar la clase
             ServiceRefUser.IEmpleados usuarios = new ServiceRefUser.EmpleadosClient();

             // Invocar el metodo a probar
             Empleado empleado = new Empleado();
             empleado = usuarios.ObtenerEmpleado(int.Parse("3"));
             string user = empleado.NombreEmpleado;
             //Verificar el resultado
             Assert.AreEqual("Rocio", user);

         }
    }
}
