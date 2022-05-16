<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyViewPage.aspx.cs" Inherits="COMPANYPROJECT.CompanyViewPage" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

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
        <asp:ScriptManager ID="ScriptManager1" runat="server">  
</asp:ScriptManager>
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br />
        <br />
        <asp:Button ID="Btnshow" runat="server" Text="SHOW" OnClick="Btnshow_Click" />
        <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="Btnshow"  
    CancelControlID="Button2" BackgroundCssClass="Background">  
</cc1:ModalPopupExtender>  
<asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">  
    <iframe style=" width: 350px; height: 300px;" id="irm1" src="WebForm2.aspx" runat="server"></iframe>  
   <br/>  
    <asp:Button ID="BTNCLOUSE" runat="server" Text="Close" />  
</asp:Panel>  

        <asp:Button ID="btnaprvdisaprv" runat="server" Text="APPROVE/DISAPPROVE" OnClick="btnaprvdisaprv_Click" />
    </div>
    </form>
</body>
</html>
