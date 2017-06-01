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
    public partial class ViewRatingReport : System.Web.UI.Page
    {
        SubmitRatingDA submitDA = new SubmitRatingDA();
        LoginDA loginDA = new LoginDA();
        DataSet dsnew = null;
        DataSet dschecklandlord = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null && Session["UserID"].ToString() != "")
                {
                    dschecklandlord = loginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));
                    string usertype = dschecklandlord.Tables[0].Rows[0]["USER_TYPE"].ToString();
                    if (usertype == "Landlord" || usertype == "Tenant")
                    {
                        BindRatingGrid();
                    }
                    else
                    {
                        lblinvalidmessage.InnerText = "You can not View Landlord/Tenant Rating Reports as you are a Database Admin.";
                    }
                }
                else
                {
                    lblinvalidmessage.InnerText = "Please Login to View Landlord/Tenant Rating Reports.";
                }
            }

        }

        public void BindRatingGrid()
        {
            dsnew = submitDA.FetchRatingreports();
            if (dsnew != null && dsnew.Tables[0].Rows.Count > 0)
            {
                gridratings.DataSource = dsnew;
                gridratings.DataBind();


                int k = 0;

                foreach (GridViewRow item in gridratings.Rows)
                {
                    RadioButton rdbtnrating1 = (RadioButton)item.FindControl("rdbtnrating1");
                    RadioButton rdbtnrating2 = (RadioButton)item.FindControl("rdbtnrating2");
                    RadioButton rdbtnrating3 = (RadioButton)item.FindControl("rdbtnrating3");
                    RadioButton rdbtnrating4 = (RadioButton)item.FindControl("rdbtnrating4");
                    RadioButton rdbtnrating5 = (RadioButton)item.FindControl("rdbtnrating5");
                    if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "")
                    {
                        if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "1")
                        {
                            rdbtnrating5.Checked = true;
                        }
                        else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "2")
                        {
                            rdbtnrating4.Checked = true;
                        }
                        else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "3")
                        {
                            rdbtnrating3.Checked = true;
                        }
                        else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "4")
                        {
                            rdbtnrating2.Checked = true;
                        }
                        else if (dsnew.Tables[0].Rows[k]["RATINGS"].ToString() != "" && dsnew.Tables[0].Rows[k]["RATINGS"].ToString() == "5")
                        {
                            rdbtnrating1.Checked = true;
                        }

                    }
                    k++;
                }


            }
            else
            {
                lblinvalidmessage.InnerText = "No Landlord/Tenant Rating Reports Found.";
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
    }
}