using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using principal.ServiceRefUser;
using principal.ServiceEstadoPrioridad;
using principal.RegistroTicketsServices;

namespace principal
{
    public partial class RegistroTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {                  

        }

        
        

        protected void btn_cargar_Click(object sender, EventArgs e)
        {
            //ServiceRefUser.IEmpleados usuarios = new ServiceRefUser.EmpleadosClient();
            //Empleado empleado = new Empleado();
            //empleado = usuarios.ObtenerEmpleado(int.Parse(txt_dni.Text));
            //txt_nombre.Text = empleado.NombreEmpleado;
            //txt_apellido.Text = empleado.ApellidoEmpleado;
            //txt_cargo.Text = empleado.CargoEmpleado;
            //txt_correo.Text = empleado.CorreoEmpleado;
            //txt_telefono.Text = empleado.TelefonoEmpleado;
            //txt_area.Text = empleado.AreaEmpleado;
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            //ServiceRefUser.IEmpleados usuarios = new ServiceRefUser.EmpleadosClient();
            //Empleado empleado = new Empleado();
            //empleado.CodEmpleado = int.Parse(txt_dni.Text);
            //empleado.NombreEmpleado = txt_nombre.Text;
            //empleado.ApellidoEmpleado = txt_apellido.Text;
            //empleado.AreaEmpleado = txt_area.Text;
            //empleado.CargoEmpleado = txt_cargo.Text;
            //empleado.CorreoEmpleado = txt_correo.Text;
            //empleado.TelefonoEmpleado = txt_telefono.Text;


            //GuardaTicketsClient infoTicket = new GuardaTicketsClient();
            
            GuardaTicket ticket = new GuardaTicket();
            ticket.N_ticket = int.Parse(txt_Numticket.Text.Trim());
            ticket.F_creacion = Convert.ToDateTime(txt_FechaCreacion.Text);
            ticket.Estado = Convert.ToString(txt_nombre.Text.Trim());
            ticket.Prioridad = Convert.ToString(txt_apellido.Text.Trim());
            ticket.CodEmpleado = int.Parse(txt_dni.Text.Trim());
            ticket.NombreEmpleado = Convert.ToString(txt_nombre.Text.Trim());
            ticket.ApellidoEmpleado = Convert.ToString(txt_apellido.Text.Trim());
            ticket.CorreoEmpleado = Convert.ToString(txt_correo.Text.Trim());
            ticket.CargoEmpleado = Convert.ToString(txt_cargo.Text.Trim());
            ticket.TelefonoEmpleado = Convert.ToString(txt_telefono.Text.Trim());
            ticket.AreaEmpleado = Convert.ToString(txt_area.Text.Trim());
            ticket.AsuntoTicket = Convert.ToString(txt_asunto.Text.Trim());
            ticket.ObservacionTicket = Convert.ToString(txt_descripcion.Text.Trim());

            //IGuardaTickets infoTicket = new GuardaTicketsClient();
            //if (infoTicket.InsertarTicket(ticket) > 0)
            //{
            //    lbl_mensaje.Text = "Tickets craeado";

            //}
            
        }



        //protected void comb_estado_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ServiceEstadoPrioridad.IEstadosPrioridad estado = new ServiceEstadoPrioridad.EstadosPrioridadClient();
        //    Estado Estados = new Estado();
        //    int campo = int.Parse(Estados.EstadoTicket);
        //    comb_estado.SelectedItem = int.Parse(campo);
        //}



    }
}