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
using System.Diagnostics;
namespace LTRS
{
    public partial class Welcome : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        DataSet dslogin = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["UserID"] != null && Session["UserID"].ToString() != "")
            {
                dslogin = loginDA.FetchFirstname(Convert.ToInt32(Session["UserID"].ToString()));
                if (dslogin != null && dslogin.Tables[0].Rows.Count > 0)
                {
                    string FNAME = dslogin.Tables[0].Rows[0]["FIRST_NAME"].ToString();
                    string type = dslogin.Tables[0].Rows[0]["USER_TYPE"].ToString();
                    lblusermessage.InnerHtml = FNAME;
                    lbltype.InnerHtml = "( " +type+" )";
                    
                }
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