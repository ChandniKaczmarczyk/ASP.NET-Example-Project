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
    public partial class WebForm2 : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        DataSet dsregister = null;
        DataTable dtdatestamp = null;
        DataTable dtuserstatus = null;
        DataTable dtuserid = null;
        DataTable dtusername = null;
        DataTable dtpassword = null;
        DataTable dtdbapassword = null;
        DataTable dtfirstname = null;
        DataTable dtlastname = null;
        DataTable dtphonenumber = null;
        DataTable dtrecoveryemail = null;
        DataTable dtsecurityanswer = null;
        DataTable dtusertype = null;

        DataSet dsalldata = null;
        DataSet dsupdate = null;
        DataSet dsdelete = null;
        DataSet dsfilter = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    BindDatestamp();
                    Binduserstatus();
                    Binduuserid();
                    Bindusername();
                    Bindfirstname();
                    Bindlastname();
                    Bindphonenumber();
                    Bindrecoveryemail();
                    Bindsecurityanswer();
                    Bindusertype();
                    if (Session["UserID"] != null && Session["UserID"].ToString() != "")
                    {
                        dsregister = loginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));
                        if (dsregister != null && dsregister.Tables[0].Rows.Count > 0)
                        {
                            string password2 = dsregister.Tables[0].Rows[0]["DBA_PASSWORD"].ToString();
                            if (password2 != null && password2 != "")
                            {
                                BindGridviewdata();
                                GridView1.Visible = true;
                            }
                            else
                            {
                                lblmessage.InnerHtml = "Admin rights needed to Update Database";
                                GridView1.Visible = false;

                            }
                        }
                        else
                        {
                            lblmessage.InnerHtml = "Please login as a DBA to Update Database.";
                            GridView1.Visible = false;
                        }
                    }
                    else
                    {
                        lblmessage.InnerHtml = "Please login as a DBA to Update Database.";
                        GridView1.Visible = false;
                    }
                }
            }
            catch (Exception EX)
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
                Page.Response.Redirect("~/aboutus.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/myaccount.aspx");
            }
            catch (Exception ex)
            {
            }
        }



        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }


        protected void BindGridviewdata()
        {
            dsalldata = loginDA.Fetchalldata();
            if (dsalldata.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = dsalldata;
                GridView1.DataBind();
                foreach (GridViewRow row in GridView1.Rows)
                {
                    Label lbluserstatus = (Label)row.FindControl("lbluserstatus");
                    DropDownList drpnewaction = (DropDownList)row.FindControl("drpnewaction");
                    if (lbluserstatus.Text.Trim() == "D")
                    {
                        drpnewaction.Enabled = false;
                        drpnewaction.CssClass = "disblecontrol";
                    }
                }


            }
        }

        protected void BindDatestamp()
        {
            dtdatestamp = loginDA.Fetchalldatadropdown();
            DropDownListdatestamp.DataSource = dtdatestamp;
            DropDownListdatestamp.DataTextField = "DATE_STAMP";
            DropDownListdatestamp.DataValueField = "DATE_STAMP";
            DropDownListdatestamp.DataBind();
        }
        protected void Binduserstatus()
        {
            dtuserstatus = loginDA.Fetchalldatadropdown();
            DropDownListuserstatus.DataSource = dtuserstatus;
            DropDownListuserstatus.DataTextField = "USER_STATUS";
            DropDownListuserstatus.DataValueField = "USER_STATUS";
            DropDownListuserstatus.DataBind();
        }


        protected void Binduuserid()
        {
            dtuserid = loginDA.Fetchalldatadropdown();
            DropDownListuserid.DataSource = dtuserid;
            DropDownListuserid.DataTextField = "USER_ID";
            DropDownListuserid.DataValueField = "USER_ID";
            DropDownListuserid.DataBind();
        }

        protected void Bindusername()
        {
            dtusername = loginDA.Fetchalldatadropdown();
            DropDownListusername.DataSource = dtusername;
            DropDownListusername.DataTextField = "USER_NAME";
            DropDownListusername.DataValueField = "USER_NAME";
            DropDownListusername.DataBind();
        }

        //protected void Bindpassword()
        //{
        //    dtpassword = loginDA.Fetchalldatadropdown();
        //    DropDownListpassword.DataSource = dtpassword;
        //    DropDownListpassword.DataTextField = "PASSWORD";
        //    DropDownListpassword.DataValueField = "PASSWORD";
        //    DropDownListpassword.DataBind();
        //}
        //protected void Binddbapassword()
        //{
        //    dtdbapassword = loginDA.Fetchalldatadropdown();
        //    DropDownListDbaPassword.DataSource = dtdbapassword;
        //    DropDownListDbaPassword.DataTextField = "DBA_PASSWORD";
        //    DropDownListDbaPassword.DataValueField = "DBA_PASSWORD";
        //    DropDownListDbaPassword.DataBind();
        //}

        protected void Bindlastname()
        {
            dtlastname = loginDA.Fetchalldatadropdown();
            DropDownListlastname.DataSource = dtlastname;
            DropDownListlastname.DataTextField = "LAST_NAME";
            DropDownListlastname.DataValueField = "LAST_NAME";
            DropDownListlastname.DataBind();
        }
        protected void Bindphonenumber()
        {
            dtphonenumber = loginDA.Fetchalldatadropdown();
            DropDownListphoneno.DataSource = dtphonenumber;
            DropDownListphoneno.DataTextField = "PHONE_NUMBER";
            DropDownListphoneno.DataValueField = "PHONE_NUMBER";
            DropDownListphoneno.DataBind();
        }
        protected void Bindrecoveryemail()
        {
            dtrecoveryemail = loginDA.Fetchalldatadropdown();
            DropDownListrecoveryemail.DataSource = dtrecoveryemail;
            DropDownListrecoveryemail.DataTextField = "RECOVERY_EMAIL";
            DropDownListrecoveryemail.DataValueField = "RECOVERY_EMAIL";
            DropDownListrecoveryemail.DataBind();
        }
        protected void Bindsecurityanswer()
        {
            dtsecurityanswer = loginDA.Fetchalldatadropdown();
            DropDownListSecurityAns.DataSource = dtsecurityanswer;
            DropDownListSecurityAns.DataTextField = "SECURITY_ANSWER";
            DropDownListSecurityAns.DataValueField = "SECURITY_ANSWER";
            DropDownListSecurityAns.DataBind();
        }
        protected void Bindusertype()
        {
            dtusertype = loginDA.Fetchalldatadropdown();
            DropDownListusertype.DataSource = dtusertype;
            DropDownListusertype.DataTextField = "USER_TYPE";
            DropDownListusertype.DataValueField = "USER_TYPE";
            DropDownListusertype.DataBind();
        }


        protected void Bindfirstname()
        {
            dtfirstname = loginDA.Fetchalldatadropdown();
            DropDownListfirstname.DataSource = dtfirstname;
            DropDownListfirstname.DataTextField = "FIRST_NAME";
            DropDownListfirstname.DataValueField = "FIRST_NAME";
            DropDownListfirstname.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void drpnewaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            GridViewRow row = (GridViewRow)ddl.NamingContainer;
            int rowIndex = row.RowIndex;

            Label lblfirstname = (Label)row.FindControl("lblfirstname");
            Label lbllastname = (Label)row.FindControl("lbllastname");
            Label lblphonenumber = (Label)row.FindControl("lblphonenumber");
            Label lblemail = (Label)row.FindControl("lblemail");
            Label lbluserid = (Label)row.FindControl("lbluserid");
            Label lblsecurityanswer = (Label)row.FindControl("lblsecurityanswer");
            Label lbluserstatus = (Label)row.FindControl("lbluserstatus");
            Label lblusername = (Label)row.FindControl("lblusername");
            Label lblpassword = (Label)row.FindControl("lblpassword");
            Label lbldbapassword = (Label)row.FindControl("lbldbapassword");
            Label lblsecurityque = (Label)row.FindControl("lblsecurityque");
            Label lblusertype = (Label)row.FindControl("lblusertype");

            txtfirstnamedemo.Text = lblfirstname.Text.Trim();
            txtlastnamedemo.Text = lbllastname.Text.Trim();
            txtphonenumberdemo.Text = lblphonenumber.Text.Trim();
            txtemaidemo.Text = lblemail.Text.Trim();
            txtsecurityanswer.Text = lblsecurityanswer.Text.Trim();
            hfuserid.Value = lbluserid.Text.Trim();
            lbluname.Text = lblusername.Text.Trim();
            lblpass1.Text = lblpassword.Text.Trim();
            lblpass2.Text = lbldbapassword.Text.Trim();
            lblque.Text = lblsecurityque.Text.Trim();
            lblutype.Text = lblusertype.Text.Trim();

            lblvalidatemessege.Text = "";
            if (ddl.SelectedValue == "Delete")
            { 
                    int userid = 0;
                    
                    if (hfuserid.Value != null && hfuserid.Value != "")
                    {
                         userid = Convert.ToInt32(hfuserid.Value);
                    }
                    dsdelete = loginDA.deleteusermasterdata(userid);

                    if (dsdelete != null && dsdelete.Tables[0].Rows.Count > 0)
                    {
                        if (dsdelete.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                        {
                            lblvalidatemessege.Text = "Data Deleted Successfully.";
                            BindGridviewdata();
                           
                        }
                    }

            }
            if (ddl.SelectedValue == "Change")
            {
                divchangedata.Attributes.Add("style", "display");
            }
            if (ddl.SelectedValue == "Query")
            {
                divquery.Attributes.Add("style", "display");
            }

        }

        protected void btneditdata_Click(object sender, EventArgs e)
        {
            int userid = 0;
            if (hfuserid.Value != null && hfuserid.Value != "")
            {
                userid = Convert.ToInt32(hfuserid.Value);
            }

           // dsupdate = loginDA.updateusermaster(userid, txtfirstnamedemo.Text, txtlastnamedemo.Text, txtemaidemo.Text, txtphonenumberdemo.Text, txtsecurityanswer.Text);

            dsupdate = loginDA.Insertdatabasechangerecord(txtfirstnamedemo.Text.Trim(), txtlastnamedemo.Text.Trim(),lbluname.Text.Trim(),lblpass1.Text.Trim(),txtphonenumberdemo.Text.Trim(),txtemaidemo.Text.Trim(),lblpass2.Text.Trim(),lblque.Text.Trim(), txtsecurityanswer.Text.Trim(),lblutype.Text.Trim());

            if (dsupdate != null && dsupdate.Tables[0].Rows.Count > 0)
            {
                if (dsupdate.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                {
                    lblvalidatemessege.Text = "Data Changed Successfully.";
                    BindGridviewdata();
                    BindDatestamp();
                    Binduserstatus();
                    Binduuserid();
                    Bindusername();
                    Bindfirstname();
                    Bindlastname();
                    Bindphonenumber();
                    Bindrecoveryemail();
                    Bindsecurityanswer();
                    Bindusertype();
                    txtfirstnamedemo.Text = "";
                    txtlastnamedemo.Text = "";
                    txtphonenumberdemo.Text = "";
                    txtemaidemo.Text = "";
                    txtsecurityanswer.Text = "";
                    hfuserid.Value = "";
                    divchangedata.Attributes.Add("style", "display:none");
                }
            }
            else
            {
                lblvalidatemessege.Text = "You are trying to enter incorrect data.";
            }

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            int userid = 0;
            string fname = "";
            string lname = "";
            string usename = "";
            string email = "";
            string phone = "";
            string answer = "";
            string type = "";
            string status = "";
            DateTime datestemp;
            if (DropDownListuserid.SelectedValue == "%")
            {
                userid = 0;
            }
            else
            {
                userid=Convert.ToInt32(DropDownListuserid.SelectedValue);
            }
            if (DropDownListfirstname.SelectedValue == "%")
            {
                fname = "";
            }
            else
            {
                fname = DropDownListfirstname.SelectedValue;
            }
            if (DropDownListlastname.SelectedValue == "%")
            {
                lname = "";
            }
            else
            {
                lname = DropDownListlastname.SelectedValue;
            }

            if (DropDownListusername.SelectedValue == "%")
            {
                usename = "";
            }
            else
            {
                usename = DropDownListusername.SelectedValue;
            }

            if (DropDownListrecoveryemail.SelectedValue == "%")
            {
                email = "";
            }
            else
            {
                email = DropDownListrecoveryemail.SelectedValue;
            }

            if (DropDownListphoneno.SelectedValue == "%")
            {
                phone = "";
            }
            else
            {
                phone = DropDownListphoneno.SelectedValue;
            }
            if (DropDownListSecurityAns.SelectedValue == "%")
            {
                answer = "";
            }
            else
            {
                answer = DropDownListSecurityAns.SelectedValue;
            }
            if (DropDownListusertype.SelectedValue == "%")
            {
                type = "";
            }
            else
            {
                type = DropDownListusertype.SelectedValue;
            }

            if (DropDownListuserstatus.SelectedValue == "%")
            {
                status = "";
            }
            else
            {
                status = DropDownListuserstatus.SelectedValue.Trim();
            }
            //string MYNEWDate = string.Empty;
            //if (DropDownListdatestamp.SelectedValue != "%")
            //{
            //    datestemp = Convert.ToDateTime(DropDownListdatestamp.SelectedValue);
            //    //DateTime myDateTime = DateTime.Now;
            //    MYNEWDate = datestemp.ToString("yyyy-MM-dd HH:mm:ss:fff");
            //}
            //else
            //{
            //    datestemp = DateTime.Now;
            //    MYNEWDate = datestemp.ToString("yyyy-MM-dd HH:mm:ss:fff");
            //}
            

           // dsfilter = loginDA.fetchreportsbyfilter(userid, DropDownListfirstname.SelectedValue, DropDownListlastname.SelectedValue,DropDownListusername.SelectedValue,DropDownListphoneno.SelectedValue,DropDownListrecoveryemail.SelectedValue,DropDownListSecurityAns.SelectedValue,DropDownListusertype.SelectedValue,DropDownListuserstatus.SelectedValue);

            dsfilter = loginDA.fetchreportsbyfilter(userid, fname, lname, usename, phone, email, answer, type, status);
            
            if (dsfilter.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = dsfilter;
                GridView1.DataBind();
                foreach (GridViewRow row in GridView1.Rows)
                {
                    Label lbluserstatus = (Label)row.FindControl("lbluserstatus");
                    DropDownList drpnewaction = (DropDownList)row.FindControl("drpnewaction");
                    if (lbluserstatus.Text.Trim() == "D")
                    {
                        drpnewaction.Enabled = false;
                        drpnewaction.CssClass = "disblecontrol";
                    }
                }
            }
            else
            {
                BindGridviewdata();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DropDownListuserid.SelectedValue ="%";
            DropDownListfirstname.SelectedValue = "%";
            DropDownListlastname.SelectedValue = "%";
            DropDownListusername.SelectedValue = "%";
            DropDownListdatestamp.SelectedValue = "%";
            DropDownListphoneno.SelectedValue = "%";
            DropDownListSecurityAns.SelectedValue = "%";
            DropDownListrecoveryemail.SelectedValue = "%";
            DropDownListuserstatus.SelectedValue = "%";
            DropDownListusertype.SelectedValue = "%";
            BindGridviewdata();
            txtfirstnamedemo.Text = "";
            txtlastnamedemo.Text = "";
            txtemaidemo.Text = "";
            txtsecurityanswer.Text = "";
            txtphonenumberdemo.Text = "";
            lblvalidatemessege.Text = "";
            lblmessage.InnerHtml = "";       
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
