using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_TeacherDetails : System.Web.UI.Page
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
        TeacherMsts msts = new TeacherMsts();
        List<TeacherMst> Teachers = msts.FullDetails();
        grdTeacherInfo.DataSource = Teachers;
        grdTeacherInfo.DataBind();
    }

    protected void btnCreateTeacher_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Teacher/CreateTeacher", false);
    }

    protected void makelink_delete(object sender, EventArgs e)
    {
        string strparm = (sender as ImageButton).CommandArgument;

        TeacherMsts msts = new TeacherMsts();
        String strerr = msts.DeleteTeacher(Convert.ToInt32(strparm));
        BindGridView();

    }

    protected void makelink_View(object sender, EventArgs e)
    {
        string strparm = (sender as ImageButton).CommandArgument;
        Response.Redirect("Teacherview?EID=" + strparm);
    }

    protected void makelink_edit(object sender, EventArgs e)
    {
        string strparm = (sender as ImageButton).CommandArgument;
        Response.Redirect("TeacherEdit?EID=" + strparm);
    }

    protected void download(object sender, EventArgs e)
    {
        String fil = ((ImageButton)sender).CommandArgument.ToString();
        String lstrFolderPath = Server.MapPath("~/EmpImages/");

        System.IO.FileInfo fileInfo = new System.IO.FileInfo(lstrFolderPath + fil);

        if (fileInfo.Exists)
        {
            Response.AddHeader("Content-Disposition", "attachment;filename=\"" + fileInfo.Name + "\"");
            Response.AddHeader("Content-Length", fileInfo.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.TransmitFile(fileInfo.FullName);
            Response.Flush();
            Response.End();
        }

    }
}