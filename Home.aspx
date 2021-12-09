<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 155px;
        }
    </style>
</head>
<body bgcolor = #D7BDE2 >
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblLogin" runat="server" Text="Login Form"></asp:Label>

        <table border="1">
            <tr>
                <td>
                    <asp:Label ID="LblUsername" runat="server" Text="Username"></asp:Label></td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextUser" runat="server" Width="147px"></asp:TextBox></td>
                <td>
                    <asp:Label ID="LblErrUser" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
             <td>
                 <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label></td>
                <td class="auto-style1"> 
                    <asp:TextBox ID="TextPass" runat="server" Width="145px" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:Label ID="LblErrPass" runat="server" Text=""></asp:Label></td>
                 
            </tr>
            <tr>
                <td>
                    <asp:Button ID="SubmitBtn" runat="server" Text="submit"/></td>
                <td colspan="2">
                    <asp:Label ID="LblErr" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        </div>

        <p>
            <asp:Label ID="LblForHits" runat="server" Text="No Of Hits Are: "></asp:Label>
        </p>
  
    </form>
</body>
</html>
