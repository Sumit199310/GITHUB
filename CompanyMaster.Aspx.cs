using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace COMPANYPROJECT
{
    public partial class CompanyMaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["comcon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    TextBox1.Focus();
                   
                }
            }
            catch (Exception ex)
            {


            }

        }

        protected void BTNSUBMIT_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("company_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NAME", TextBox1.Text);
            cmd.Parameters.AddWithValue("@COMPANY_ID", "");
            cmd.Parameters.AddWithValue("@FILENAME", "");
            cmd.Parameters.AddWithValue("@TYPE", "INSERTCOMPANY");

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label2.Text = "COMPANY ADDED SUCCESSFULLY";
        }

        protected void BTNUPLOAD_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                SqlCommand cmd = new SqlCommand("company_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string imgfile = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/img/") + imgfile);
                cmd.Parameters.AddWithValue("@NAME", "");
                //cmd.Parameters.AddWithValue("@STATUS", "");
                cmd.Parameters.AddWithValue("@COMPANY_ID", "");

                cmd.Parameters.AddWithValue("@FILENAME", imgfile);

                cmd.Parameters.AddWithValue("@TYPE", "INSERTFILE");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Label2.Text = "FILE UPLOADED";
            }         

        }
    }
}