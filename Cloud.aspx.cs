using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cloud : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        try
        {
            int userid = Convert.ToInt16(Session["userid"]);
            user u = db.users.Single(p=>p.u_id==userid);
            lb_username.Text = u.firstname;
            var userapps = from p in db.userApps
                           where (p.u_id == userid)
                           select p;
            foreach (userApp userapp in userapps)
            {
                app application = db.apps.Single(p => p.app_id == userapp.app_id);
                makeApp(Convert.ToInt16(application.app_id), application.app_name, application.link, application.logo_path);
                makePopup(Convert.ToInt16(application.app_id), application.app_name, application.logo_path, application.app_info);
            }
        }
        catch(Exception)
        {
            Response.Redirect("Logout.aspx");
        }
        
   
    }

    protected void makeApp(int appID,String appName, String appLink, String appLogoPath)
    {
        divApps.InnerHtml+="<div class=\"span2\"><div class=\"app\" draggable=\"true\" onmouseover =\"showBackground(this);\" onmouseout =\"hideBackground(this);\"><div class=\"actions\" style=\"visibility: hidden\"><a href=\"#popup"+appID+"\"  class=\"infos\"><i class=\"icon-info-sign icon-white\"></i></a><i id=" + appID + " class=\"icon-remove-sign icon-white delete\" onclick=\"deleteApp(this);\"></i></div><div onclick = \"gotoLink('" + appLink + "');\"><img class=\"applogo\" src=" + appLogoPath + " alt=\"logo\"><h4>" + appName + "</h4></div></div></div><!--/span-->";
        
    }
     protected void makePopup(int appID,String appName, String appLogoPath,string appInfo)
    {
        divPopups.InnerHtml += "<a href=\"\" class=\"overlay\" id=\"popup" + appID + "\"></a><div class=\"popup\"><h2>" + appName + "</h2><img alt=\"logo\" src=\"" + appLogoPath + "\"/><p>" + appInfo + "</p><a class=\"close\" href=\"#close\"><img alt=\"close\" src=\"img/close.png\"/></a></div>";
    }
}