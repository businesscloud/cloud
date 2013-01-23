using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bgdata_AddApp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int appID = Convert.ToInt16(Request.Params["appID"]);
        int userid = 0;
        try
        {
             userid = Convert.ToInt16(Session["userid"]);
        }
        catch (Exception)
        {
            Response.Redirect("Logout.aspx");
        }

        try
        {
            DataClassesDataContext db = new DataClassesDataContext();
            userApp userapp = new userApp();
            userapp.u_id = userid;
            userapp.app_id = appID;
            db.userApps.InsertOnSubmit(userapp);
            db.SubmitChanges();
            Response.Write("true");
        }
        catch (Exception)
        {
            Response.Write("false");
        }
    }
}