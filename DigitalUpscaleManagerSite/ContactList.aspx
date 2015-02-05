<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactList.aspx.cs" Inherits="ContactList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Contact List</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Styles/Styles.css" rel="stylesheet" />
    <meta name="description" content="Displays information about customers" />
</head>
<body>
    <header class="navbar">
        <h1>Digital Upscale Manager for Ballgames</h1>
        <h2>"Managing Ballgames with Technology"</h2>
    </header>
    <section class="container">
        <form id="form1" runat="server">
            <h3>Your contact list</h3>
            <asp:ListBox ID="lstCustomers" runat="server" style="margin-right: 120px" Width="193px"></asp:ListBox>

            <div id="buttons">
                <asp:Button ID="btnSelectAdditional" runat="server" Text="Select Additional Customers" CssClass="button" OnClick="btnSelectAdditional_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRemove" runat="server" Text="Remove Customer" 
                    onclick="btnRemove_Click" CssClass="button" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" Text="Clear List" 
                    onclick="btnEmpty_Click" CssClass="button" />
            </div>
            <p id="message">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </form>
    </section>
</body>
</html>
