<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sandbox.aspx.cs" Inherits="SoundCloudTests.sandbox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:label ID="UserIdLabel" runat="server" text="[UserId]"></asp:label><br/>
        <asp:label ID="FullNameLabel" runat="server" text="[FullName]"></asp:label><br/>
    </div>
    <div>
        <asp:GridView ID="tracksGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Duration" HeaderText="Duration" ReadOnly="True" SortExpression="Duration" />
                <asp:BoundField DataField="State" HeaderText="State" ReadOnly="True" SortExpression="State" />
                <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="True" SortExpression="Description" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
