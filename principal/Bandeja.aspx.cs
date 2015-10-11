
using principal.RegistroTicketsServices;
using System;
using System.Collections.Generic;
using System.Data;
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
            grid_tickets.DataSource = enlace.ListarTicket();
            grid_tickets.DataBind();
        }
    }
}