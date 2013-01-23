<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit"%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/bootstrap.css" rel="stylesheet">
    <link href="CSS/loginCSS.css" rel="stylesheet">
    <script src="js/jquery.js" type="text/javascript"></script>
    <script src="js/loginJS.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <img class="header" alt="sky" src="img/sky.jpg">
    </header>
    <div id="loginform" >
       
        <div id="divLogin" align="center">
        <h2>Login to your business cloud</h2>
            <asp:Label ID="lb_loginError" runat="server" Text="" CssClass="alert-error"></asp:Label>
            <table>
                <tr>
                    <td><asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator11" runat="server" 
                    ErrorMessage="Email is required" ControlToValidate="tb_email" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Password is required" ControlToValidate="tb_password" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <td><asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
                        <asp:TextBoxWatermarkExtender ID="tb_email_TextBoxWatermarkExtender" 
                            runat="server" TargetControlID="tb_email" WatermarkText="Email">
                        </asp:TextBoxWatermarkExtender>
                    </td>
                    <td><asp:TextBox ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" 
                            runat="server" TargetControlID="tb_password" WatermarkText="Password">
                        </asp:TextBoxWatermarkExtender></td>
                    <td><asp:Button ID="btn_login" runat="server" Text="Login" CssClass="btn btn-primary large" OnClick="LoginUser"/></td>
                </tr>
                <tr>
                    <td><a href="" class="label pointer">forgot password</a></td>
                    <td><a href="Register.aspx" class="label pointer">register</a></td>
                </tr>
            </table>
        </div>

       
    </div>
    </form>
</body>
</html>
