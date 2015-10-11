using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace principal.Interfaces
{
    public partial class MantenimientoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             Empleado usuarioSesion = (Empleado)Session["usuario"];
             if (usuarioSesion == null)
                 Response.Redirect("http://localhost:52320/Login.aspx");
             else
             {
                 string usuarioNombre = usuarioSesion.NombreEmpleado;
                 string usuarioTipo = usuarioSesion.Tipo;
                 string ususarioApellido = usuarioSesion.ApellidoEmpleado;

                 ((Label)Master.FindControl("lblUsuario")).Text = "Usuario: " + usuarioNombre + " " + ususarioApellido;
                 ((Label)Master.FindControl("lblCargo")).Text = "Rol: " + usuarioTipo;
             }           
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Actualiza();
        }
        public void Actualiza()
        {
            string postdata = "{\"NombreEmpleado\":\"" + txt_nombre.Text + "\"," +
            "\"CodEmpleado\":\"" + txt_dni.Text + "\"," +
            "\"ApellidoEmpleado\":\"" + txt_apellido.Text + "\"," +
            "\"CorreoEmpleado\":\"" + txt_correo.Text + "\"," +
            "\"CargoEmpleado\":\"" + txt_cargo.Text + "\"," +
            "\"TelefonoEmpleado\":\"" + txt_telefono.Text + " \"," +
            "\"Password\":\"" + txt_password.Text + " \"," +
            "\"Estado\":\"" + txt_estado.Text + " \"," +
            "\"Tipo\":\"" + txt_tipo.Text + " \"," +
            "\"LoginErrorCount\":" + txt_LoginCountError.Text + "," +
            "\"AreaEmpleado\":\"" + txt_area.Text + "\"}"; //JSON

            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:49760/EmpleadosREST.svc/usuarios");
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

                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('Usuario actualizado exitosamente.', 'ok'))</script>");
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

        protected void btn_cargar_Click(object sender, EventArgs e)
        {
            //http://localhost:49750/EmpleadosREST.svc/Usuarios
            //http://http://54.241.158.243/UsuariosServices/EmpleadosREST.svc/Usuarios/

            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                         .Create("http://localhost:49760/EmpleadosREST.svc/Usuarios/" + txt_dni.Text);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string usuarioJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Empleado usuarioObtenido = js2.Deserialize<Empleado>(usuarioJson2);

            txt_nombre.Text = usuarioObtenido.NombreEmpleado;
            txt_apellido.Text = usuarioObtenido.ApellidoEmpleado;
            txt_cargo.Text = usuarioObtenido.CargoEmpleado;
            txt_correo.Text = usuarioObtenido.CorreoEmpleado;
            txt_telefono.Text = usuarioObtenido.TelefonoEmpleado;
            txt_area.Text = usuarioObtenido.AreaEmpleado;
            txt_estado.Text = usuarioObtenido.Estado;
            txt_tipo.Text = usuarioObtenido.Tipo;
            txt_password.Text = usuarioObtenido.Password;
            txt_LoginCountError.Text = usuarioObtenido.LoginErrorCount.ToString();
        }
    }
}