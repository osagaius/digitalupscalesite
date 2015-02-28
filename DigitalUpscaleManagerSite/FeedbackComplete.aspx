<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="FeedbackComplete.aspx.cs" Inherits="FeedbackComplete" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <div>
        <h3>Your feedback has been recieved. Thank you!</h3>
    </div>
    <asp:Panel ID="contact" runat="server">Thanks for requesting to be contacted. We will contact you soon.</asp:Panel>
    <asp:Button ID="btnReturn" runat="server" Text="Return to Feedback Page" OnClick="btnReturn_Click" />
</asp:Content>
