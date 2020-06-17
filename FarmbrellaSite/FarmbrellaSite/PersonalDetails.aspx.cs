using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class profile : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] == null)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    int ID = Convert.ToInt32(Session["ID"]);
                    User info = client.getUser(ID);

                    title.Value = info.Title;
                    name.Value = info.Name;
                    surname.Value = info.LastName;
                    email.Value = info.Email;
                    password.Value = "";
                    passConfirm.Value = "";
                }


            }
        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            if(password.Value.Equals(passConfirm.Value))
            {
                var Personalised = new UserClass
                {
                    userID = Convert.ToInt32(Session["ID"]),
                    Title = title.Value,
                    Name = name.Value,
                    Surname = surname.Value,
                    Password = password.Value

                };
               
                bool submitChanges = client.editUser(Personalised);
                
            }
           

            
        }
    }
}