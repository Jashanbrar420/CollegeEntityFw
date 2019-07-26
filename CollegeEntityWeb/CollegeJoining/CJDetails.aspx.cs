using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CollegeJoining_CJDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindGridView();
        }
    }

    private void BindGridView()
    {
        TeacherCollegeMapps msts = new TeacherCollegeMapps();
        List<TeacherCollegeMapp> mapp = msts.FullDetails();
        grdTeacherInfo.DataSource = mapp;
        grdTeacherInfo.DataBind();
    }

    protected void btnCreateAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/CollegeJoining/CollJoining", false);
    }

    protected void makelink_delete(object sender, EventArgs e)
    {
        string strparm = (sender as ImageButton).CommandArgument;

        TeacherCollegeMapps msts = new TeacherCollegeMapps();
        String strerr = msts.DeleteMapp(Convert.ToInt32(strparm));
        BindGridView();

    }

    protected void makelink_edit(object sender, EventArgs e)
    {
        string strparm = (sender as ImageButton).CommandArgument;
        Response.Redirect("CJEdit?EID=" + strparm);
    }
}