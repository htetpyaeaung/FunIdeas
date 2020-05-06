using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace Assignment1.Net
{
    public partial class IsolationM : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection d = new SqlConnection(WebConfigurationManager.ConnectionStrings["IdeaDBConnectionString"].ToString());
            {
                d.Open();
                SqlCommand cmd = new SqlCommand("select * from Category", d);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                tbDrop.DataTextField = ds.Tables[0].Columns["name"].ToString();
                tbDrop.DataValueField = ds.Tables[0].Columns["categoryID"].ToString();
                tbDrop.DataSource = ds.Tables[0];
                tbDrop.DataBind();
                tbDrop.Items.Insert(0, new ListItem("Select Category", "0"));
                d.Close();
            }

            this.mvcLink.NavigateUrl = @"/Ideas/Index";

        }

        

        
        
        
    }
}