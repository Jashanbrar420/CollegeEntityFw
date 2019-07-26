using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CollegeJoining_CJedit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindDrop();
            BindControl();
        }
    }
    private void BindDrop()
    {
        try
        {


            TeacherMsts mst = new TeacherMsts();
            List<TeacherMst> obj = mst.FullDetails();

            ddlTeacher.DataTextField = "FirstName";
            ddlTeacher.DataValueField = "TeacherID";
            ddlTeacher.DataSource = obj;
            ddlTeacher.DataBind();
            ddlTeacher.Items.Insert(0, new ListItem("-Select-", "0"));

            CollegeMsts mst1 = new CollegeMsts();
            List<CollegeMst> obj1 = mst1.FullDetails();

            ddlCollege.DataTextField = "CollegeName";
            ddlCollege.DataValueField = "CollegeID";
            ddlCollege.DataSource = obj1;
            ddlCollege.DataBind();
            ddlCollege.Items.Insert(0, new ListItem("-Select-", "0"));

        }
        catch (Exception ex)
        {

        }
    }
    private void BindControl()
    {
        TeacherCollegeMapps msts = new TeacherCollegeMapps();
        TeacherCollegeMapp collmst = msts.Details(Convert.ToInt32(Request.QueryString["EID"].ToString()));
        ddlCollege.SelectedValue = collmst.CollegeID.ToString();
        ddlTeacher.SelectedValue = collmst.TeacherID.ToString();


    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            TeacherCollegeMapp mst = new TeacherCollegeMapp();

            mst.CollegeID = Convert.ToInt32(ddlCollege.SelectedValue.Trim());
            mst.TeacherID = Convert.ToInt32(ddlTeacher.SelectedValue.Trim());
            mst.Id = Convert.ToInt32(Request.QueryString["EID"].ToString());



            TeacherCollegeMapps Colldata = new TeacherCollegeMapps();
            String strerr = Colldata.EditMapp(mst);
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
        Response.Redirect("CJDetails", false);
    }
}