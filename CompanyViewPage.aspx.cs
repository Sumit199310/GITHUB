using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace COMPANYPROJECT
{
    public partial class CompanyViewPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["comcon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    SqlCommand cmd = new SqlCommand("select ID,NAME from CompanyMaster", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    con.Close();

                }
            }
            catch (Exception ex)
            {

            }

        }

        protected void Btnshow_Click(object sender, EventArgs e)
        {
            mp1.Show();
        }

        protected void btnaprvdisaprv_Click(object sender, EventArgs e)
        {

        }
    }
}