<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="DigitalUpscale.master" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <h3>Please feel free to contact us.</h3>
    <asp:Label ID="lblPhone" runat="server" Text="Phone: 88-Ballgame"></asp:Label>
    <br />
    <asp:Label ID="lblHours" runat="server" Text="Hours of operation: Monday - Friday, 9a-5p"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
    <asp:HyperLink ID="hplInfo" runat="server" NavigateUrl="malito:info@ballgame.com">info@ballgame.com</asp:HyperLink>
    <br />
    <br />
    <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
    <br />
    <asp:Label ID="lblStreetAddress" runat="server" Text="1601 Maple Street"></asp:Label>
    <br />
    <asp:Label ID="lblCityStateAddress" runat="server" Text="Carrollton, GA 30117"></asp:Label>
    <br />

</asp:Content>
