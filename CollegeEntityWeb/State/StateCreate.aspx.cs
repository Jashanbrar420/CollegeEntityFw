using Business;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class State_StateCreate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnstate_Click(object sender, EventArgs e)
    {
        try
        {
            StateMst mst = new StateMst();
            mst.State_Name = txtstatename.Text.Trim();

            StateMsts obj = new StateMsts();
            String strerr = obj.CreateState(mst);
            if (strerr == "0")
            {
                Response.Redirect("~/State/StateDetails", false);
            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void btnbak_Click(object sender, EventArgs e)
    {
        Response.Redirect("StateDetails", false);
    }
}