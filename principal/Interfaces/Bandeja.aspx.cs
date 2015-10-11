using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace principal.Interfaces
{
    public partial class Bandeja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Empleado usuarioSesion = (Empleado)Session["usuario"];
            if (usuarioSesion == null)
                Response.Redirect("http://localhost:52320/Login.aspx");
            else {
                if (usuarioSesion.Tipo != "Administrador")
                    btnUsuarios.Visible = false;
                else {
                    btnUsuarios.Visible = true;
                }
            string usuarioNombre = usuarioSesion.NombreEmpleado;
            string usuarioTipo = usuarioSesion.Tipo;
            string ususarioApellido = usuarioSesion.ApellidoEmpleado;

            ((Label)Master.FindControl("lblUsuario")).Text = "Usuario: " + usuarioNombre + " " + ususarioApellido;
            ((Label)Master.FindControl("lblCargo")).Text = "Rol: " + usuarioTipo;
            }
        }
         
        public void LlenaGrid()
        {
            Empleado usuarioSesion = (Empleado)Session["Usuario"];

            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                .Create("http://localhost:58785/GuardaTicketsREST.svc/tickets");
            req2.Method = "LIST";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string usuarioJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            List<ticket> ticketsObtenido = js2.Deserialize<List<ticket>>(usuarioJson2);
            //Filtro por usuario validando si es administrador
            if (usuarioSesion.Tipo != "Administrador")
            {
                ticketsObtenido = ticketsObtenido.Where(x => x.CodEmpleado == usuarioSesion.CodEmpleado).ToList();
                Grid_tickets.DataSource = ticketsObtenido;
                Grid_tickets.DataBind();
            }
            else
            {
                Grid_tickets.DataSource = ticketsObtenido;
                Grid_tickets.DataBind();
            }
        }
        protected void btn_listar_Click(object sender, EventArgs e)
        {
            LlenaGrid();
        }

        protected void Grid_tickets_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {            
            try
            {
                string codigo = Grid_tickets.DataKeys[e.NewSelectedIndex].Value.ToString();
                Response.Redirect("AtencionTickets.aspx?ticket=" + codigo);
            }
            catch (Exception) { }
        }

        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantenimientoUsuarios.aspx");
        }

        protected void Grid_tickets_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grid_tickets.PageIndex = e.NewPageIndex;
            LlenaGrid();
        }




    }
}