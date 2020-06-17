using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class editProduct : System.Web.UI.Page
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
                if (!Session["UserType"].Equals(1))
                {
                    Response.Redirect("index.aspx");
                }
                else
                {
                    string pn = Request.QueryString["pname"];
                    if (pn != null)
                    {
                        if (Session["Edit"] == null)
                        {
                            Session["Edit"] = true;

                            if (!IsPostBack)
                            {
                                ProductClass prod = client.getProduct(pn);

                                pname.Value = prod.name;
                                description.Value = prod.description;
                                qty.Value = Convert.ToString(prod.quantity);
                                ptype.Value = Convert.ToString(prod.type);
                                price.Value = Convert.ToString(prod.price);
                                img.Value = prod.image;
                            }
                        }
                    }
                }
            }
        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            

            if(Session["Edit"] != null)
            {
                ProductClass prod = new ProductClass
                {
                    name = pname.Value,
                    description = description.Value,
                    image = img.Value,
                    price = Convert.ToDouble(price.Value),
                    quantity = Convert.ToInt32(qty.Value),
                    type = Convert.ToInt32(ptype.Value)
                };

                Session["Edit"] = null;

                int edit = client.EditProduct(prod);
                if(edit == 1)
                {
                    Response.Redirect("Dashboard.aspx");
                }
            }
            else
            {
                bool exist = client.Exist(pname.Value);

                if (exist)
                {
                    Response.Redirect("editProduct.aspx?pname=" + pname.Value);
                }
                else
                {
                    try
                    {
                        ProductClass prod = new ProductClass
                        {
                            name = pname.Value,
                            description = description.Value,
                            image = img.Value,
                            price = Convert.ToDouble(price.Value),
                            quantity = Convert.ToInt32(qty.Value),
                            type = Convert.ToInt32(ptype.Value)
                        };

                        int added = client.AddProduct(prod);

                        if (added == 1)
                        {
                            Response.Redirect("Dashboard.aspx");
                        }

                    }
                    catch(Exception ex)
                    {
                        ex.GetBaseException();
                    }


                    

                   
                }

            }
        }
    }
}