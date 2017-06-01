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
    public partial class MyProfile : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        RequestPropertyDA requestpropertyDA = new RequestPropertyDA();
        PropertyDA propertyDA = new PropertyDA();
        SubmitRatingDA submitDA = new SubmitRatingDA();
        DataSet dslogin = null;
        DataSet dsrequestedproperty = null;
        DataSet dsupdatestatus = null;
        DataSet dsinfo = null;
        DataSet dspro = null;
        DataSet dsnew = null;
        DataSet dschecklandlord = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null && Session["UserID"].ToString() != "")
            {

                divmyprofile.Attributes.Add("style", "display");
                dschecklandlord = loginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));
                string usertype = dschecklandlord.Tables[0].Rows[0]["USER_TYPE"].ToString();
                if (usertype == "Landlord")
                {
                    BindRepeter();
                    BindRepater2();
                }
                Bindratings();

                dsinfo = loginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));

                if (dsinfo.Tables[0].Rows.Count > 0)
                {
                    lblfirstname.Text = dsinfo.Tables[0].Rows[0]["FIRST_NAME"].ToString();
                    lbllastname.Text = dsinfo.Tables[0].Rows[0]["LAST_NAME"].ToString();
                    lblcontactnumber.Text = dsinfo.Tables[0].Rows[0]["PHONE_NUMBER"].ToString();
                    lblemail.Text = dsinfo.Tables[0].Rows[0]["RECOVERY_EMAIL"].ToString();
                }


            }
            else
            {
                divmyprofile.Attributes.Add("style", "display:none");
                lblinvalidmessage.InnerHtml = "Please Login to see your profile Details.";
                Repeater1.Visible = false;
            }
        }


        protected void btnacceptRequest_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnacceptRequest = (Button)sender;
                RepeaterItem repeateritem = (RepeaterItem)btnacceptRequest.NamingContainer;
                Label lblpropertyid = (Label)repeateritem.FindControl("lblpropertyid");
                HiddenField hftenantuserid = (HiddenField)repeateritem.FindControl("hftenantuserid");
                Label lblownername = (Label)repeateritem.FindControl("lblownername");
                dsupdatestatus = requestpropertyDA.UpdaterequestStatus(Convert.ToInt32(lblpropertyid.Text), Convert.ToInt32(Session["UserID"]), Convert.ToInt32(hftenantuserid.Value), "R");
                lblmessege.InnerHtml = "Property leased Successfully.";
                BindRepeter();
            }
            catch (Exception ex)
            {
            }

        }

        protected void btndeclineRequest_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnacceptRequest = (Button)sender;
                RepeaterItem repeateritem = (RepeaterItem)btnacceptRequest.NamingContainer;
                HiddenField lblpropertyid = (HiddenField)repeateritem.FindControl("lblpropertyid");
                HiddenField hftenantuserid = (HiddenField)repeateritem.FindControl("hftenantuserid");
                Label lblownername = (Label)repeateritem.FindControl("lblownername");
                dsupdatestatus = requestpropertyDA.UpdaterequestStatus(Convert.ToInt32(lblpropertyid.Value), Convert.ToInt32(Session["UserID"]), Convert.ToInt32(hftenantuserid.Value), "D");
                lblmessege.InnerHtml = "Property Declined Successfully.";
                BindRepeter();
            }
            catch (Exception ex)
            {
            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        //BIND REPEATERER

        protected void BindRepeter()
        {
            dsrequestedproperty = requestpropertyDA.fetchrequestedpropertyLandlordside(Convert.ToInt32(Session["UserID"]));
            if (dsrequestedproperty != null && dsrequestedproperty.Tables[0].Rows.Count > 0)
            {
                Repeater1.DataSource = dsrequestedproperty;
                Repeater1.DataBind();


            }
            else
            {
                Repeater1.DataSource = null;
                Repeater1.DataBind();
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
                Page.Response.Redirect("~/ViewProerty.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        protected void BindRepater2()
        {
            dspro = propertyDA.Viewpostedproperty(Convert.ToInt32(Session["UserID"]));
            if (dspro != null && dspro.Tables[0].Rows.Count > 0)
            {
                Repeater2.DataSource = dspro;
                Repeater2.DataBind();

                //int k = 0;
                //foreach (RepeaterItem item in Repeater2.Items)
                //{
                //    Label lblimagepath2 = (Label)item.FindControl("lblimagepath2");
                //    Label lblpropertyid2 = (Label)item.FindControl("lblpropertyid2");
                //    Image imageproperty2 = (Image)item.FindControl("imageproperty2");
                //    imageproperty2.ImageUrl = "~/PropertyPhotos/" + lblpropertyid2.Text + "/" + lblimagepath2.Text;
                //    k++;
                //}

            }
            else
            {
                Repeater2.DataSource = null;
                Repeater2.DataBind();
            }
        }

        protected void Bindratings()
        {
            dsnew = submitDA.FetchViewProfileData(Convert.ToInt32(Session["UserID"]));
            if (dsnew.Tables[0].Rows.Count > 0 && dsnew != null)
            {
                Repeater3.DataSource = dsnew;
                Repeater3.DataBind();

                int k = 0;

                foreach (RepeaterItem item in Repeater3.Items)
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
                Repeater3.DataSource = null;
                Repeater3.DataBind();
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

        protected void btnEditproperty_Click(object sender, EventArgs e)
        {
            Button btnEditproperty = (Button)sender;
            RepeaterItem repeateritem = (RepeaterItem)btnEditproperty.NamingContainer;
            Label lblpropertyid2 = (Label)repeateritem.FindControl("lblpropertyid2");
            Response.Redirect("postproperty.aspx?PropertyId="+lblpropertyid2.Text);
        }

        protected void btnDeleteprop_Click(object sender, EventArgs e)
        {
            DataSet dsdelete = null;
            Button btnEditproperty = (Button)sender;
            RepeaterItem repeateritem = (RepeaterItem)btnEditproperty.NamingContainer;
            Label lblpropertyid2 = (Label)repeateritem.FindControl("lblpropertyid2");

            if (lblpropertyid2.Text != "" && lblpropertyid2.Text != string.Empty)
            {
                dsdelete = propertyDA.DeleteProperty(Convert.ToInt32(lblpropertyid2.Text));
                lblmessege.InnerHtml = "Property Deleted Successfully";
                BindRepater2();
            }
        }



    }
}