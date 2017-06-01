using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTRS.DataAccess;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Diagnostics;
namespace LTRS
{
    public partial class login : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        DataSet dslogin = null;
        string usertype = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            usertype = Request.QueryString["User"];

            if (usertype == "DBA")
            {
                divDBA.Attributes.Add("style", "display");

            }
            else
            {
                divDBA.Attributes.Add("style", "display:none");
            }
        }
       
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
               
                dslogin = loginDA.Fetchusernamepassword(txtusername.Text, txtpassword.Text);
                if (dslogin != null && dslogin.Tables[0].Rows.Count > 0)
                {
                    lblmessage.InnerHtml = "You are Login Successfully.";
                    Session["UserID"] = dslogin.Tables[0].Rows[0]["USER_ID"].ToString();
                    txtpassword.Text = "";
                    txtusername.Text = "";
                    txtdbapassword.Text = "";
                    //HtmlAnchor mylink = (HtmlAnchor)Page.Master.FindControl("anchorviewratings");
                    //mylink.Visible = false;
                    //HtmlAnchor mylink = (HtmlAnchor)this.Master.FindControl("anchorviewratings");
                    //mylink.Visible = false;

                    
                    Page.Response.Redirect("~/Welcome.aspx");
                   
                }
                else
                {
                    lblmessage.InnerHtml = "Invalid Userid or Password. Please try again";
                    Session["UserID"] = null;
                    txtpassword.Text = "";
                    txtusername.Text = "";
                    txtdbapassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblmessage.InnerHtml = "Invalid Userid or Password. Please try again";
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
                Page.Response.Redirect("~/registration.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/index.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtdbapassword.Text = "";
            lblmessage.InnerText = "";
            
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
    }
}