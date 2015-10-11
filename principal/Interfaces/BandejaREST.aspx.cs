
using principal.RegistroTicketsServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Http;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace principal
{
    public partial class BandejaREST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }



        protected void btn_listar_Click(object sender, EventArgs e)
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                   .Create("http://localhost:58785/GuardaTicketsREST.svc/tickets");
            req2.Method = "LIST";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string usuarioJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            List<ticket> usuarioObtenido = js2.Deserialize<List<ticket>>(usuarioJson2);

           
            //gridBandeja_tickets.DataSource = usuarioObtenido;
            //gridBandeja_tickets.DataBind();
        }
    }
}