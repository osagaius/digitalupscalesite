<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="FeedbackBySupport.aspx.cs" Inherits="FeedbackBySupport" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <br />
    <asp:DropDownList ID="ddlStaff" runat="server" DataSourceID="odsSupportStaff" DataTextField="Name" DataValueField="SupportId" AutoPostBack="True">
    </asp:DropDownList>

    <asp:ObjectDataSource ID="odsSupportStaff" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllSupportStaff" TypeName="SupportDatabase"></asp:ObjectDataSource>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsFeedback">
    </asp:GridView>
    <br />
    <asp:ObjectDataSource ID="odsFeedback" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOpenFeedbackIncidents" TypeName="FeedbackDatabase">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlStaff" Name="supportStaffId" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalManagerConnectionString %>" ProviderName="<%$ ConnectionStrings:DigitalManagerConnectionString.ProviderName %>" SelectCommand="SELECT Customer.Name, Feedback.DateOpened, Software.Name AS Software FROM ((Customer INNER JOIN Feedback ON Customer.CustomerID = Feedback.CustomerID) INNER JOIN Software ON Feedback.SoftwareID = Software.SoftwareID) WHERE (Feedback.SupportID = 14) AND (Feedback.DateClosed IS NULL)"></asp:SqlDataSource>
</asp:Content>