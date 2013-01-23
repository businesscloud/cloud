<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cloud.aspx.cs" Inherits="cloud" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="CSS/css.css" rel="stylesheet"/>
    <link href="CSS/popup.css" rel="stylesheet"/>
    <link href="CSS/bootstrap.css" rel="stylesheet"/>
    <script type="text/javascript" src="js/appJS.js"></script>
    <script src="js/jquery.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:scriptmanager ID="Scriptmanager1" runat="server"></asp:scriptmanager>
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
    <div id="divApps" runat="server">
    </div>
    <div id="divPopups" runat="server">
       <a href="" class="overlay" id="changeBgPopup"></a>
       <div class="popup">
           <div class = "divTopbar">
                <h4 style="color: #000000">Desktop Wallpapers</h4>
           </div>
           <table>
                <tr>
                    <td><img alt="" src="img/wallpaper/bg1.jpg" class="logo_small pointer" onclick="changeWallpaper('bg1.jpg');"/></td>
                    <td><img alt="" src="img/wallpaper/bg2.jpg" class="logo_small pointer" onclick="changeWallpaper('bg2.jpg');"/></td>
                    <td><img alt="" src="img/wallpaper/bg3.jpg" class="logo_small pointer" onclick="changeWallpaper('bg3.jpg');"/></td>
                    <td><img alt="" src="img/wallpaper/bg4.jpg" class="logo_small pointer" onclick="changeWallpaper('bg4.jpg');"/></td>
                </tr>
                <tr>
                    <td><img alt="" src="img/wallpaper/bg5.jpg" class="logo_small pointer" onclick="changeWallpaper('bg5.jpg');"/></td>
                    <td><img alt="" src="img/wallpaper/bg6.jpg" class="logo_small pointer" onclick="changeWallpaper('bg6.jpg');"/></td>
                    <td><img alt="" src="img/wallpaper/bg7.jpg" class="logo_small pointer" onclick="changeWallpaper('bg7.jpg');"/></td>
                    <td><img alt="" src="img/wallpaper/bg8.png" class="logo_small pointer" onclick="changeWallpaper('bg8.png');"/></td>
                </tr>
           </table>
           <a class="close" href="#close"><img alt="close" src="img/close.png"/></a>
       </div>
   
    </div>
    <div id="footer">
        <a href="AppCenter.aspx" class="iconleft"><img alt="addApp" src="img/addApp.png" /></a>
        <a href="#changeBgPopup" class="iconright"><img alt="addApp" src="img/changeBg.png" /></a>
    </div>
    </form>
</body>
</html>
