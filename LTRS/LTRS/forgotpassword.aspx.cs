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
    public partial class forgotpassword : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        DataSet ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string _from = "ltrsmail.2017@gmail.com";
            string _to = txtEmail.Text.Trim();
            string _subject = "Password Recovery";
            string _body = "Hello,";

            ds = loginDA.FetchEmailID(_to);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {

                string emailaddress = ds.Tables[0].Rows[0]["RECOVERY_EMAIL"].ToString();
                string passwordfetch = ds.Tables[0].Rows[0]["PASSWORD"].ToString();
                _body = _body + "<br/<br/>Your password is " + passwordfetch + ".<br/><br/<br/><br/>Thanks.";

                SubmitMailMessage(_from, emailaddress, _subject, _body, true);
                lblMessage.Text = "Password sent to your email address.";
            }

            else
            {
                lblMessage.Text = "Username not found in database";
            }


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
            txtEmail.Text = "";
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


        
        
          

