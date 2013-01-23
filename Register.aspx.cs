using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RegisterNewUser(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        var users = from p in db.users
                    where p.email == tb_reg_email.Text.Trim()
                    select p;
        if (users.Count() > 0)
        {
            lb_reg_error.Text = "This email address is already registered";
            return;
        }
        try
        {
            user newuser = new user();
            newuser.email = tb_reg_email.Text.Trim();
            newuser.password = tb_reg_pwd.Text;
            if (tb_reg_firstname.Text != "")
                newuser.firstname = tb_reg_firstname.Text.Trim();
            if (tb_reg_lastname.Text != "")
                newuser.lastname = tb_reg_lastname.Text.Trim();
            db.users.InsertOnSubmit(newuser);
            db.SubmitChanges();
            addDefaultApps(newuser.email);
            Response.Write("<script>alert('Registration is successful')</script>");
            Response.Redirect("Login.aspx");
        }
        catch (Exception)
        {
            Response.Write("<script>alert('Registration failed.Please try again.')</script>");
        }
    }

    private void addDefaultApps(String email)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        int[] defaultApps = new int[3]{1,2,3};
        try
        {
            user u = db.users.Single(p => p.email == email);
            for (int i = 0; i < defaultApps.Length; i++)
            {
                userApp ua = new userApp();
                ua.u_id = u.u_id;
                ua.app_id = defaultApps[i];
                db.userApps.InsertOnSubmit(ua);
                db.SubmitChanges();
            }
        }
        catch (Exception)
        {
            Response.Write("<script>alert('Server Error')</script>");
        }
 
    }
 
}