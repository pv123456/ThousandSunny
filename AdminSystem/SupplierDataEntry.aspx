<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID :" width="116px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name :" width="116px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierEmail" runat="server" Text="Supplier Email :" width="116px"></asp:Label>
            <asp:TextBox ID="txtSupplierEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSupplierAddress" runat="server" Text="Supplier Address : "></asp:Label>
            <asp:TextBox ID="txtSupplierAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStartDateSupplier" runat="server" Text="Start Date :" width="116px"></asp:Label>
            <asp:TextBox ID="txtStartDateSupplier" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkSupplierDiscountPrice" runat="server" Text="Discount" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
