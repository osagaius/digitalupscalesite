<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerFeedback.aspx.cs" Inherits="CustomerFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Feedback</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Styles/Styles.css" rel="stylesheet" />
    <meta name="description" content="Displays feedback for a customer" />
</head>
<body>
    <header class="navbar">
        <h1>Digital Upscale Manager for Ballgames</h1>
        <h2>"Managing Ballgames with Technology"</h2>
    </header>
    <section class="container">
        <form id="form1" runat="server">
            <div class="identification">
                <h3>Customer Feedback</h3>
                <asp:Label runat="server" Text="Customer ID:" ID="lblCustomerID"></asp:Label>

                &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFeedback" runat="server" Text="Show Feedback" />
            </div>
            <div class="feedback">
            </div>
        </form>
    </section>
</body>
</html>
