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
    public partial class RegistroTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_FechaCreacion.Text = DateTime.Now.ToString();
            comb_estado.DataValueField = "Pendiente";
            Empleado usuarioSesion = (Empleado)Session["Usuario"];           

            if (usuarioSesion == null)
                Response.Redirect("http://localhost:52320/Login.aspx");
            else
            { 
            string  tipo = usuarioSesion.Tipo.ToString();
                if (tipo == "Administrador" )     
                {
                   DeshabilitaCamposAdm();
                }
                    else {
                   DeshabilitaCamposUser();                    
                         }
                cargaDatos();
                string usuarioNombre = usuarioSesion.NombreEmpleado;
                string ususarioApellido = usuarioSesion.ApellidoEmpleado;
                string usuarioTipo = usuarioSesion.Tipo;
                ((Label)Master.FindControl("lblUsuario")).Text = "Usuario: " + usuarioNombre + " " + ususarioApellido;
                ((Label)Master.FindControl("lblCargo")).Text = "Rol: " + usuarioTipo;
                
            }
        }

        protected void btn_cargar_Click(object sender, EventArgs e)
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                         .Create("http://localhost:49760/EmpleadosREST.svc/Usuarios/" + txt_dni.Text);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string ticketJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Empleado usuarioObtenido = js2.Deserialize<Empleado>(ticketJson2);

            txt_nombre.Text = usuarioObtenido.NombreEmpleado;            
            txt_apellido.Text = usuarioObtenido.ApellidoEmpleado;
            txt_cargo.Text = usuarioObtenido.CargoEmpleado;
            txt_correo.Text = usuarioObtenido.CorreoEmpleado;
            txt_telefono.Text = usuarioObtenido.TelefonoEmpleado;
            txt_area.Text = usuarioObtenido.AreaEmpleado;            
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            if (comb_prioridad.SelectedValue == "Seleccionar")
                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('Debe seleccionar una prioridad', 'error'))</script>");
            else { 
            Guardar();
            }
        }

        public void Guardar()
        {
            string postdata = "{\"F_creacion\":\"" + txt_FechaCreacion.Text + "\"," +
            "\"Estado\":\"" + comb_estado.SelectedItem.Value + "\"," +
            "\"Prioridad\":\"" + comb_prioridad.SelectedItem.Value + "\"," +
            "\"CodEmpleado\":" + txt_dni.Text + "," +
            "\"NombreEmpleado\":\"" + txt_nombre.Text + "\"," +
            "\"ApellidoEmpleado\":\"" + txt_apellido.Text + "\"," +
            "\"CorreoEmpleado\":\"" + txt_correo.Text + "\"," +
            "\"CargoEmpleado\":\"" + txt_cargo.Text + "\"," +
            "\"TelefonoEmpleado\":\"" + txt_telefono.Text + " \"," +
            "\"AreaEmpleado\":\"" + txt_area.Text + "\"," +
            "\"AsuntoTicket\":\"" + txt_asunto.Text + "\"," +
            "\"ObservacionTicket\":\"" + txt_descripcion.Text + "\"," +
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
                string ticketJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                ticket ticketCreado = js.Deserialize<ticket>(ticketJson);

                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('Ticket creado exitosamente', 'ok'))</script>");
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

        public void cargaDatos()
        {
            Empleado usuarioSesion = (Empleado)Session["Usuario"];
            string  tipo = usuarioSesion.Tipo.ToString();
                string codigo = usuarioSesion.CodEmpleado.ToString();
                if (tipo == "Usuario")
                {
                                     
                        //string codigo = Request.QueryString["Usuarios"];
                        HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:49760/EmpleadosREST.svc/Usuarios/" + codigo);
                        req.Method = "GET";
                        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                        StreamReader reader = new StreamReader(res.GetResponseStream());
                        string ticketJson = reader.ReadToEnd();
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        ticket usuarioObtenido = js.Deserialize<ticket>(ticketJson);

                        if (usuarioObtenido != null)
                        {
                            txt_dni.Text = usuarioObtenido.CodEmpleado.ToString();
                            txt_nombre.Text = usuarioObtenido.NombreEmpleado;
                            txt_apellido.Text = usuarioObtenido.ApellidoEmpleado;
                            txt_cargo.Text = usuarioObtenido.CargoEmpleado;
                            txt_correo.Text = usuarioObtenido.CorreoEmpleado;
                            txt_telefono.Text = usuarioObtenido.TelefonoEmpleado;
                            txt_area.Text = usuarioObtenido.AreaEmpleado;                            
                        }                    
                }
        }

        public void DeshabilitaCamposAdm()
        {
            //comb_estado.Enabled = true;
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_cargo.Enabled = false;
            txt_correo.Enabled = false;
            txt_telefono.Enabled = false;
            txt_area.Enabled = false;
            //txt_dni.Enabled = true;
            txt_FechaCreacion.Enabled = false;
        }

        public void DeshabilitaCamposUser()
        {
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_cargo.Enabled = false;
            txt_correo.Enabled = false;
            txt_telefono.Enabled = false;
            txt_area.Enabled = false;
            txt_dni.Enabled = false;
            txt_FechaCreacion.Enabled = false;
            btn_cargar.Enabled = false;
            comb_estado.Enabled = false;
        }
    }
}