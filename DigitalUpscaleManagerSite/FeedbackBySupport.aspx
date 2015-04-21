<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="FeedbackBySupport.aspx.cs" Inherits="FeedbackBySupport" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <br />
    <asp:DropDownList ID="ddlStaff" runat="server" DataSourceID="odsSupportStaff" DataTextField="Name" DataValueField="SupportId" AutoPostBack="True">
    </asp:DropDownList>

    <asp:ObjectDataSource ID="odsSupportStaff" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetSupportStaff" TypeName="SupportDb"></asp:ObjectDataSource>
</asp:Content>