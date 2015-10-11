using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRegistroOk()
        {
            string postdata = "{\"F_creacion\":\"01/01/2015\"," +
                        "\"Estado\":\"Pendiente\"," +
                        "\"Prioridad\":\"Alta\"," +
                        "\"CodEmpleado\":1," +
                        "\"NombreEmpleado\":\"Christian\"," +
                        "\"ApellidoEmpleado\":\"Escobedo\"," +
                        "\"CorreoEmpleado\":\"cc@ccc.com\"," +
                        "\"CargoEmpleado\":\"Administrador\"," +
                        "\"TelefonoEmpleado\":\"1212121212\"," +
                        "\"AreaEmpleado\":\"Operaciones\"," +
                        "\"AsuntoTicket\":\"Cambio de Monitor\"," +
                        "\"ObservacionTicket\":\"Monitor no enciende\"," +
                        "\"Obs_atencion\":\"\" }"; //JSON

            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:58785/GuardaTicketsREST.svc/ticket1");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ideaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Ticket TicketCreado = js.Deserialize<Ticket>(ideaJson);
            Assert.AreEqual("Christian", TicketCreado.NombreEmpleado);
        }

        [TestMethod]
        public void TestRegistrarError()
        {
            string postdata = "{\"F_creacion\":\"01/01/2015\"," +
                        "\"Estado\":\"Pendiente\"," +
                        "\"Prioridad\":\"Seleccionar\"," +
                        "\"CodEmpleado\":1," +
                        "\"NombreEmpleado\":\"Christian\"," +
                        "\"ApellidoEmpleado\":\"Escobedo\"," +
                        "\"CorreoEmpleado\":\"cc@ccc.com\"," +
                        "\"CargoEmpleado\":\"Administrador\"," +
                        "\"TelefonoEmpleado\":\"1212121212\"," +
                        "\"AreaEmpleado\":\"Operaciones\"," +
                        "\"AsuntoTicket\":\"Cambio de Monitor\"," +
                        "\"ObservacionTicket\":\"Monitor no enciende\"," +
                        "\"Obs_atencion\":\"\" }"; //JSON

            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:58785/GuardaTicketsREST.svc/ticket1");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string ideaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Ticket ticketCreado = js.Deserialize<Ticket>(ideaJson);
                Assert.AreEqual("Christian", ticketCreado.NombreEmpleado);
                
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                Assert.AreEqual("Debe seleccionar una prioridad", mensaje);
            }
        }

        [TestMethod]
        public void TestObtener()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:58785/GuardaTicketsREST.svc/ticket/1");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ideaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Ticket ticketObtenido = js.Deserialize<Ticket>(ideaJson);
            Assert.AreEqual(1, ticketObtenido.CodEmpleado);
            Assert.AreEqual("Aranguena", ticketObtenido.ApellidoEmpleado);
        }

        [TestMethod]
        public void TestModificar()
        {
            string postdata = "{\"F_creacion\":\"01/01/2015\"," +
                        "\"Estado\":\"Pendiente\"," +
                        "\"Prioridad\":\"Alta\"," +
                        "\"CodEmpleado\":1," +
                        "\"NombreEmpleado\":\"Christian\"," +
                        "\"ApellidoEmpleado\":\"Escobedo\"," +
                        "\"CorreoEmpleado\":\"cc@ccc.com\"," +
                        "\"CargoEmpleado\":\"Administrador\"," +
                        "\"TelefonoEmpleado\":\"1212121212\"," +
                        "\"AreaEmpleado\":\"Operaciones\"," +
                        "\"LoginErrorCount\":0," +
                        "}"; //JSON

            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:49760/EmpleadosREST.svc/usuarios");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ideaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Empleado empleadoModificado = js.Deserialize<Empleado>(ideaJson);
            Assert.AreEqual(1, empleadoModificado.CodEmpleado);
            Assert.AreEqual(0, empleadoModificado.LoginErrorCount);
        }
    }
}
