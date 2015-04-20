<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <asp:HyperLink ID="hlCustomer" runat="server" NavigateUrl="~/CustomerList.aspx">Go To Customer List</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="hlFeedback" runat="server" NavigateUrl="~/CustomerFeedback.aspx">Go To Customer Feedback</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="hlncidents" runat="server" NavigateUrl="~/IncidentDisplay.aspx">Go To Customer Feedback</asp:HyperLink>

</asp:Content>

