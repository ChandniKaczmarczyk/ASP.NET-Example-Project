using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

using System.Configuration;
using System.Data.SqlClient;
using LTRS.DataAccess;
using System.Data;
using System.Diagnostics;



namespace LTRS
{
    public partial class ViewProerty : System.Web.UI.Page
    {
        PropertyDA propertyda = new PropertyDA();
        DataSet dsrequestproperty = null;

        RequestPropertyDA requestpropertyDA = new RequestPropertyDA();
        DataSet ds = null;
        DataSet dslandlord = null;
        DataSet dstenant = null;
        DataSet checktenant = null;
        LoginDA LoginDA = new LoginDA();
        DataSet dsproperty = null;

        protected void Page_Load(object sender, EventArgs e)
        {



            if (Session["UserID"] == null || Session["UserID"].ToString() == "")
            {
                lblmessage.InnerText = "Please Login to Request Property.";
                divpropertylisting.Attributes.Add("style", "display:none");
                Repeater1.Visible = false;
            }
            else
            {

                checktenant = LoginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));
                string usertype = checktenant.Tables[0].Rows[0]["USER_TYPE"].ToString();
                if (usertype == "Tenant")
                {
                    divpropertylisting.Attributes.Add("style", "display");
                    Repeater1.Visible = true;
                    bindproperty();
                }
                else if (usertype == "Admin")
                {
                    divpropertylisting.Attributes.Add("style", "display:none");
                    Repeater1.Visible = false;
                    lblmessage.InnerText = "You cannot Request property because you are a Database Admin.";
                }
                else
                {
                    divpropertylisting.Attributes.Add("style", "display:none");
                    Repeater1.Visible = false;
                    lblmessage.InnerText = "You cannot Request property because you are a landlord.";
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

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            //foreach (RepeaterItem item in Repeater1.Items)
            //{
            //    Label lblimagepath = (Label)item.FindControl("lblimagepath");
            //    Label lblpropertyid = (Label)item.FindControl("lblpropertyid");
            //    Image imageproperty = (Image)item.FindControl("imageproperty");
            //    imageproperty.ImageUrl = "~/PropertyPhotos/" + lblpropertyid.Text + "/" + lblimagepath.Text;
            //}
        }

        private static void SubmitMailMessage(string from, string to, string subject, string body, bool IsHTML)
        {
            MailMessage tMailMessage = new MailMessage();
            tMailMessage.From = new MailAddress(from);
            tMailMessage.To.Add(new MailAddress(to));
            tMailMessage.Subject = subject;
            tMailMessage.Body = body;
            tMailMessage.IsBodyHtml = IsHTML;
            tMailMessage.Priority = MailPriority.Normal;
            tMailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            tMailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            SmtpClient tSmtpClient = new SmtpClient("smtp.gmail.com", 587);
            tSmtpClient.EnableSsl = true;
            tSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            tSmtpClient.UseDefaultCredentials = false;
            tSmtpClient.Credentials = new System.Net.NetworkCredential("ltrsmail.2017@gmail.com", "ltrs2017");
            tSmtpClient.Send(tMailMessage);

        }


        protected void btnRequestProperty_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnRequestProperty = (Button)sender;
                RepeaterItem repeateritem = (RepeaterItem)btnRequestProperty.NamingContainer;
                Label lblpropertyid = (Label)repeateritem.FindControl("lblpropertyid");
                Label hflandlorduserid = (Label)repeateritem.FindControl("hflandlorduserid");
                Label lblownername = (Label)repeateritem.FindControl("lblownername");
                dsrequestproperty = propertyda.insertrequestpropertydetail(Convert.ToInt32(lblpropertyid.Text), Convert.ToInt32(Session["UserID"]), Convert.ToInt32(hflandlorduserid.Text));


                if (dsrequestproperty != null && dsrequestproperty.Tables[0].Rows.Count > 0)
                {

                    if (dsrequestproperty.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                    {


                        string _subject = "Property Requested";
                        string _body = "Hello,";

                        //Fetch landlord emailid
                        string landlordemail = string.Empty;
                        string tenantemail = string.Empty;
                        dslandlord = requestpropertyDA.FetchEmailaddressforproperty(Convert.ToInt32(hflandlorduserid.Text));
                        if (dslandlord.Tables[0].Rows.Count > 0)
                        {
                            landlordemail = dslandlord.Tables[0].Rows[0]["RECOVERY_EMAIL"].ToString();

                            dstenant = requestpropertyDA.FetchEmailaddressforproperty(Convert.ToInt32(Session["UserID"]));

                            if (dstenant.Tables[0].Rows.Count > 0)
                            {
                                tenantemail = dstenant.Tables[0].Rows[0]["RECOVERY_EMAIL"].ToString();
                                string landlordirstname = dstenant.Tables[0].Rows[0]["FIRST_NAME"].ToString();

                                _body = _body + "<br/<br/><br/>There is a request for your property from " + landlordirstname + ".<br/><br/<br/><br/>Login to your account and check the my profile section to see the request.<br/><br/<br/><br/>Thanks.";

                                SubmitMailMessage(tenantemail, landlordemail, _subject, _body, true);
                                btnRequestProperty.Text = "Requested.";
                                btnRequestProperty.Enabled = false;
                                lblvalidation.Text = "Property Requested Successfully.";
                            }
                           

                        }
                        else
                        {
                            btnRequestProperty.Text = "This Property Already Requested";
                        }




                        //btnRequestProperty.Text = "Property Requested";

                    }
                    else
                    {
                        btnRequestProperty.Text = "This Property Already Requested.";
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
               
            }
        }



        protected void bindproperty()
        {
            dsproperty = propertyda.ViewAllProperty();
            if (dsproperty != null && dsproperty.Tables[0].Rows.Count > 0)
            {
                Repeater1.DataSource = dsproperty;
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = null;
                Repeater1.DataBind();
                lblmessage.InnerHtml = "No Property Data Found";
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