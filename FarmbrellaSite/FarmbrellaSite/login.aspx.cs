using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class login : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            popUpMessage.Visible = false;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            
 
            try
            {
                int UserExist = client.Login(email.Value, password.Value);

                if (UserExist != -1)
                {
                    User user = client.getUser(UserExist);

                    Session["ID"] = user.UserID;
                    Session["Name"] = user.Name;
                    Session["UserType"] = user.UserType;

                    if (user.UserType.Equals(1))
                    {

                        Response.Redirect("Dashboard.aspx");
                    }
                    else if (user.UserType == 0)
                    {

                        Response.Redirect("shop.aspx");
                    }

                }
                else
                {
                    email.Value = "";
                    password.Value = "";
                    popUpMessage.Value = "Incorrect Password or Email";
                    popUpMessage.Visible = true;
                }
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
            }
            
            
        }
    }
}