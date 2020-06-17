using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class TransactionsHistory : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ID"] != null)
            {
                String display = "";
                int ID = Convert.ToInt32(Session["ID"]);

                dynamic invoiceList = client.getAllInvoices(ID);

                display += "<tr>";
                display += "<th>User</th>";
                display += "<th>Invoice ID</th>";
                display += "<th>Date</th>";
                display += "<th>View Invoice</th>";
                display += "</tr>";
               
                foreach (InvoiceClass i in invoiceList)
                {
                    display += "<tr>";
                    display += $"<td>{i.user}</td>";
                    display += $"<td>{i.InvoiceID}</td>";
                    display += $"<td>{i.day}</td>";
                    display += $"<td><a href='invoice.aspx?viewInvoice={i.InvoiceID}' class='btn btn-primary'>View</a></td>";
                    display += "</tr>";
                }
               


                history.InnerHtml = display;
            }
           

        }
    }
}