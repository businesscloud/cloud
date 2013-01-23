<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

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
    <div id="divRegister" align="center">
        <h2>Register your business cloud account</h2>
        <asp:Label ID="lb_reg_error" runat="server" Text="" CssClass="alert-error"></asp:Label>
            <table>
                <tr>
                    <td class="span3">Email:</td>
                    <td>
                        <asp:TextBox ID="tb_reg_email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="tb_reg_email" ErrorMessage="Email is required" 
                            ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ErrorMessage="Invalid Email" 
                            ValidationExpression="^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,3}$" 
                            ControlToValidate="tb_reg_email" ForeColor="Red"></asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td class="span3">Password(6 to 20 characters string with at least one digit, one upper case letter, one lower case letter ):</td>
                    <td>
                        <asp:TextBox ID="tb_reg_pwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="tb_reg_pwd" ErrorMessage="Password is required" 
                            ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ForeColor="Red" runat="server" 
                            ErrorMessage="Invalid password" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20})" ControlToValidate="tb_reg_pwd"></asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td class="span3">Confirm password:</td>
                    <td>
                        <asp:TextBox ID="tb_reg_pwd2" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ErrorMessage="password doesn't match" ControlToCompare="tb_reg_pwd" 
                            ControlToValidate="tb_reg_pwd2" ForeColor="Red"></asp:CompareValidator></td>
                </tr>
                <tr>
                    <td class="span3">Firstname:</td>
                    <td><asp:TextBox ID="tb_reg_firstname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="span3">Lastname:</td>
                    <td><asp:TextBox ID="tb_reg_lastname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btn_register" runat="server" Text="Register" 
                            CssClass="btn btn-primary" OnClick="RegisterNewUser" />
                        <a href="Login.aspx">Login</a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
