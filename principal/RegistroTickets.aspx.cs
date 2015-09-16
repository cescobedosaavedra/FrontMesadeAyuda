using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using principal.ServiceRefUser;

namespace principal
{
    public partial class RegistroTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {                  

        }



        protected void btn_cargar_Click(object sender, EventArgs e)
        {
            ServiceRefUser.IEmpleados usuarios = new ServiceRefUser.EmpleadosClient();
            Empleado empleado = new Empleado();
            empleado = usuarios.ObtenerEmpleado(int.Parse(txt_dni.Text));
            txt_nombre.Text = empleado.NombreEmpleado;
            txt_apellido.Text = empleado.ApellidoEmpleado;
            txt_cargo.Text = empleado.CargoEmpleado;
            txt_correo.Text = empleado.CorreoEmpleado;
            txt_telefono.Text = empleado.TelefonoEmpleado;
            txt_area.Text = empleado.AreaEmpleado;
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            //Aqui irá el codigo de registro de tickets
        }



    }
}