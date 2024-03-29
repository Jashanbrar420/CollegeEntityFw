﻿using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_TeacherEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindControl();
        }
    }

    private void BindControl()
    {
        TeacherMsts msts = new TeacherMsts();
        TeacherMst Teachers = msts.Details(Convert.ToInt32(Request.QueryString["EID"].ToString()));
        txtTeachercode.Text = Teachers.Emp_Code;
        txtfirstname.Text = Teachers.FirstName;
        txtmiddlename.Text = Teachers.MiddleName;
        txtlastname.Text = Teachers.LastName;
        txtDATEBIRTH.Text = Teachers.DateOfBirth;
        txtjoiningdate.Text = Teachers.JoiningDate;
        rdlgender.SelectedValue = Teachers.Gender;
        txtemailid.Text = Teachers.EmailID;
        txtmobilenumber.Text = Teachers.MobileNo;
        ViewState["Image"] = Teachers.Image;
    }

    protected void btnEditionTeacher_Click(object sender, EventArgs e)
    {
        try
        {
            TeacherMst mst = new TeacherMst();
            mst.TeacherID = Convert.ToInt32(Request.QueryString["EID"].ToString());
            mst.FirstName = txtfirstname.Text.Trim();
            mst.MiddleName = txtmiddlename.Text.Trim();
            mst.LastName = txtlastname.Text.Trim();
            mst.DateOfBirth = txtDATEBIRTH.Text.Trim();
            mst.JoiningDate = txtjoiningdate.Text.Trim();
            mst.Emp_Code = txtTeachercode.Text.Trim();

            String[] strUpload;
            if (FUpload.HasFile)
            {
                strUpload = Upload(FUpload);
                if (strUpload[0] == "0")
                {
                    mst.Image = strUpload[1];
                }
                else
                {
                    string message = Convert.ToString(strUpload[1]);
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("jAlert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "jAlert", sb.ToString());
                    return;
                }
            }
            else
            {
                mst.Image = Convert.ToString(ViewState["Image"]);
            }

            mst.Gender = rdlgender.SelectedValue.Trim();
            mst.EmailID = txtemailid.Text.Trim();
            mst.MobileNo = txtmobilenumber.Text.Trim();

            TeacherMsts Teacher = new TeacherMsts();
            String strerr = Teacher.EditTeacher(mst);
            if (strerr == "0")
            {
                Response.Redirect("~/Teacher/TeacherDetails", false);
                //string message = "Request Processed Successfully.";
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //sb.Append("<script type = 'text/javascript'>");
                //sb.Append("window.onload=function(){");
                //sb.Append("jAlert('");
                //sb.Append(message);
                //sb.Append("')};");
                //sb.Append("</script>");
                //ClientScript.RegisterClientScriptBlock(this.GetType(), "jAlert", sb.ToString());
                //return;
            }

        }
        catch (Exception ex)
        {

        }
    }

    #region uploadfile

    private String[] Upload(FileUpload FileUpload_NAME)
    {

        String[] arrResponse = new String[2];
        bool IsExt = false;
        String lstrPath = Server.MapPath("~/EmpImages/");

        String lstrFileName = "";
        try
        {
            if (FileUpload_NAME.PostedFile != null)
            {
                String lstrSizeToUpload = ConfigurationManager.AppSettings["MaxSizeForUpload"].ToString();

                if (FileUpload_NAME.PostedFile.ContentLength > 1)
                {
                    if (FileUpload_NAME.PostedFile.ContentLength > Convert.ToInt64(lstrSizeToUpload))
                    {

                        arrResponse[0] = "1";

                        arrResponse[1] = "<b>The Size of file (" + FileUpload_NAME.PostedFile.ContentLength / 1000000 + " MB ) is greater than 4 MB.</b>";

                    }
                    else
                    {
                        String lstrExtension = Path.GetExtension(FileUpload_NAME.PostedFile.FileName);
                        String TimeStamp = DateTime.Now.ToString("ddMMMyyyy_HHmmss");
                        lstrFileName = Path.GetFileNameWithoutExtension(FileUpload_NAME.PostedFile.FileName) + "_" + TimeStamp + lstrExtension;

                        if (ConfigurationManager.AppSettings["CERT_EXT"] != null)
                        {
                            string[] ext = ConfigurationManager.AppSettings["CERT_EXT"].ToString().Split(',');
                            if (ext.Length > 0)
                            {
                                for (int i = 0; i < ext.Length; i++)
                                {
                                    if (lstrExtension.ToUpper() == "." + ext[i].ToUpper())
                                    {
                                        DirectoryInfo thisFolder = new DirectoryInfo(lstrPath);
                                        if (!thisFolder.Exists)
                                        {
                                            thisFolder.Create();

                                        }
                                        FileUpload_NAME.PostedFile.SaveAs(lstrPath + lstrFileName);
                                        arrResponse[0] = "0";
                                        arrResponse[1] = lstrFileName;
                                        IsExt = true;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            arrResponse[0] = "2";
                            arrResponse[1] = "* Please specify extensions in Web.Config";
                        }
                        if (IsExt == false)
                        {
                            arrResponse[0] = "3";
                            arrResponse[1] = "* You can only upload these file Extensions " + ConfigurationManager.AppSettings["CERT_EXT"].ToString();
                        }

                    }//Content length check.
                }
            }
            return arrResponse;
        }
        catch (Exception ex)
        {
            arrResponse[0] = "3";
            arrResponse[1] = "Run Time Exception";
            throw ex;
        }
    }

    #endregion uploadfile

    protected void btnbak_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeacherDetails", false);
    }
}