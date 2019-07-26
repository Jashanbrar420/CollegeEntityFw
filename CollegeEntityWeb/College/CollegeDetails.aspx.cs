using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class College_CollegeDetails : System.Web.UI.Page
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
        CollegeMsts msts = new CollegeMsts();
        List<CollegeMst> Collage = msts.FullDetails();
        grdTeacherInfo.DataSource = Collage;
        grdTeacherInfo.DataBind();
    }

    protected void btnCreateAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/College/CollegeCreate", false);
    }

    protected void makelink_delete(object sender, EventArgs e)
    {
        string strparm = (sender as ImageButton).CommandArgument;

        CollegeMsts msts = new CollegeMsts();
        String strerr = msts.DeleteColl(Convert.ToInt32(strparm));
        BindGridView();

    }

    protected void makelink_edit(object sender, EventArgs e)
    {
        string strparm = (sender as ImageButton).CommandArgument;
        Response.Redirect("CollegeEdit?EID=" + strparm);
    }
}