<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="CustomerList.aspx.cs" Inherits="Default" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <h3>Please select a customer&nbsp;</h3>
    <asp:DropDownList ID="ddlCustomers" runat="server" AutoPostBack="True"
        DataSourceID="SqlDataSource1" DataTextField="Name"
        DataValueField="CustomerID">
    </asp:DropDownList><br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalManagerConnectionString %>" ProviderName="<%$ ConnectionStrings:DigitalManagerConnectionString.ProviderName %>" SelectCommand="SELECT [CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email] FROM [Customer] ORDER BY [CustomerID], [Name]"></asp:SqlDataSource>
    <div id="customerData">
        <h3>Customer Information:</h3>
        <br />
        <asp:Label ID="lblCustomerID" runat="server">Customer ID</asp:Label>
        <br />
        <asp:Label ID="lblAddress" runat="server">Address</asp:Label>
        <br />
        <asp:Label ID="lblCity" runat="server">City</asp:Label>
        <br />
        <asp:Label ID="lblState" runat="server">State</asp:Label>
        <br />
        <asp:Label ID="lblZipCode" runat="server">Zip Code</asp:Label>
        <br />
        <asp:Label ID="lblPhone" runat="server">Phone</asp:Label>
        <br />
        <asp:Label ID="lblEmail" runat="server">Email</asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add to Contacts" OnClick="btnAdd_Click" />
        <asp:Button ID="btnView" runat="server" Text="View Contact List"
            CausesValidation="False" OnClick="btnView_Click" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
    </div>
</asp:Content>
