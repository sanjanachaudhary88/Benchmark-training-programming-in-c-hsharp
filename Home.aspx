<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login Form"></asp:Label> 

             <table>
            <tr>
                <td>
                    <asp:Label ID="lbllogin" runat="server" Text="username"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblerr" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblpass" runat="server" Text="password"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblerrpass" runat="server" Text=""></asp:Label></td>
                    
            </tr>
           
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    </td>
                    <td><asp:Label ID="lblerr2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        
        </table>
        </div>
    </form>
</body>
</html>
