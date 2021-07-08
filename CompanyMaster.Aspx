<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyMaster.aspx.cs" Inherits="COMPANYPROJECT.CompanyMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="COMPANY NAME:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="BTNUPLOAD" runat="server" Text="UPLOAD FILE" OnClick="BTNUPLOAD_Click" />
        <br />
        <br />
        <asp:Button ID="BTNSUBMIT" runat="server" Text="SUBMIT" OnClick="BTNSUBMIT_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
