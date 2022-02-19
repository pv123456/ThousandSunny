<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStockLastAdded" runat="server" style="z-index: 1; left: 36px; top: 215px; position: absolute" Text="Stock LastAdded"></asp:Label>
            <asp:Label ID="lblStockName" runat="server" style="z-index: 1; left: 45px; top: 159px; position: absolute" Text="Stock Name"></asp:Label>
            <asp:Label ID="lblStockPrice" runat="server" style="z-index: 1; left: 47px; top: 107px; position: absolute; right: 1055px" Text="Stock Price"></asp:Label>
            <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 51px; top: 55px; position: absolute" Text="StockID"></asp:Label>
            <asp:Label ID="lblStockDescription" runat="server" style="z-index: 1; left: 32px; top: 273px; position: absolute" Text="Stock Description"></asp:Label>
            <asp:TextBox ID="txtStockID" runat="server" style="z-index: 1; left: 168px; top: 54px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStockLastAdded" runat="server" style="z-index: 1; left: 232px; top: 211px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStockPrice" runat="server" style="z-index: 1; left: 186px; top: 105px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 195px; top: 162px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStockDescription" runat="server" style="z-index: 1; left: 228px; top: 270px; position: absolute; height: 23px"></asp:TextBox>
        </div>
        <asp:CheckBox ID="chkStockAvaliability" runat="server" style="z-index: 1; left: 66px; top: 342px; position: absolute" Text="StockAvaliability" />
        <asp:Label ID="IblError" runat="server" style="z-index: 1; left: 63px; top: 409px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 104px; top: 448px; position: absolute; right: 1065px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 203px; position: absolute; top: 449px" Text="Cancel" />
    </form>
</body>
</html>
