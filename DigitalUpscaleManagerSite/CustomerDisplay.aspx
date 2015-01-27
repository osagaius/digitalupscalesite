<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDisplay.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Customer Display</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <header>
        <h1>Digital Upscale Manager for Ballgames</h1>
        <h2>"Managing Ballgames with Technology"</h2>
    </header>
    <section>
    <form id="form1" runat="server">
        <label>Please select a customer&nbsp;</label>
        <asp:DropDownList ID="ddlCustomers" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="Name" 
            DataValueField="CustomerID">
        </asp:DropDownList><br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalManagerConnectionString %>" ProviderName="<%$ ConnectionStrings:DigitalManagerConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Customer] ORDER BY [CustomerID]"></asp:SqlDataSource>
        <div id="customerData">
            <asp:Label ID="lblName" runat="server"></asp:Label>
            <asp:Label ID="lblCustomerID" runat="server"></asp:Label>
            <asp:Label ID="lblAddress" runat="server"></asp:Label>
            <asp:Label ID="lblCity" runat="server"></asp:Label>
            <asp:Label ID="lblState" runat="server"></asp:Label>
            <asp:Label ID="lblZipCode" runat="server"></asp:Label>
            <asp:Label ID="lblPhone" runat="server"></asp:Label>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" Text="Add to Contacts"/>
            <asp:Button ID="btnView" runat="server" Text="View Contact List" 
                CausesValidation="False" />
        </div>
    </form>
    </section>
</body>
</html>
