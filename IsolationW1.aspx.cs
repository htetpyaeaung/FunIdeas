using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Data;
using Antlr.Runtime.Tree;

namespace Assignment1.Net
{
    public partial class IsolationW1 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            DropDownList cID = (DropDownList)Page.Master.FindControl("tbDrop");
            if(cID.SelectedIndex>0)
            {
                labl1.Text = cID.SelectedItem.Text;
                hSR.InnerText = "Search Results For";
            }
            else
            {
                labl1.Text = "";
                hSR.Visible = false;
            }
            

        }
    }
}