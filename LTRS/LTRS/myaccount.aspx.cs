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
    public partial class myaccount : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        RequestPropertyDA requestpropertyDA = new RequestPropertyDA();
        DataSet dslogin = null;
        DataSet dsrequestedproperty = null;
        DataSet dsupdate = null;

        DataSet dsalldata = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserID"].ToString() != "")
            {
                
                
                BindGridviewdata();
               

            }
            else
            {
                lblmessage.InnerHtml = "Please Login to see all your Details.";
                GridView1.Visible = false;
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
                Page.Response.Redirect("~/reports.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/postproperty.aspx");
            }
            catch (Exception ex)
            {
            }
        
       }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtfirstnamedemo.Text = "";
            txtlastnamedemo.Text = "";
            txtphonenumberdemo.Text = "";
            txtemaidemo.Text= "";
            txtsecurityanswer.Text = "";
           
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
        

       

        protected void BindGridviewdata()
        {
            dsalldata = loginDA.Fetchmyaccountdata(Convert.ToInt32(Session["UserID"].ToString()));
          
            if (dsalldata.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = dsalldata;
                GridView1.DataBind();
            }
        }

        protected void btnchange_Click(object sender, EventArgs e)
        {
            lblvalidatemessege.Text = "";
            txtvalidation.Attributes.Add("style", "display");
            Button btnchange = (Button)sender;
            GridViewRow gvrow = (GridViewRow)btnchange.NamingContainer;
            int rowIndex = gvrow.RowIndex;
            Label lblfirstname = (Label)gvrow.FindControl("lblfirstname");
            Label lbllastname = (Label)gvrow.FindControl("lbllastname");
            Label lblphonenumber = (Label)gvrow.FindControl("lblphonenumber");
            Label lblemail = (Label)gvrow.FindControl("lblemail");
            Label lbluserid = (Label)gvrow.FindControl("lbluserid");
            Label lblsecurityanswer = (Label)gvrow.FindControl("lblsecurityanswer");
            txtfirstnamedemo.Text = lblfirstname.Text;
            txtlastnamedemo.Text = lbllastname.Text;
            txtphonenumberdemo.Text = lblphonenumber.Text;
            txtemaidemo.Text = lblemail.Text;
            txtsecurityanswer.Text = lblsecurityanswer.Text;
            hfuserid.Value = lbluserid.Text;
            
        }

        protected void btneditdata_Click(object sender, EventArgs e)
        {
            
            int userid = 0;
            if (hfuserid.Value != null && hfuserid.Value != "")
            {
                userid = Convert.ToInt32(hfuserid.Value);
            }

            dsupdate = loginDA.updateusermaster(userid, txtfirstnamedemo.Text, txtlastnamedemo.Text, txtemaidemo.Text, txtphonenumberdemo.Text, txtsecurityanswer.Text);

            if (dsupdate != null && dsupdate.Tables[0].Rows.Count > 0)
            {
                if (dsupdate.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                {
                    lblvalidatemessege.Text = "Data Changed Successfully.";
                    BindGridviewdata();
                    txtfirstnamedemo.Text = "";
                    txtlastnamedemo.Text = "";
                    txtphonenumberdemo.Text = "";
                    txtemaidemo.Text = "";
                    txtsecurityanswer.Text = "";
                    hfuserid.Value = "";
                    txtvalidation.Attributes.Add("style", "display:none");
                }
            }
            else
            {
                lblvalidatemessege.Text = "You are trying to enter incorrect data.";
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

        //protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    foreach (RepeaterItem item in Repeater1.Items)
        //    {
        //        Label lblimagepath = (Label)item.FindControl("lblimagepath");
        //        HiddenField lblpropertyid = (HiddenField)item.FindControl("lblpropertyid");
        //        Image imageproperty = (Image)item.FindControl("imageproperty");
        //        imageproperty.ImageUrl = "~/PropertyPhotos/" + lblpropertyid.Value + "/" + lblimagepath.Text;
        //    }
        //}
    }
}
