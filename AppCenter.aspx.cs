using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class AppCenter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        int userid=0;
        try
        {
            userid = Convert.ToInt16(Session["userid"]);
            user u = db.users.Single(p => p.u_id == userid);
            lb_username.Text = u.firstname;
        }
        catch (Exception)
        {
            Response.Redirect("Logout.aspx");
        }
      
        var apps = from p in db.apps
                   select p;
        bool ifLeft = true;
        divAppBlocks.InnerHtml = "<div align=\"center\"><table id=\"appTable\" style=\"width: 70%\">";
        foreach (app a in apps)
        {
            if (ifLeft)
            {
                divAppBlocks.InnerHtml += "<tr><td class=\"tdleft\">";
                makeAppBlock(a.app_id, a.app_name, userid, a.logo_path, a.app_info);
                divAppBlocks.InnerHtml += "</td>";
            }
            else 
            {
                divAppBlocks.InnerHtml += "<td class=\"tdright\">";
                makeAppBlock(a.app_id, a.app_name, userid, a.logo_path, a.app_info);
                divAppBlocks.InnerHtml += "</td></tr>";
            }
            ifLeft = !ifLeft;
        }
        if (ifLeft)
            divAppBlocks.InnerHtml += "</table></div>";
        else
            divAppBlocks.InnerHtml += "</tr></table></div>";
    }

    private void makeAppBlock(int appID, string appName,int userid,string logoPath,string appInfo)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        var userapps = from p in db.userApps
                       where (p.app_id == appID && p.u_id == userid)
                       select p;
        if (userapps.Count() > 0)
        {
            divAppBlocks.InnerHtml += "<div class=\"span4 appBlock\"><table><tr><td><table><tr><td rowspan=\"2\" class=\"span2\"><img class=\"applogo\" alt=\"logo\" src=\"" + logoPath + "\"/></td><td class=\"span2\"><h4>" + appName + "</h4></td></tr><tr><td class=\"span2\">" + appInfo + "</td></tr></table></td><td><p class=\"btn btn-info\">Added</p></td></tr></table></div><!--/span-->";
        }
        else
            divAppBlocks.InnerHtml += "<div class=\"span4 appBlock\"><table><tr><td><table><tr><td rowspan=\"2\" class=\"span2\"><img class=\"applogo\" alt=\"logo\" src=\"" + logoPath + "\"/></td><td class=\"span2\"><h4>" + appName + "</h4></td></tr><tr><td class=\"span2\">" + appInfo + "</td></tr></table></td><td><input id=\"" + appID + "\" type=\"button\" value=\"Add\" class=\"btn btn-primary\" onclick=\"addApp(this)\"/></td></tr></table></div><!--/span-->";
    }
    protected void NewApp(object sender, EventArgs e)
    {
        uploadImage();
        DataClassesDataContext db = new DataClassesDataContext();
        app newapp = new app();
        newapp.app_name = appName.Text;
        newapp.link = appURL.Text;
        newapp.app_description = appDescription.Text;
        newapp.category = ddl_category.SelectedValue;
        newapp.logo_path = "img/" + ImageFileUpload.FileName;
        db.apps.InsertOnSubmit(newapp);
        db.SubmitChanges();
    }
    private void uploadImage()
    {
        string filePath,path;
        //Generate path
        path = "img";
        // Generate file path
        filePath = "img/" + ImageFileUpload.FileName;

        if (!Directory.Exists(MapPath(path)))
        {
            Directory.CreateDirectory(MapPath(path));
        }

        // Save uploaded file to the file system
        ImageFileUpload.SaveAs(MapPath(filePath));
    }
}