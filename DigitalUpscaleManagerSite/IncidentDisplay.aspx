<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DigitalUpscale.master" CodeFile="IncidentDisplay.aspx.cs" Inherits="IncidentDisplay" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <asp:DropDownList ID="ddlCustomers" runat="server" DataSourceID="sdsCustomers" DataTextField="Name" DataValueField="CustomerID" AutoPostBack="True">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sdsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalUpscaleConnectionString %>" ProviderName="<%$ ConnectionStrings:DigitalUpscaleConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
    <asp:DataList ID="dlIncidents" runat="server" DataKeyField="FeedbackID" DataSourceID="sdsIncidents" Style="margin-right: 75px" Width="605px">
        <HeaderTemplate>
            <tr>
                <th>Software/Incident
                </th>
                <th>Technician Name
                </th>
                <th>Date Opened
                </th>
                <th>Date Closed
                </th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <br />

            <tr>
                <td>
                    <%# Eval("Title")%>
                </td>
                <td>
                    <%# Eval("Name")%>
                </td>
                <td>
                    <%# Eval("DateOpened")%>
                </td>
                <td>
                    <%# Eval("DateClosed")%>
                </td>
                <tr>
                    <td>
                        <%# Eval("Description")%>
                    </td>
                </tr>
            </tr>

            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="sdsIncidents" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalManagerConnectionString %>" ProviderName="<%$ ConnectionStrings:DigitalManagerConnectionString.ProviderName %>" SelectCommand="SELECT Feedback.FeedbackID, Feedback.CustomerID, Feedback.SoftwareID, Feedback.SupportID, Feedback.DateOpened, Feedback.DateClosed, Feedback.Title, Feedback.Description, Support.Name FROM (Feedback INNER JOIN Support ON Feedback.SupportID = Support.SupportID) WHERE (Feedback.CustomerID = ?)">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlCustomers" Name="CustomerID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>

