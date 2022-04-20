<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblStaffFullName" runat="server" Text="Full name"></asp:Label>
            <asp:TextBox ID="txtStaffFullName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStartDate" runat="server" Text="Start date"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkIsAdmin" runat="server" Text="Admin" />
        <p>
            <asp:Label ID="lblStaffEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtStaffPassword" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="31px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
