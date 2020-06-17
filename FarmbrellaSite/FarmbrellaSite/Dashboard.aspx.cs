using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class Dashboard : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();


        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ID"] != null)
            {
                string display = "";
                dynamic list = client.getAllProduct(0);

                foreach (Product i in list)
                {
                    display += "<tr>";
                    display += $"<td> {i.ProductID} </td>";
                    display += $"<td>  <span>{i.ProductName}</span> </td>";
                    display += $"<td><span>{i.ProuctQty}</span></td>";
                    display += $"<td><a href='delete.aspx?deleteName={i.ProductName}' class='btn btn-primary' style='background:red'>Delete</a></td>";
                    display += "</tr>";

                }

                productTable.InnerHtml = display;
            }
        }

        protected void getUsers_Click(object sender, EventArgs e)
        {

            DateTime theDate = Convert.ToDateTime(inDate.Value);

            int num = client.fetchUsers(theDate);

            numUsers.InnerHtml = Convert.ToString(num);

        }
    }
}