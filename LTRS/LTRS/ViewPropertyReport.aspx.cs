using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using LTRS.DataAccess;
using System.Data;
using System.Diagnostics;

namespace LTRS
{
    public partial class ViewPropertyReport : System.Web.UI.Page
    {
        PropertyDA propertyda = new PropertyDA();

        RequestPropertyDA requestpropertyDA = new RequestPropertyDA();
        DataSet ds = null;
        DataSet checktenant = null;
        LoginDA LoginDA = new LoginDA();
        DataSet dsproperty = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null || Session["UserID"].ToString() == "")
            {
                lblmessage.InnerText = "Please Login to View Property Report";
            }
            else
            {

                checktenant = LoginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));
                string usertype = checktenant.Tables[0].Rows[0]["USER_TYPE"].ToString();
                if (usertype == "Tenant" || usertype == "Landlord")
                {
                    divpropertygrid.Attributes.Add("style", "display");
                    //Repeater1.Visible = true;
                  
                    BindGridviewpropety();
                }
                else if (usertype == "Admin")
                {
                    //divpropertylisting.Attributes.Add("style", "display");
                    //Repeater1.Visible = true;
                    lblmessage.InnerText = "You cannot view property report because you are a Databse Admin";
                }
                //else
                //{
                //    divpropertylisting.Attributes.Add("style", "display:none");
                //    Repeater1.Visible = false;
                //    lblmessage.InnerText = "You cannot view property because you are a landlord";
                //}
            }
        }


        protected void btnhome_Click(object sender, EventArgs e)
        {
            try
            {
                Session["UserID"] = null;
                Page.Response.Redirect("~/index.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/postproperty.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/registration.aspx");
            }
            catch (Exception ex)
            {
            }
        }
        protected void btnexit_Click(object sender, EventArgs e)
        {
            Session["UserID"] = null;
            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "iexplore" || s == "iexplorer" || s == "chrome" || s == "firefox")
                        process.Kill();
                }
            }
        }
        protected void BindGridviewpropety()
        {
            dsproperty = propertyda.ViewAllProperty();
            if (dsproperty != null && dsproperty.Tables[0].Rows.Count > 0)
            {
                gridproperty.DataSource = dsproperty;
                gridproperty.DataBind();
            }
            else
            {
                gridproperty.DataSource = null;
                gridproperty.DataBind();
                lblmessage.InnerHtml = "No Property Report Found";
            }

        }
    }
}