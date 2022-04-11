<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 219px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       
     <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 16px; top: 20px; position: absolute; height: 192px; width: 269px"></asp:ListBox>
        </div>
       <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 15px; top: 293px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 294px; position: absolute; left: 88px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top: 294px; position: absolute; left: 147px" Text="Delete" OnClick="btnDelete_Click" />
       <br />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 33px; top: 374px; position: absolute" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 107px; top: 371px; position: absolute" Text="Clear" OnClick="btnClear_Click" />
       <br />
        <br />
        <asp:Label ID="IblFilterName" runat="server" style="z-index: 1; left: 26px; top: 339px; position: absolute" Text="Enter a Name "></asp:Label>
        <asp:TextBox ID="txtFilterName" runat="server" style="z-index: 1; left: 137px; top: 340px; position: absolute"></asp:TextBox>
        
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 429px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
