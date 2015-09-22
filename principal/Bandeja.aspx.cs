
using principal.RegistroTicketsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace principal
{
    public partial class Bandeja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_listar_Click(object sender, EventArgs e)
        {
            
            IGuardaTickets enlace = new GuardaTicketsClient();
            //int numeroTicket = int.Parse(txt_numeroTicket.Text);
            GuardaTicket campo = new GuardaTicket();

            campo.CorreoEmpleado = txt_numeroTicket.Text;

            int t = '1';
            //txt_numeroTicket.Text = campo.CorreoEmpleado;
            grid_tickets.DataSource = enlace.ObtenerTicket(t);
            
            //grid_tickets.DataBind();


        }
    }
}