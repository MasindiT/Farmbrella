using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
	public partial class addBlog : System.Web.UI.Page
	{
		Service1Client client = new Service1Client();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void BtnSend_Click(object sender, EventArgs e)
		{
			if(!subject.Value.Equals(""))
			{
				CBlog newBlog = new CBlog
				{
					subject = subject.Value,
					publisher = publisher.Value,
					content = content.Value,
					image = image.Value,
					date = Convert.ToDateTime(date.Value)
				};

				if(client.AddBlog(newBlog) == 1)
				{
					Response.Redirect("Dashboard.aspx");
				}
			}
            else
            {
                Response.Redirect("addBlog.aspx");
            }

			subject.Value = "";
			publisher.Value = "";
			content.Value = "";
			image.Value = "";
			date.Value = ""; 
		}
	}
}