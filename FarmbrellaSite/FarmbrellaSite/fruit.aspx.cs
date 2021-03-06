﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class fruit : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        dynamic list;

        protected void Page_Load(object sender, EventArgs e)
        {

            list = client.getProductType(1);
            DisplayProducts();

            if (Request.QueryString["fruitID"] != null)
            {
                int ID = Convert.ToInt32(Request.QueryString["fruitID"]);
                if (ID.Equals(-100))
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "alertMessage", "notifyUser()", true);
                }
                else
                {
                    AddProdToCart(ID);
                }


            }


        }

        private void DisplayProducts()
        {

            string display = "";
            foreach (Product i in list)
            {

                display += "<div class='col-md-6 col-lg-3 ftco-animate'>";
                display += $"<div class='product' >";
                display += $"<a href='product-single.aspx?ID={i.ProductID}' class='img-prod'><img style='height:190px;width:265px' class='img-fluid' src='{i.ProductImage}' alt='Colorlib Template' id={i.ProductID}>";
                display += "<div class='overlay'></div>";
                display += "</a><div class='text py-3 pb-4 px-3 text-center'>";
                display += $"<h3>{i.ProductName}</h3>";
                display += $"<p class='price'> <span class='price-sale'>R{Math.Round(i.ProductPrice, 2)}</span> </p>";
                display += $"<a href='fruit.aspx?fruitID={i.ProductID}' class='btn btn-primary'>Add To Cart <span><i class='ion-ios-cart'></i></span></a>";
                display += "</div>";
                display += "</div>";
                display += "</a>";
                display += "</div>";


            }

            catalogue.InnerHtml = display;
        }

        private void AddProdToCart(int ID)
        {
            if (Session["CartProducts"] != null)
            {
                List<ProductsInCart> items = (List<ProductsInCart>)Session["CartProducts"];
                Boolean found = false;
                foreach (ProductsInCart pr in items)
                {
                    if (pr.ID == ID)
                    {
                        found = true;
                        ProductClass fetchedProduct = client.getProductByID(ID);
                        if ((pr.Quantity + 1) < fetchedProduct.quantity)
                        {
                            pr.Quantity++;
                            break;
                        }
                        else
                        {
                            Response.Redirect("fruit.aspx?fruitID=" + (-100));
                            break;
                        }

                    }
                }

                if (!found)
                {
                    var newitem = new ProductsInCart
                    {
                        Quantity = 1,
                        ID = ID
                    };

                    items.Add(newitem);

                }

                Response.Redirect($"fruit.aspx?#{ID}");
            }
            else
            {
                Response.Redirect("login.aspx");
            }

        }
    }
}