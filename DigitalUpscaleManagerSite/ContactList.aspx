<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="ContactList.aspx.cs" Inherits="ContactList" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <asp:Label ID="lblContactList" runat="server" Text="Your contact list:"></asp:Label>
    <br />
    <asp:ListBox ID="lstCustomers" runat="server" Style="margin-right: 120px" Width="432px" Height="117px"></asp:ListBox>
    <div id="buttons">
        <asp:Button ID="btnSelectAdditional" runat="server" Text="Select Additional Customers" CssClass="button" OnClick="btnSelectAdditional_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRemove" runat="server" Text="Remove Customer"
                    OnClick="btnRemove_Click" CssClass="button" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Text="Clear List"
                    OnClick="btnEmpty_Click" CssClass="button" />
    </div>
    <p id="message">
        <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
    </p>
</asp:Content>
