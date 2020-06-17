using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class about : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubcribeBtn_Click(object sender, EventArgs e)
        {
            String subEmail = emailInput.Value;
            Subscriber sub = new Subscriber
            {

                emailAdd = subEmail
            };
            int check = client.AddSubscribe(sub);

            if (check == 1)
            {
                divId.InnerHtml = "Succefully Added";

            }
            else
            {
                divId.InnerHtml = "Email Already Exists";
            }


        }
    }
}