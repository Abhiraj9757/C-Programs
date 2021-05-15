using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace WebApplication23
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(TextBox1.Text);

                var Articles = doc.DocumentNode.SelectNodes("//*[@class ='article-single']");
               
                foreach (var article in Articles)
                {
                    var header = HttpUtility.HtmlDecode(article.SelectSingleNode(".//li[@class='article-header']" + "\n").InnerText);

                    var description = HttpUtility.HtmlDecode(article.SelectSingleNode(".//li[@class='article-copy']").InnerText);
                    Response.Write("<Table>");

                    Response.Write("<td>");
                    Response.Write("Name - " + header);
                    Response.Write("<br />");
                    Response.Write(" Description - " + description);
                    Response.Write("<tr />");
                    Response.Write("<td />");
                    Response.Write("</Table>");
                }
               

            }
            catch (Exception ex) { Response.Write(ex.Message); }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(TextBox1.Text);

            var Articles = doc.DocumentNode.SelectNodes("//*[@class ='article-single']");

            string excelName = "data";

            Response.ClearContent();
            //Response.AddHeader("content-disposition", "attachment;filename=" + excelName + ".xls");
            //Response.AddHeader("Content-Type", "application/vnd.ms-excel");

            Response.ContentType = "application/vnd.ms-excel";

            Response.AppendHeader("content-disposition", "attachment; filename="+excelName+".xls");

            //Header for table records  
            //  
            Response.Write("Header");
            Response.Write("\t");
            Response.Write("Description");
            Response.Write("\t");

            foreach (var article in Articles)
            {
                var header = HttpUtility.HtmlDecode(article.SelectSingleNode(".//li[@class='article-header']" + "\n").InnerText);

                var description = HttpUtility.HtmlDecode(article.SelectSingleNode(".//li[@class='article-copy']").InnerText);

                Response.Write(header);
                Response.Write("\t");
                Response.Write(description);
                Response.Write("\t");
                Response.Write("\n");


            }
            Response.End();

        }
    }
}