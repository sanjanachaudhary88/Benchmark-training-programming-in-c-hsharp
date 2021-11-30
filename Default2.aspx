<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
               
                <HeaderTemplate>Department Data
                    <table border="1">
                   <br />
                   
                       <thead>
                           <th>DepartmentID</th>
                           <th>Deparment name</th>
                           <th>location</th>
                       </thead>
                       
                   
               </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:Label ID="label1" runat="server" Text='<%#Bind("depno")%>'></asp:Label></td>
                        <td><asp:Label ID="label2" runat="server" Text='<%#Bind("dname")%>'></asp:Label></td>
                        <td><asp:Label ID="label3" runat="server" Text='<%#Bind("location") %>'></asp:Label></td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                     <tr>
                        <td><asp:Label ID="label1" runat="server" Text='<%#Bind("depno")%>'></asp:Label></td>
                        <td><asp:Label ID="label2" runat="server" Text='<%#Bind("dname")%>'></asp:Label></td>
                        <td><asp:Label ID="label3" runat="server" Text='<%#Bind("location") %>'></asp:Label></td>
                    </tr>

                </AlternatingItemTemplate>
                
            </asp:Repeater>      
        </div>
        
       
    </form>
</body>
</html>
