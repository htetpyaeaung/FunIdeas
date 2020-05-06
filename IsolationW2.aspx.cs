using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment1.Net.Models;

namespace Assignment1.Net
{
    public partial class IsolationW2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList cid = (DropDownList)Page.Master.FindControl("tbDrop");


            using (var db = new FunIdeasEntities())
            {
                if (cid.SelectedIndex > 0) { 
                    var bb = (from gg in db.Ideas
                              where gg.categoryID.ToString().Equals(cid.SelectedItem.Value)
                              select gg).ToList();

                   
                    SDSFunIdea.DataSource = bb;
                    SDSFunIdea.DataBind();
                }
                else
                {
                    var bb = (from gg in db.Ideas
                              select gg).ToList();

                    SDSFunIdea.DataSource = bb;
                    SDSFunIdea.DataBind();
                }
            }
        }

        
    }
}
