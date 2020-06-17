using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FarmbrellaSite.FarmService;

namespace FarmbrellaSite
{
    public partial class download : System.Web.UI.Page
    {
        
       
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ID"] != null && Session["Name"] != null)
            {

                String sb = (String)Session["downloadPdf"];

                

                        //Export HTML String as PDF.
                        System.IO.StringReader sr = new StringReader(sb.ToString());
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                        pdfDoc.Open();
                        htmlparser.Parse(sr);
                        pdfDoc.Close();
                        Response.ContentType = "application/pdf";
                        Response.AddHeader("content-disposition", "attachment;filename=Invoice_" + Session["Name"] + ".pdf");
                        Response.Cache.SetCacheability(HttpCacheability.NoCache);
                        Response.Write(pdfDoc);
                        Response.End();
                      
                        Response.Redirect("invoice.aspx");
            }
        }
    }
}