using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class FarmMaster : System.Web.UI.MasterPage
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["CartProducts"] == null)
            {
                Session["CartProducts"] = new List<FarmService.ProductsInCart>();

            }

            dashboard.Visible = false;
            drop1.Visible = false;
            drop2.Visible = false;
            visualData.Visible = false;
            addblog.Visible = false;



            if (Session["CartProducts"] != null)
            {
                List<FarmService.ProductsInCart> list = (List<FarmService.ProductsInCart>)Session["CartProducts"];
                items.InnerHtml = Convert.ToString(list.Count);

            }

            if (Session["Name"] != null)
            {
                loginBtn.Visible = false;
                registerBtn.Visible = false;

                personIcon.Visible = true;
                dropdown03.Visible = true;
                farmbrella.Visible = false;

                int ID = Convert.ToInt32(Session["ID"]);
                User info = client.getUser(ID);  
                namesNsurnames.InnerHtml = " "+info.Name.ToUpper() +" "+ info.LastName.ToUpper();



                if (Session["UserType"].Equals(1))
                {
                    farmbrella.InnerHtml = "<a class='navbar-brand' href='Dashboard.aspx'>Farmbrella</a>";
                     home.Visible = false;
                   dashboard.Visible = true;
                    drop1.Visible = true;
                    drop2.Visible = true;
                    contact.Visible = false;
                    blog.Visible = false;
                    about.Visible = false;
                    shop.Visible = false;
                    carts.Visible = false;
                    visualData.Visible = true;
                    transForadmin.Visible = false;
                    footer.Visible = false;
                    addblog.Visible = true;
                   
                }
                
                    
            }
            else
            {
                personIcon.Visible = false;
                farmbrella.Visible = true;
                dropdown03.Visible = false;
                loginBtn.Visible = true;
                registerBtn.Visible = true;
                logout.Visible = false;
            }
        }
    }
}