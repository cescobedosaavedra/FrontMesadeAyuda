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
    public partial class AtencionTickets : System.Web.UI.Page
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

            if (!Page.IsPostBack) {
                string codigo = Request.QueryString["ticket"];
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:58785/GuardaTicketsREST.svc/ticket/" + codigo);
                req.Method = "GET";
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string ticketJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                ticket ticketObtenido = js.Deserialize<ticket>(ticketJson);

                txt_dni.Enabled = false;
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;
                txt_cargo.Enabled = false;
                txt_correo.Enabled = false;
                txt_telefono.Enabled = false;
                txt_area.Enabled = false;
                txt_Numticket.Enabled = false;
                txt_FechaCreacion.Enabled = false;
                txt_estado.Enabled = false;
                txt_Prioridad.Enabled = false;
                txt_asunto.Enabled = false;
                txt_descripcion.Enabled = false;
                txt_Id.Enabled = false;

                string tipo = usuarioSesion.Tipo.ToString();

                if (tipo == "Usuario") { 
                    txt_dni.Text = ticketObtenido.CodEmpleado.ToString();
                    txt_nombre.Text = ticketObtenido.NombreEmpleado;
                    txt_apellido.Text = ticketObtenido.ApellidoEmpleado;
                    txt_cargo.Text = ticketObtenido.CargoEmpleado;
                    txt_correo.Text = ticketObtenido.CorreoEmpleado;
                    txt_telefono.Text = ticketObtenido.TelefonoEmpleado;
                    txt_area.Text = ticketObtenido.AreaEmpleado;
                    txt_Numticket.Text = ticketObtenido.N_ticket.ToString();
                    txt_FechaCreacion.Text = (Convert.ToDateTime(ticketObtenido.F_creacion)).ToString();
                    txt_estado.Text = ticketObtenido.Estado;
                    txt_Prioridad.Text = ticketObtenido.Prioridad;
                    txt_asunto.Text = ticketObtenido.AsuntoTicket;
                    txt_descripcion.Text = ticketObtenido.ObservacionTicket;
                    txt_detalleatencion.Text = ticketObtenido.Obs_atencion;
                    txt_detalleatencion.Enabled = false;
                    txt_Id.Text = ticketObtenido.Id.ToString();
                }
                    if (tipo == "Analista")
                    {
                        txt_dni.Text = ticketObtenido.CodEmpleado.ToString();
                        txt_nombre.Text = ticketObtenido.NombreEmpleado;
                        txt_apellido.Text = ticketObtenido.ApellidoEmpleado;
                        txt_cargo.Text = ticketObtenido.CargoEmpleado;
                        txt_correo.Text = ticketObtenido.CorreoEmpleado;
                        txt_telefono.Text = ticketObtenido.TelefonoEmpleado;
                        txt_area.Text = ticketObtenido.AreaEmpleado;
                        txt_Numticket.Text = ticketObtenido.N_ticket.ToString();
                        txt_FechaCreacion.Text = (Convert.ToDateTime(ticketObtenido.F_creacion)).ToString();
                        txt_estado.Text = ticketObtenido.Estado;
                        txt_Prioridad.Text = ticketObtenido.Prioridad;
                        txt_asunto.Text = ticketObtenido.AsuntoTicket;
                        txt_descripcion.Text = ticketObtenido.ObservacionTicket;
                        txt_detalleatencion.Text = ticketObtenido.Obs_atencion;
                        txt_detalleatencion.Enabled = true;
                        txt_Id.Text = ticketObtenido.Id.ToString();
                    }

                        if (ticketObtenido != null)
                        {
                            txt_dni.Text = ticketObtenido.CodEmpleado.ToString();
                            txt_nombre.Text = ticketObtenido.NombreEmpleado;
                            txt_apellido.Text = ticketObtenido.ApellidoEmpleado;
                            txt_cargo.Text = ticketObtenido.CargoEmpleado;
                            txt_correo.Text = ticketObtenido.CorreoEmpleado;
                            txt_telefono.Text = ticketObtenido.TelefonoEmpleado;
                            txt_area.Text = ticketObtenido.AreaEmpleado;
                            txt_Numticket.Text = ticketObtenido.N_ticket.ToString();
                            txt_FechaCreacion.Text = (Convert.ToDateTime(ticketObtenido.F_creacion)).ToString();
                            txt_estado.Text = ticketObtenido.Estado;
                            txt_Prioridad.Text = ticketObtenido.Prioridad;
                            txt_asunto.Text = ticketObtenido.AsuntoTicket;
                            txt_descripcion.Text = ticketObtenido.ObservacionTicket;
                            txt_detalleatencion.Text = ticketObtenido.Obs_atencion;
                            txt_Id.Text = ticketObtenido.Id.ToString();
                        }
             }
        }
        protected void btn_cargar_Click(object sender, EventArgs e)
        {
            //http://localhost:49750/EmpleadosREST.svc/Usuarios
            //http://http://54.241.158.243/UsuariosServices/EmpleadosREST.svc/Usuarios/

            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                         .Create("http://localhost:49750/EmpleadosREST.svc/Usuarios/" + txt_dni.Text);
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
            
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Actualiza();
        }

        public void Actualiza()
        {
            
            string postdata = "{\"Estado\":\"" + comb_estado.SelectedItem.Value + "\"," +
                "\"Obs_atencion\":\"" + txt_detalleatencion.Text + "\"," +
            "\"Id\":\"" + txt_Id.Text  + "\" }"; //JSON

            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:58785/GuardaTicketsREST.svc/ticket");
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

                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "<script>$('#mensaje').html(GenerarMensaje('Registro actualizado exitosamente.', 'ok'))</script>");
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