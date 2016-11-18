<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="WCF.WebFormsApp.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" Text="0 OR 1=1" ID="txtId"></asp:TextBox>
            <asp:Button runat="server" ID="btnGo" Text="Go" OnClick="btnGo_Click" />
            <asp:GridView runat="server" ID="grdCustomers">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
