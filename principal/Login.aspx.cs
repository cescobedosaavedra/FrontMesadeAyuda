using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using principal.ServiceRefUser;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;


namespace principal
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                         .Create("http://localhost:49760/EmpleadosREST.svc/Usuario/" + txtUsuario.Text);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string ticketJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Empleado usuarioSession = js2.Deserialize<Empleado>(ticketJson2);
            string nombre = txtUsuario.Text;
            string password = txtPassword.Text;
            

            if (usuarioSession == null) /*Usuario no existe*/
            {
                lblError.Visible = true;
                lblError.Text = "Nombre de usuario y/o Password incorrectos";
                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje(' Nombre de usuario y/o contraseña incorrecta(s).', 'error'))</script>");
            }
            else
            {
                if (usuarioSession.Estado == "A")
                { 
                    if (usuarioSession.Password != password)
                    {
                        ActualizaErrorLogin();
                        int cuenta = usuarioSession.LoginErrorCount + 1;
                        if (cuenta < 4) {                             
                            lblError.Visible = true;                   
                            lblError.Text = "Nombre de usuario y/o Password incorrectos";
                        }
                        else
                        {
                            ModificaEstadoEmpleado();
                            lblError.Visible = true;
                            lblError.Text = "Usted ha sopresado los intentos permitidos y su cuenta ha sido bloqueada. Comuníquese con su Administrador";                
                        }
                    }
                    else
                    {
                        if (usuarioSession.NombreEmpleado.ToString() == nombre && usuarioSession.Password == password)
                        {
                            if (usuarioSession.Tipo == "Usuario")
                            {
                                Session["Usuario"] = usuarioSession;
                                Response.Redirect("Interfaces/RegistroTickets.aspx");

                            } else
                            { 
                            Session["Usuario"] = usuarioSession;
                            Response.Redirect("Interfaces/Bandeja.aspx");
                            }
                        }
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Usted ha sopresado los intentos permitidos y su cuenta ha sido bloqueada. Comuníquese con su Administrador";                
                }
            }
        }

        private void ModificaEstadoEmpleado()
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
             .Create("http://localhost:49760/EmpleadosREST.svc/Usuario/" + txtUsuario.Text);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string ticketJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Empleado usuarioSession = js2.Deserialize<Empleado>(ticketJson2);

            string codigo = usuarioSession.CodEmpleado.ToString();
            //" + contador + "
            //" + codigo + "
            string postdata = "{\"CodEmpleado\":" + codigo + "," +
            "\"Estado\":\"B\"," + 
             "}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:49760/EmpleadosREST.svc/Estado");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string usuarioJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                ticket usuarioCreado = js.Deserialize<ticket>(usuarioJson);

                //ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('Le quedean' + '" + (4 - cuenta) + "' + ' intentos', 'ok'))</script>");
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);

                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('" + mensaje + "', 'error'))</script>");
            }
        }
        
        public void ActualizaErrorLogin()
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
             .Create("http://localhost:49760/EmpleadosREST.svc/Usuario/" + txtUsuario.Text);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string ticketJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Empleado usuarioSession = js2.Deserialize<Empleado>(ticketJson2);

            int cuenta = usuarioSession.LoginErrorCount + 1;
            string contador = (usuarioSession.LoginErrorCount + 1).ToString();
            string codigo = usuarioSession.CodEmpleado.ToString();
            //" + contador + "
            //" + codigo + "
            string postdata = "{\"CodEmpleado\":" + codigo + "," +
            "\"LoginErrorCount\":" + contador + "," + 
             "}";//JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:49760/EmpleadosREST.svc/Contador");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string usuarioJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                ticket usuarioCreado = js.Deserialize<ticket>(usuarioJson);

                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('Le quedean' + '" + (4 - cuenta) + "' + ' intentos', 'ok'))</script>");
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);

                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('" + mensaje + "', 'error'))</script>");
            }
        }
    }
}