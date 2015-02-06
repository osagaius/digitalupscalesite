<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The Digital Upscale Manager for Ballgames Site</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Styles/Styles.css" rel="stylesheet" />
    <meta name="description" content="Displays navigation for pages" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <header class="navbar">
        <h1>Digital Upscale Manager for Ballgames</h1>
        <h2>"Managing Ballgames with Technology"</h2>
    </header>
    <section class="container">
        <form id="form1" runat="server">
            <div>
                <asp:HyperLink ID="hlCustomer" runat="server" NavigateUrl="~/CustomerList.aspx">Go To Customer List</asp:HyperLink>
                <br />
                <br />
                <asp:HyperLink ID="hlFeedback" runat="server" NavigateUrl="~/CustomerFeedback.aspx">Go To Customer Feedback</asp:HyperLink>

            </div>
        </form>
    </section>
</body>
</html>
