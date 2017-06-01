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
    public partial class submitratings : System.Web.UI.Page
    {
        SubmitRatingDA submitratingsDA = new SubmitRatingDA();
        LoginDA loginDA = new LoginDA();
        DataSet ds = null;
        DataSet dsusertype = null;
        DataSet dsrating = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null && Session["UserID"].ToString() != "")
                {
                    divsubmitratings.Attributes.Add("style", "display");
                    dsusertype = loginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));
                    if (dsusertype != null && dsusertype.Tables[0].Rows.Count > 0)
                    {
                        string usertype = string.Empty;
                        ViewState["UserType"] = null;
                        ViewState["UserType"] = dsusertype.Tables[0].Rows[0]["USER_TYPE"].ToString();
                        if (ViewState["UserType"].ToString() == "Tenant")
                        {
                            ds = submitratingsDA.FetchRatingDataForTenant(Convert.ToInt32(Session["UserID"]));
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                gridratings.DataSource = ds;
                                gridratings.DataBind();
                            }
                            else
                            {
                                lblinvalidmessage.InnerHtml = "No property found to give ratings.";
                                divsubmitratings.Attributes.Add("style", "display:none");
                            }

                        }
                        else if (ViewState["UserType"].ToString() == "Landlord")
                        {
                            ds = submitratingsDA.FetchRatingDataForLandlord(Convert.ToInt32(Session["UserID"]));
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                gridratings.DataSource = ds;
                                gridratings.DataBind();
                            }
                            else
                            {
                                lblinvalidmessage.InnerHtml = "No property found to give ratings";
                                divsubmitratings.Attributes.Add("style", "display:none");
                            }
                        }
                        else if (ViewState["UserType"].ToString() == "Admin")
                        {
                            lblinvalidmessage.InnerHtml = "You can not submit ratings because you are a Database Admin.";
                            divsubmitratings.Attributes.Add("style", "display:none");
                        }
                        else
                        {
                            lblinvalidmessage.InnerHtml = "No property found to give ratings";
                            divsubmitratings.Attributes.Add("style", "display:none");
                        }

                    }
                }
                else
                {
                    lblinvalidmessage.InnerHtml = "Please login to give ratings.";
                    gridratings.Visible = false;
                    divsubmitratings.Attributes.Add("style", "display:none");

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
            //txtfname.Text = "";
            //txtlname.Text = "";
            //txtaddress.Text = "";
            //txtcity.Text = "";
            //txtstate.Text= "";
            //txtzipcode.Text="";
            //RadioButton1.Checked = false;
            //RadioButton2.Checked = false;
            //RadioButton3.Checked = false;
            //RadioButton4.Checked = false;
            //RadioButton5.Checked = false;
        }


        protected void btnrate_Click(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            GridViewRow Grow = (GridViewRow)btnEdit.NamingContainer;
            Label lblpropertyid = (Label)Grow.FindControl("lblpropertyid");
            Label lblpropertyaddress = (Label)Grow.FindControl("lblpropertyaddress");
            Label lblcity = (Label)Grow.FindControl("lblcity");
            Label lblstate = (Label)Grow.FindControl("lblstate");
            Label lblzipcode = (Label)Grow.FindControl("lblzipcode");
            TextBox txtreviews = (TextBox)Grow.FindControl("txtreviews");
            RadioButton rdbtnrating1 = (RadioButton)Grow.FindControl("rdbtnrating1");
            RadioButton rdbtnrating2 = (RadioButton)Grow.FindControl("rdbtnrating2");
            RadioButton rdbtnrating3 = (RadioButton)Grow.FindControl("rdbtnrating3");
            RadioButton rdbtnrating4 = (RadioButton)Grow.FindControl("rdbtnrating4");
            RadioButton rdbtnrating5 = (RadioButton)Grow.FindControl("rdbtnrating5");
            Label lbllnadlord = (Label)Grow.FindControl("lbllnadlord");
            Label lbltenant = (Label)Grow.FindControl("lbltenant");

            int ratings = 0;
            bool flagcheck = false;
            if (rdbtnrating1.Checked == true)
            {
                ratings = 5;
                flagcheck = true;
            }
            else if (rdbtnrating2.Checked == true)
            {
                ratings = 4;
                flagcheck = true;
            }
            else if (rdbtnrating3.Checked == true)
            {
                ratings = 3;
                flagcheck = true;
            }
            else if (rdbtnrating4.Checked == true)
            {
                ratings = 2;
                flagcheck = true;
            }
            else if (rdbtnrating5.Checked == true)
            {
                ratings = 1;
                flagcheck = true;
            }
            string propertyid = lblpropertyid.Text;
            string propertyaddress = lblpropertyaddress.Text;
            string propertycity = lblcity.Text;
            string RateToUserId = string.Empty;

            if (ViewState["UserType"].ToString() == "Landlord")
            {
                RateToUserId = lbltenant.Text;
            }
            else if (ViewState["UserType"].ToString() == "Tenant")
            {
                RateToUserId = lbllnadlord.Text;
            }

            if (flagcheck == true)
            {
                dsrating = submitratingsDA.INSERT_SUBMIT_RATINGS_DETAILS(0, Convert.ToInt32(Session["UserID"]), Convert.ToInt32(RateToUserId), ratings, txtreviews.Text, propertyaddress, propertycity, lblstate.Text, lblzipcode.Text, Convert.ToInt32(propertyid));

                if (dsrating != null && dsrating.Tables[0].Rows.Count > 0)
                {
                    if (dsrating.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                    {

                        lblvalidationmessage.Text = "Your Ratings and Reviews submitted Successfully";
                    }
                    else if (dsrating.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                    {
                        lblvalidationmessage.Text = "Your Ratings and Reviews updated Successfully.";
                    }
                }
            }
            else
            {
                lblvalidationmessage.Text = "It is required to make a selection to submit ratings.";
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

