using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class delete : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ID"] != null && (int)Session["UserType"]==1)
            {
                if (Request.QueryString["deleteName"] != null)
                {
                    client.deleteProduct(Request.QueryString["deleteName"]);
                    Response.Redirect("Dashboard.aspx");
                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}