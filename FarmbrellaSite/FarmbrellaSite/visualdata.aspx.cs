using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class visualdata : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        // dynamic users;
        // graph[] theInvoices;
        Product[] Products;

        protected void Page_Load(object sender, EventArgs e)
        {
            // users  = client.getAllUsers();
            // theInvoices = client.getAllInvoicesGraph(10);
            Products = client.getAllProduct(45);
           
            if (!IsPostBack)
                ShowData();
        }

        private void ShowData()
        {
            //pull data from the database data

           
            if (Products != null)
            {


                String chart = "";
                chart = "<canvas id=\"radar-chart\" width=\"50%\" height=\"50\"></canvas>";
                chart += "<script>";
                chart += "new Chart(document.getElementById(\"radar-chart\"), { type: 'radar', data: {labels: [";

                // more detais

                foreach (Product b in Products)
                chart += $"'{b.ProductName}'" + ",";
                chart = chart.Substring(0, chart.Length);

                chart += "],datasets: [{ data: [";

                // get data from database and add to chart
               
                foreach(Product b in Products)
                chart += b.ProuctQty.ToString() + ",";
                chart = chart.Substring(0, chart.Length - 1);
             

                chart += "],label: \"Available Stock\",borderColor: \"#82ae46\",fill: true}"; // Chart color
                chart += "]},options: { title: { display: true,text: 'Veges and Fruits'}}"; // Chart title
                chart += "});";
                chart += "</script>";

                ltChart.Text = chart;
            }
        }
    }
}