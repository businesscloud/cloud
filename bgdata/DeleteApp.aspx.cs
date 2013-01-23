using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bgdata_DeleteApp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int appID = Convert.ToInt16(Request.Params["ID"]);
        DataClassesDataContext db = new DataClassesDataContext();
        int userid=0;
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
            userApp userapp = db.userApps.Single(p=>(p.u_id==userid) && (p.app_id==appID));
            db.userApps.DeleteOnSubmit(userapp);
            db.SubmitChanges();
            Response.Write("true");
        }
        catch (Exception)
        {
            Response.Write("false");
        }
    }
}