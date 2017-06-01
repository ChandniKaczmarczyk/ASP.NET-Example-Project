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
    public partial class registration : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        DataSet dsregister = null;
        string usertype = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            usertype = Request.QueryString["User"];

            if (usertype == "DBA")
            {
                dba1.Attributes.Add("style", "display");
                dba2.Attributes.Add("style", "display");
                divusertype.Attributes.Add("style", "display:none");
                divusertype1.Attributes.Add("style", "display:none");

            }
            else
            {
                dba1.Attributes.Add("style", "display:none");
                dba2.Attributes.Add("style", "display:none");
                divusertype.Attributes.Add("style", "display");
                divusertype1.Attributes.Add("style", "display");
            }
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtphoneno.MaxLength == 10)
                {
                    string landlordtenant = "";


                    if (rdblandlord.Checked == true)
                    {
                        landlordtenant = "Landlord";

                    }
                    else if (rdbtenant.Checked == true)
                    {
                        landlordtenant = "Tenant";
                    }
                    else
                    {
                        landlordtenant = "Admin";
                    }
                    //dsregister = loginDA.InsertregistrationDetailsAdmin(txtfirstname.Text, txtlastname.Text, txtusername.Text, txtpassword.Text, txtphoneno.Text, txtaddress.Text, txtcity.Text, txtstate.Text, txtzipcode.Text, txtemail.Text, TextBox1.Text,lblsecurity.Text,txtanswer.Text,landlordtenant);

                    //dsregister = loginDA.InsertregistrationDetails(txtfirstname.Text, txtlastname.Text, txtusername.Text, txtpassword.Text, txtphoneno.Text, txtaddress.Text, txtcity.Text, txtstate.Text, txtzipcode.Text, txtemail.Text);

                    dsregister = loginDA.InsertregistrationDetailsAdmin(txtfirstname.Text, txtlastname.Text, txtusername.Text, txtpassword.Text, txtphoneno.Text,txtemail.Text, TextBox1.Text, lblsecurity.Text, txtanswer.Text, landlordtenant);
                    if (dsregister.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                    {
                        lblmessage.InnerHtml = "Registration Completed Successfully.";
                        txtfirstname.Text = "";
                        txtlastname.Text = "";
                        txtemail.Text = "";
                        txtpassword.Text = "";
                        txtphoneno.Text = "";
                        //txtaddress.Text = "";
                        //txtcity.Text = "";
                        //txtstate.Text = "";
                        //txtzipcode.Text = "";
                        txtusername.Text = "";
                        txtanswer.Text = "";
                        TextBox1.Text = "";
                        rdbtenant.Checked = false;
                        rdblandlord.Checked = false;
                    }
                    else
                    {
                        lblmessage.InnerHtml = "This User id is already exist. Please try again";
                        txtusername.Text = "";
                        txtpassword.Text = "";
                    }
                }
                else
                {
                    lblmessage.InnerHtml = "Your contact number should be of 10 digits";
                }
            }
            catch (Exception ex)
            {
                lblmessage.InnerHtml = "This User id is already exist. Please try again";
                txtusername.Text = "";
                txtpassword.Text = "";
            }
            finally
            {

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
                Page.Response.Redirect("~/submitratings.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/login.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            TextBox1.Text = "";
            txtemail.Text = "";
            txtphoneno.Text = "";
            //txtaddress.Text = "";
            //txtcity.Text = "";
            //txtstate.Text = "";
            //txtzipcode.Text = "";
            txtanswer.Text = "";
            lblmessage.InnerHtml = "";
            rdblandlord.Checked = false;
            rdbtenant.Checked = false;
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
