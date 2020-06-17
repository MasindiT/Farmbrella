using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
	public partial class blog : System.Web.UI.Page
	{
		Service1Client client = new Service1Client();
		Blog[] collection;

		protected void Page_Load(object sender, EventArgs e)
		{
            collection = client.GetBlogs();
            string display = "";
            foreach (Blog b in collection)
            {
                display += $"<div class='col-md-12 d-flex ftco-animate'><div class='blog-entry align-self-stretch d-md-flex'><a href = '#' class='block-20' style='background-image: url({b.ContentImage});'>";
                display += "</a><div class='text d-block pl-md-4'>";
                display += $"<div class='meta mb-3'><div><a href = '#' >{b.PublishDate}</a></div>";
                display += $"<div>{b.Publisher}</div>";
                display += "<div><a href='#' class='meta-chat'><span class='icon-chat'></span></a></div></div>";
                display += $"<h3 class='heading'>{b.Subject}</h3>";
                display += $"<p>{b.Content}</p>";
                display += "</div></div></div></div>";
            }

            post.InnerHtml = display;
        }
    }
}