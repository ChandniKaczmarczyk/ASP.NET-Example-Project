using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using LTRS.DataAccess;
using System.Data;
using System.Diagnostics;
namespace LTRS
{
    public partial class contactus : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        DataSet ds = null;

        protected void Page_Load(object sender, EventArgs e)
        {

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
                Page.Response.Redirect("~/index.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/aboutus.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
           phoneno.Text="";
           chkphone.Checked = false;
           chkemail.Checked = false;
           inquiry.InnerHtml = "";
           lblmessage.Text = "";
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            ds = loginDA.Insertcontactdetails(txtfirstname.Text, txtlastname.Text, txtemail.Text, phoneno.Text,inquiry.InnerHtml,chkemail.Checked.ToString(),chkphone.Checked.ToString());
            lblmessage.Text = "Inquiry successfully submitted.We will contact you soon.";
            txtemail.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            phoneno.Text = "";
            chkphone.Checked = false;
            chkemail.Checked = false;
            inquiry.InnerHtml = "";
           
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
