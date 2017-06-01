using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTRS
{
    public partial class LTRSMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void DropDownList1SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (DropDownList1.SelectedValue == "DBA")
        //    {

        //        Response.Redirect("~/login.aspx?User=" + "DBA");
        //    }
        //    else if (DropDownList1.SelectedValue == "Users")
        //    {
        //        Response.Redirect("~/login.aspx?User=" + "Users");
        //    }

        //}

        //protected void DropDownList2SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (DropDownList2.SelectedValue == "DBA")
        //    {

        //        Response.Redirect("~/registration.aspx?User=" + "DBA");
        //    }
        //    else if (DropDownList2.SelectedValue == "Users")
        //    {
        //        Response.Redirect("~/registration.aspx?User=" + "Users");
        //    }
        //}

        //protected void DropDownList3SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (DropDownList3.SelectedValue == "Update Database")
        //    {
        //        Response.Redirect("~/Reports.aspx");
        //    }

        //}
        //protected void lnkratings_Click(object sender, EventArgs e)
        //{
        //    if (Session["UserID"] != null && Session["UserID"].ToString() != "")
        //    {
        //        Page.Response.Redirect("~/submitratings.aspx");
        //    }
        //    else
        //    {
        //        Page.Response.Redirect("~/Redirectpage.aspx");
        //    }

            //}
            //protected void lnkProperty_Click(object sendr, EventArgs e)
            //{
            //    if (Session["UserID"] != null && Session["UserID"].ToString() != "")
            //    {
            //        Page.Response.Redirect("~/postproperty.aspx");
            //    }
            //    else
            //    {
            //        Page.Response.Redirect("~/Redirectpage.aspx");
            //    }
            //}
            //protected void lnklogout_Click(object sendr, EventArgs e)
            //{
            //    Session["UserID"] = null;
            //    Page.Response.Redirect("~/index.aspx");
            //}
            //protected void lnkmyaccount_Click(object sendr, EventArgs e)
            //{

            //    Page.Response.Redirect("~/myaccount.aspx");

            //}
        }
    }