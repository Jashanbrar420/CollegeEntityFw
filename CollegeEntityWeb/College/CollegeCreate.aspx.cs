using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class College_CollegeCreate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindDrop();
        }
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
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            CollegeMst mst = new CollegeMst();

            mst.CollegeName = txtCollege.Text.Trim();
            mst.CollegeDesc = txtDetails.Text.Trim();
          
            mst.StateID = Convert.ToInt32(ddlstate.SelectedValue.Trim());


            CollegeMsts Colldata = new CollegeMsts();
            String strerr = Colldata.CreateColl(mst);
            if (strerr == "0")
            {
                Response.Redirect("~/CollegeJoining/CJDetails", false);
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void btnbak_Click(object sender, EventArgs e)
    {
        Response.Redirect("CollegeDetails", false);
    }
}