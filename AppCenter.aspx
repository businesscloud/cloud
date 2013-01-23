<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppCenter.aspx.cs" Inherits="AppCenter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/appcenterCSS.css" rel="stylesheet"/>
    <link href="CSS/popup.css" rel="stylesheet"/>
    <link href="CSS/bootstrap.css" rel="stylesheet"/>
    <script type="text/javascript" src="js/appJS.js"></script>
    <script src="js/jquery.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div id="divTopbar">
        <table style="width: 100%;">
            <tr>
                <td><div class="span2"></div></td>
                <td>
                    
                    <div style="text-align: center">
                        <i class="icon-search"></i>
                        <asp:TextBox ID="searchbox" runat="server"></asp:TextBox>
                        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="searchbox" WatermarkText="Search Your Cloud">
                        </ajaxToolkit:TextBoxWatermarkExtender>
                    </div>
                </td>
                <td class="pull-right">
                    <div class="span2" id="divAccount">
                        <asp:Label ID="lb_username" runat="server" Text=""></asp:Label>
                        <a href="Logout.aspx" class="label span1">Logout</a>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <div id="appCenterBar">
        <table style="width: 100%">
            <tr>
                <td style="width: 30px"><a href="Cloud.aspx" class="label">Launcher</a></td>
                <td style="width: 10px">>></td>
                <td style="width: 30px"><a href="AppCenter.aspx" class="label">App Center</a></td>
                <td ><a href="#newAppPopup" class="btn btn-success" id="btn_newApp">Create New App</a></td>
            </tr>
        </table>
    </div>
        
    <div id="divAppCenter">
        <h3>App Center</h3>
        <div id="divAppBlocks" runat="server">
        </div>
    </div>

       <a href="" class="overlay" id="newAppPopup"></a>
       <div class="popup">
           <div class = "divTopbar">
                <h4 style="color: #000000">Create a New App</h4>
           </div>
           <table>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="appName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>URL:</td>
                    <td><asp:TextBox ID="appURL" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Description:</td>
                    <td><asp:TextBox ID="appDescription" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                    <td>Category:</td>
                    <td><asp:DropDownList ID="ddl_category" runat="server" DataSourceID="Category_DataSource" DataTextField="cat_name" DataValueField="cat_name"></asp:DropDownList></td>
               </tr>
               <tr>
                    <td>Icon:</td>
                    <td><ajaxToolkit:AsyncFileUpload OnClientUploadError="uploadError"
                         OnClientUploadComplete="uploadComplete" runat="server"
                         ID="ImageFileUpload" Width="200px" />
                    </td>
               </tr>
               <tr>
                   <td></td>
                   <td style="text-align:right"><a class="btn" href="#close">Cancel</a> <asp:Button ID="btn_create" runat="server" Text="Create" CssClass="btn btn-success" OnClick="NewApp"/></td>
               </tr>
           </table>
           <a class="close" href="#close"><img alt="close" src="img/close.png"/></a>
           <asp:LinqDataSource ID="Category_DataSource" runat="server" ContextTypeName="DataClassesDataContext" EntityTypeName="" TableName="categories"></asp:LinqDataSource>
       </div>
    </form>
</body>
</html>
