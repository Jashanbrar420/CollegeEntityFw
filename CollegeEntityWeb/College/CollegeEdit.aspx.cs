using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class College_CollegeEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindDrop();
            BindControl();
        }
    }
    private void BindControl()
    {
        CollegeMsts msts = new CollegeMsts();
        CollegeMst collmst = msts.Details(Convert.ToInt32(Request.QueryString["EID"].ToString()));
        txtCollName.Text = collmst.CollegeName;
        txtDetails.Text = collmst.CollegeDesc;
        ddlstate.SelectedValue = collmst.StateID.ToString();
  

    }
    private void BindDrop()
    {
        try
        {
          
            StateMsts mst = new StateMsts();
            List<StateMst> obj = mst.FullDetails();

            ddlstate.DataTextField = "State_Name";
            ddlstate.DataValueField = "StateID";
            ddlstate.DataSource = obj;
            ddlstate.DataBind();
            ddlstate.Items.Insert(0, new ListItem("-Select-", "0"));

        }
        catch (Exception ex)
        {

        }
    }

    protected void btnbak_Click(object sender, EventArgs e)
    {
        Response.Redirect("CollegeDetails", false);
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            CollegeMst mst = new CollegeMst();
            mst.CollegeID = Convert.ToInt32(Request.QueryString["EID"].ToString());
            mst.CollegeName = txtCollName.Text.Trim();
            mst.CollegeDesc = txtDetails.Text.Trim();
            mst.StateID = Convert.ToInt32(ddlstate.SelectedValue.Trim());


            CollegeMsts cooldata = new CollegeMsts();
            String strerr = cooldata.EditColl(mst);
            if (strerr == "0")
            {
                Response.Redirect("~/College/CollegeDetails", false);
            }

        }
        catch (Exception ex)
        {

        }
    }
}