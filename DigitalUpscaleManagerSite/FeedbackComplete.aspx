<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FeedbackComplete.aspx.cs" Inherits="FeedbackComplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback Complete</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Styles/Styles.css" rel="stylesheet" />
    <meta name="description" content="Displays feedback confirmation" />
</head>
<body>
    <header class="navbar">
        <h1>Digital Upscale Manager for Ballgames</h1>
        <h2>"Managing Ballgames with Technology"</h2>
    </header>
    <section class="container">
        <form id="form1" runat="server">
            <div>
                <h3>Your feedback has been recieved. Thank you!</h3>
            </div>
            <asp:Panel ID="contact" runat="server">Thanks for requesting to be contacted. We will contact you soon.</asp:Panel>
            <asp:Button ID="btnReturn" runat="server" Text="Return to Feedback Page" OnClick="btnReturn_Click" />
        </form>
    </section>
</body>
</html>
