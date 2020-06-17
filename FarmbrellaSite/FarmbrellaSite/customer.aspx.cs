using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class customer : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic users = client.getAllUsers();
            string display = "";
            //for each Customer
      
            foreach(User u in users)
            {
               
                display += "<tr>";
                display += $"<td>{u.UserID}</td>";//customer ID
                display += $"<td>{u.Name}</td>";//First Name
                display += $"<td>{u.LastName}</td>";//Last Name
                display += $"<td>{u.Email}</td>";//Email
                if(u.ActiveOrNot == 1)
                {
                    display += $"<td>{"Yes"}</td>";//Email

                }
                else if(u.ActiveOrNot == 0)
                {
                    display += $"<td>{"NO"}</td>";//Email
                }
               
                display += "</tr>";

            }
            getAllCustomers.InnerHtml = display;
            
        }
    }
}