using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
namespace FarmbrellaSite
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendMessageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Credentials = new NetworkCredential("farmbrellaza@gmail.com", "AdminPassword12345");

                smtp.Send("farmbrellaza@gmail.com", "farmbrellaza@gmail.com", "Sender's Email: " + email.Value, "Sender's Name:" + name.Value + "\n" + "Mail Subject:" + subject.Value + "\n\n" + body.Value);



                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Message sent Successfully');", true);
            }
            catch (Exception ex)
            {
                Response.Write("Message not sent" + ex);
            }


        }


    }
}