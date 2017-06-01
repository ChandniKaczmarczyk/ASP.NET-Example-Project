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
namespace LTRS
{
    public partial class Demo : System.Web.UI.Page
    {
        LoginDA loginDA = new LoginDA();
        DataSet ds = null;
        DataTable dt = null;
        DataSet dsfilter = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bindgridview();
            }
        }

        public void Bindgridview()
        {
            ds = loginDA.Fetchalldata();

            if (ds != null)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bindgridview();
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {

                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[rowIndex];
               // string name = (row.FindControl("txtName") as TextBox).Text;
                TextBox txtid = (TextBox)row.FindControl("txtid");
                TextBox txtfname = (TextBox)row.FindControl("txtfname");
            }
        }

        protected void drpaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow gvRow in GridView1.Rows)
            {

                DropDownList drpaction = (DropDownList)gvRow.FindControl("drpaction");
                TextBox txtid = (TextBox)gvRow.FindControl("txtid");
                string selectvalue = drpaction.SelectedValue;

                if (selectvalue == "Change")
                {
                    lnlbtnedit_Click(sender, e);
                }
            }
           
        }

        protected void lnlbtnedit_Click(object sender, EventArgs e)
        {
            GridView1.EditIndex = 1;
        }
    }
}