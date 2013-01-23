using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginUser(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        String email=tb_email.Text.Trim();
        String password=tb_password.Text;
        try
        {
            var users = from p in db.users
                        where p.email == email
                        select p;
            if (users.Count() > 0)
            {
                user u = db.users.Single(p => p.email == email);
                if (u.password == password)
                {
                    Session["userid"] = u.u_id.ToString();
                    Response.Redirect("cloud.aspx");
                }
            }
        }
        catch (Exception)
        {
            Response.Write("<script>alert('Server Error')</script>");
            return;
        }

        lb_loginError.Text = "Email or Password is incorrect";
    }
}