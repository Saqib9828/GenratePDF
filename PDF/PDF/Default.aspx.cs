using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace PDF
{
    public partial class _Default : System.Web.UI.Page
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            string namel = ("select name from pdf  where sr_no=1");
            SqlCommand cmdl = new SqlCommand(namel, sqlcon);
            SqlDataReader sdrl = cmdl.ExecuteReader();

            while (sdrl.Read())
            {
                Label1.Text = sdrl["name"].ToString();
            }
            sqlcon.Close();

            sqlcon.Open();
            string classl = ("select class from pdf  where sr_no=1");
            SqlCommand cmdclassl = new SqlCommand(classl, sqlcon);
            SqlDataReader sdrclassl = cmdclassl.ExecuteReader();

            while (sdrclassl.Read())
            {
                Label2.Text = sdrclassl["class"].ToString();
            }
            sqlcon.Close();

            sqlcon.Open();
            string dobl = ("select dob from pdf  where sr_no=1");
            SqlCommand cmddobl = new SqlCommand(dobl, sqlcon);
            SqlDataReader cmddoblr = cmddobl.ExecuteReader();

            while (cmddoblr.Read())
            {
                Label3.Text = cmddoblr["dob"].ToString();
            }
            sqlcon.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

            
            
            Rectangle rec = new Rectangle(PageSize.A4);
            string path = @"C:\Users\M. Saqib\Desktop\PDF\Chapter1_Example1.pdf";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document(rec, 36, 72, 108, 180);

            
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.Add(new Paragraph("Registration Form",boldFont));
            string name = "Name- " + Label1.Text;
            string cl = "Class- " + Label2.Text;
            string dob = "Date of Birth- " + Label3.Text;
            doc.Add(new Paragraph(name));
            doc.Add(new Paragraph(cl));
            doc.Add(new Paragraph(dob));
            doc.Close();
        }
    }
}
