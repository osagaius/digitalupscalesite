<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="FeedbackBySupport.aspx.cs" Inherits="FeedbackBySupport" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <br />
    <asp:DropDownList ID="ddlStaff" runat="server" DataSourceID="sdsSupport" DataTextField="Name" DataValueField="SupportID" AutoPostBack="True">
    </asp:DropDownList>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
</asp:Content>