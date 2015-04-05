<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="CustomerFeedback.aspx.cs" Inherits="CustomerFeedback" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <div class="identification">
        <h3>Customer Feedback</h3>
        <asp:Label runat="server" Text="Customer ID:" ID="lblCustomerID"></asp:Label>

        &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CompareValidator ID="cvCustomerID" runat="server" ControlToValidate="txtCustomerID" CssClass="message" Display="Dynamic" Operator="DataTypeCheck" Type="Integer">Must be a number.</asp:CompareValidator>
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="rfvCustomerID" runat="server" ControlToValidate="txtCustomerID" CssClass="message" Display="Dynamic" ErrorMessage="RequiredFieldValidator">This field cannot be blank.</asp:RequiredFieldValidator>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
        <asp:Button ID="btnFeedback" runat="server" Text="Show Feedback" OnClick="btnFeedback_Click" />
        <br />
        <br />
        <asp:Label ID="lblFeedbackMessage" runat="server" CssClass="message"></asp:Label>
        <br />
        <br />
    </div>
    <asp:Panel runat="server" ID="pnlFeedback">
        <asp:Label CssClass="upscaleHeadingLabel" ID="lblFeedback" runat="server" Text="Your closed feedback:"></asp:Label>
        <br />
        <asp:ListBox ID="lstFeedback" runat="server" Height="133px" Width="505px"></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerFeedbackConnectionString %>" ProviderName="<%$ ConnectionStrings:CustomerFeedbackConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Feedback] ORDER BY [FeedbackID], [CustomerID]"></asp:SqlDataSource>
        <asp:RequiredFieldValidator ID="rfvFeedbackList" runat="server" ControlToValidate="lstFeedback" CssClass="message" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ValidationGroup="feedback">You must select a feedback.</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblServiceTime" runat="server" Text="Please rate the service time"></asp:Label>
        <asp:RadioButtonList ID="rblServiceTime" runat="server">
            <asp:ListItem Value="1">Satisfied</asp:ListItem>
            <asp:ListItem Value="2">Neither Satisfied Nor Dissatisfied</asp:ListItem>
            <asp:ListItem Value="3">Dissatisfied</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblEfficiency" runat="server" Text="Please rate the technical efficiency"></asp:Label>
        <br />
        <asp:RadioButtonList ID="rblEfficiency" runat="server">
            <asp:ListItem Value="1">Satisfied</asp:ListItem>
            <asp:ListItem Value="2">Neither Satisfied Nor Dissatisfied</asp:ListItem>
            <asp:ListItem Value="3">Dissatisfied</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblEfficiency0" runat="server" Text="Please rate the resolution of your problem"></asp:Label>
        <br />
        <asp:RadioButtonList ID="rblResolution" runat="server">
            <asp:ListItem Value="1">Satisfied</asp:ListItem>
            <asp:ListItem Value="2">Neither Satisfied Nor Dissatisfied</asp:ListItem>
            <asp:ListItem Value="3">Dissatisfied</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblComments" runat="server" Text="Please enter any additional comments:"></asp:Label>
        <br />
        <asp:TextBox ID="txtComments" runat="server" Height="70px" TextMode="MultiLine" Width="321px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chbContact" runat="server" Text="Do you wish to be contacted? " TextAlign="Left" />
        <br />
        <br />
        <asp:Label ID="lblContactMethod" runat="server" Text="How do prefer to be contacted?"></asp:Label>
        <br />
        <asp:RadioButtonList ID="rblContactMethod" runat="server">
            <asp:ListItem Value="Email">Email</asp:ListItem>
            <asp:ListItem Value="Phone">Phone</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button CssClass="upscaleButton" ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="feedback" />
        <br />
    </asp:Panel>
</asp:Content>
