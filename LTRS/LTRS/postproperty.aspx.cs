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
    public partial class postproperty : System.Web.UI.Page
    {
        DataSet ds = null;
        PropertyDA PropertyDA = new PropertyDA();
        LoginDA LoginDA = new LoginDA();
        DataSet dschecklandlord = null;
        DataSet dsproperty = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null && Session["UserID"].ToString() != "")
                {
                    dschecklandlord = LoginDA.FetchFirstname(Convert.ToInt32(Session["UserID"]));
                    string usertype = dschecklandlord.Tables[0].Rows[0]["USER_TYPE"].ToString();
                    if (usertype == "Landlord")
                    {
                        divproperty.Attributes.Add("style", "display");
                        ViewState["Propertyid"] = Request.QueryString["PropertyId"];
                        if (ViewState["Propertyid"] != null && ViewState["Propertyid"].ToString() != "")
                        {
                            dsproperty = PropertyDA.FetchpropertyIdWise(Convert.ToInt32(ViewState["Propertyid"]));
                            if (dsproperty.Tables[0].Rows.Count > 0 && dsproperty != null)
                            {
                                string propertype = string.Empty;

                                if (dsproperty.Tables[0].Rows[0]["PROPERTY_TYPE"].ToString() == "Apartment")
                                {
                                    propertype = "Apartment";
                                }
                                else if (dsproperty.Tables[0].Rows[0]["PROPERTY_TYPE"].ToString() == "House")
                                {
                                    propertype = "House";
                                }
                                else if (dsproperty.Tables[0].Rows[0]["PROPERTY_TYPE"].ToString() == "Condo")
                                {
                                    propertype = "Condo";
                                }

                                drppropertytype.Value = propertype;
                                txtownername.Text = dsproperty.Tables[0].Rows[0]["OWNER_NAME"].ToString();
                                txtaddress.Text = dsproperty.Tables[0].Rows[0]["PROPERTY_ADDRESS"].ToString();
                                txtcity.Text = dsproperty.Tables[0].Rows[0]["CITY"].ToString();
                                txtstate.Text = dsproperty.Tables[0].Rows[0]["STATE"].ToString();
                                txtzipcode.Text = dsproperty.Tables[0].Rows[0]["ZIPCODE"].ToString();
                                txtdate.Value = dsproperty.Tables[0].Rows[0]["BUILTDATE"].ToString();
                                txtrent.Text = dsproperty.Tables[0].Rows[0]["RENT"].ToString();
                                txtcontactnumber.Text = dsproperty.Tables[0].Rows[0]["CONTACT_NUMBER"].ToString();
                                txtbedbath.Text = dsproperty.Tables[0].Rows[0]["BED_BATH"].ToString();

                            }

                        }


                    }
                    else if (usertype == "Admin")
                    {
                        lblinvalidmessage.InnerHtml = "You cannot post property, because you are a Database Admin.";
                    }
                    else
                    {
                        lblinvalidmessage.InnerHtml = "You cannot post property, because you are a Tenant.";
                    }


                }
                else
                {
                    lblinvalidmessage.InnerHtml = "Please login to post property.";
                    divproperty.Attributes.Add("style", "display:none");
                }
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserID"] != null && Session["UserID"].ToString() != "")
                {


                    if (ViewState["Propertyid"] == null || ViewState["Propertyid"].ToString() == "")
                    {



                        if (fileupload1.HasFile)
                        {

                            string fileExt = System.IO.Path.GetExtension(fileupload1.FileName);

                            if ((fileExt == ".jpg") || (fileExt == ".JPG") || (fileExt == ".jpeg") || (fileExt == ".JPEG") || (fileExt == ".png") || (fileExt == ".PNG"))
                            {
                                ds = PropertyDA.Postpropertyforrent(Convert.ToString(drppropertytype.Value), txtownername.Text, txtcontactnumber.Text, txtaddress.Text, txtcity.Text, txtstate.Text, txtzipcode.Text, txtdate.Value, txtbedbath.Text, "", Convert.ToDouble(txtrent.Text), Convert.ToInt32(Session["UserID"]));

                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    int propertid = Convert.ToInt32(ds.Tables[0].Rows[0]["PROPERTY_ID"]);


                                    //if (!System.IO.Directory.Exists(Server.MapPath("~/PropertyPhotos/" + propertid.ToString() + "/")))
                                    //{
                                    //    System.IO.Directory.CreateDirectory(Server.MapPath("~/PropertyPhotos/" + propertid.ToString() + "/"));
                                    //}

                                    string filename1 = DateTime.Now.ToString("yyyyMMddHHmmssf");
                                    string fileExtension1 = System.IO.Path.GetExtension(fileupload1.FileName).ToLower();
                                    string filenamenew = filename1 + "" + System.IO.Path.GetFileName(fileupload1.PostedFile.FileName);
                                    //string path1 = Server.MapPath("~/PropertyPhotos/" + propertid.ToString() + "/" + filenamenew);
                                    string path1 = Server.MapPath("~/PropertyPhotos/" + filenamenew);
                                    string realpath = "~/PropertyPhotos/" + filenamenew;
                                    fileupload1.SaveAs(path1);
                                    PropertyDA.Updatephoto(propertid, realpath);
                                    lblmessage.InnerHtml = "Your Property posted Successfully.";
                                }
                            }
                            else
                            {
                                lblmessage.InnerHtml = "Please upload only .jpg, .jpeg or .png files.";
                            }
                        }
                        else
                        {
                            lblmessage.InnerHtml = "Please upload property image";
                        }

                    }
                    else
                    {

                        DataSet dswithfile = null;
                        DataSet dsnofile = null;
                        if (fileupload1.HasFile)
                        {

                            string fileExt = System.IO.Path.GetExtension(fileupload1.FileName);

                            if ((fileExt.ToLower() == ".jpg") || (fileExt.ToLower() == ".jpeg") || (fileExt.ToLower() == ".png"))
                            {
                                string filename1 = DateTime.Now.ToString("yyyyMMddHHmmssf");
                                string fileExtension1 = System.IO.Path.GetExtension(fileupload1.FileName).ToLower();
                                string filenamenew = filename1 + "" + System.IO.Path.GetFileName(fileupload1.PostedFile.FileName);
                                string path1 = Server.MapPath("~/PropertyPhotos/" + filenamenew);
                                string realpath = "~/PropertyPhotos/" + filenamenew;
                                fileupload1.SaveAs(path1);
                                dswithfile = PropertyDA.updatepropertywithfile(Convert.ToInt32(ViewState["Propertyid"]), Convert.ToString(drppropertytype.Value), txtownername.Text, txtcontactnumber.Text, txtaddress.Text, txtcity.Text, txtstate.Text, txtzipcode.Text, txtdate.Value, txtbedbath.Text, realpath, Convert.ToDouble(txtrent.Text), Convert.ToInt32(Session["UserID"]));
                                if (dswithfile != null && dswithfile.Tables[0].Rows.Count > 0)
                                {
                                    if (dswithfile.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                                    {
                                        lblmessage.InnerHtml = "Your Property Updated Successfully.";
                                    }
                                }
                            }
                            else
                            {
                                lblmessage.InnerHtml = "Please upload only .jpg, .jpeg or .png files.";
                            }

                        }
                        else
                        {
                            dsnofile = PropertyDA.updatepropertywithoutfile(Convert.ToInt32(ViewState["Propertyid"]), Convert.ToString(drppropertytype.Value), txtownername.Text, txtcontactnumber.Text, txtaddress.Text, txtcity.Text, txtstate.Text, txtzipcode.Text, txtdate.Value, txtbedbath.Text, Convert.ToDouble(txtrent.Text), Convert.ToInt32(Session["UserID"]));
                            if (dsnofile != null && dsnofile.Tables[0].Rows.Count > 0)
                            {
                                if (dsnofile.Tables[0].Rows[0]["COUNT"].ToString() == "0")
                                {
                                    lblmessage.InnerHtml = "Your Property Updated Successfully.";
                                }
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            txtaddress.Text = "";
            txtbedbath.Text = "";
            txtcity.Text = "";
            txtcontactnumber.Text = "";
            txtdate.Value = "";
            txtownername.Text = "";
            txtrent.Text = "";
            txtstate.Text = "";
            txtzipcode.Text = "";
            drppropertytype.SelectedIndex = -1;
            fileupload1.Attributes.Clear();
        }
        protected void btnhome_Click(object sender, EventArgs e)
        {
            try
            {
                //Session["UserID"] = null;
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
                Page.Response.Redirect("~/myaccount.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Redirect("~/submitratings.aspx");
            }
            catch (Exception ex)
            {
            }
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtbedbath.Text = "";
            txtcity.Text = "";
            txtcontactnumber.Text = "";
            txtdate.Value = "";
            txtownername.Text = "";
            txtrent.Text = "";
            txtstate.Text = "";
            txtzipcode.Text = "";
            drppropertytype.SelectedIndex = -1;
            fileupload1.Attributes.Clear();
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

