using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using principal.ServiceRefUser;
using principal.ServiceEstadoPrioridad;
using principal.RegistroTicketsServices;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;



namespace principal
{
    public partial class RegistroTicketsREST : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

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
            //}
                
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Guardar();
        }


        public void Guardar()
          
         {
                string postdata = "{\"Codigo\":1," +
                "\"N_ticket\": 1234," +
                "\"F_creacion\":\"" + DateTime.Now.ToString() + "\"," +
                "\"Estado\":\"Pendiente\"," +
                "\"Prioridad\":\"Alta\"," +
                "\"CodEmpleado\":\"12345," +
                "\"NombreEmpleado\":\"yyyyyyy\"," +
                "\"ApellidoEmpleado\":\"ttttt\"," +
                "\"CorreoEmpleado\":\"vvvvvvvv\"," +
                "\"CargoEmpleado\":\"qqqqqqqqqqq\"," +
                "\"TelefonoEmpleado\":\"8787878\"," +
                "\"AreaEmpleado\":\"casa\"," +
                "\"AsuntoTicket\":\"pcpcpcpcpcc\"," +
                "\"ObservacionTicket\":\"ppapapapapapapapa\"," +
                "\"Nombre\":\"aaa\" }"; //JSON

            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:58785/GuardaTicketsREST.svc/ticket1");
              req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string usuarioJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            ticket usuarioCreado = js.Deserialize<ticket>(usuarioJson);
            //lbl_mensaje.Text = usuarioCreado.F_creacion;
            }
    }
    
}

//        string postdata = "{\"n_ticket\":1234," +
//"\"1234\",\"f_creacion\":\"" + DateTime.Now.ToString() + "\"," +
//"\"estado\":\"Pendiente\"," +
//"\"prioridad\":\"Alta\"," +
//"\"codEmpleado\":\"" + txt_dni.Text + "\"," +
//"\"nombreEmpleado\":\"" + txt_nombre.Text + "\"," +
//"\"apellidoEmpleado\":\"" + txt_apellido.Text + "\"," +
//"\"correoEmpleado\":\"" + txt_correo.Text + "\"," +
//"\"cargoEmpleado\":\"" + txt_cargo.Text + "\"," +
//"\"telefonoEmpleado\":\"" + txt_telefono.Text + "\"," +
//"\"areaEmpleado\":\"" + txt_area.Text + "\"," +
//"\"asuntoTicket\":\"" + txt_asunto.Text + "\"," +
//"\"observacionTicket\":\"" + txt_descripcion.Text + "\"}"; //JSON
//string postdata = "{\"n_ticket\":\""+ txt_Numticket.Text + "\",\"f_creacion\":\""+ DateTime.Now.ToString() +"\",\"estado\":\"Pendiente\",\"prioridad\":\"Alta\",\"codEmpleado\":\""+ txt_dni.Text + "\",\"nombreEmpleado\":\""+ txt_nombre.Text + "\",\"apellidoEmpleado\":\""+ txt_apellido.Text + "\",\"correoEmpleado\":\""+ txt_correo.Text + "\",\"cargoEmpleado\":\""+ txt_cargo.Text + "\",\"telefonoEmpleado\":\""+ txt_telefono.Text + "\",\"areaEmpleado\":\""+ txt_area.Text + "\",\"asuntoTicket\":\""+ txt_asunto.Text + "\",\"observacionTicket\":\""+ txt_descripcion.Text + "\"}"; //JSON
