<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="IncidentDisplay.aspx.cs" Inherits="IncidentDisplay" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sdsCustomers" DataTextField="Name" DataValueField="CustomerID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sdsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalUpscaleConnectionString %>" ProviderName="<%$ ConnectionStrings:DigitalUpscaleConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>

</asp:Content>

