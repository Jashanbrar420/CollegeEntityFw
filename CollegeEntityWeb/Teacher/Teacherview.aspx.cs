using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_Teacherview : System.Web.UI.Page
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
        TeacherMst Teacherdata = msts.Details(Convert.ToInt32(Request.QueryString["EID"].ToString()));
        lblName.Text = Teacherdata.FirstName + " " + Teacherdata.MiddleName + " " + Teacherdata.LastName;
        lblemail.Text = Teacherdata.EmailID;
        lblGender.Text = Teacherdata.Gender;
        lblJoinDate.Text = Teacherdata.JoiningDate;
        lblMobile.Text = Teacherdata.MobileNo;
        empImg.ImageUrl = "~/TeacherImages/" + Teacherdata.Image;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeacherDetails");
    }
}