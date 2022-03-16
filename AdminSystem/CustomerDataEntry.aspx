<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 791px; width: 2106px">
    <form id="form1" runat="server" aria-busy="False">
        <asp:Label ID="lblCustId" runat="server" Text="Customer ID:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustId" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <asp:Label ID="lblCustUsername" runat="server" Text="Username:" width="82px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustUsername" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustPassword" runat="server" ClientIDMode="AutoID" Text="Password:" width="82px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustPassword" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustEmail" runat="server" Text="Email:" width="82px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustDOB" runat="server" Text="Date of Birth:" width="82px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustDOB" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkOver18" runat="server" Text="Over 18" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
