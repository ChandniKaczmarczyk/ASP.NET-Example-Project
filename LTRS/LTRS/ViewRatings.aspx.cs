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
    public partial class ViewRatings : System.Web.UI.Page
    {
        SubmitRatingDA submitDA = new SubmitRatingDA();
        DataSet dsnew = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserID"].ToString() != "")
            {
                //dsnew = submitDA.FetchViewProfileData(Convert.ToInt32(Session["UserID"]));
               

                dsnew = submitDA.FetchViewRatingsallData();
                if (dsnew.Tables[0].Rows.Count > 0)
                {
                    Repeater1.DataSource = dsnew;
                    Repeater1.DataBind();
                    int k = 0;

                    foreach (RepeaterItem item in Repeater1.Items)
                    {
                        RadioButton RadioButton1 = (RadioButton)item.FindControl("RadioButton1");
                        RadioButton RadioButton2 = (RadioButton)item.FindControl("RadioButton2");
                        RadioButton RadioButton3 = (RadioButton)item.FindControl("RadioButton3");
                        RadioButton RadioButton4 = (RadioButton)item.FindControl("RadioButton4");
                        RadioButton RadioButton5 = (RadioButton)item.FindControl("RadioButton5");
                        if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "")
                        {
                            if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "1")
                            {
                                RadioButton5.Checked = true;
                            }
                            else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "2")
                            {
                                RadioButton4.Checked = true;
                            }
                            else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "3")
                            {
                                RadioButton3.Checked = true;
                            }
                            else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "4")
                            {
                                RadioButton2.Checked = true;
                            }
                            else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "5")
                            {
                                RadioButton1.Checked = true;
                            }

                        }
                        k++;
                    }
                }
                else
                {
                    lblinvalidmessage.InnerHtml = "No Ratings Founds";
                }

            }
            else
            {
                lblinvalidmessage.InnerHtml = "Please login to View Ratings";
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

        protected void btnreset_Click(object sender, EventArgs e)
        {
            
        }
       
    }
    
}
  