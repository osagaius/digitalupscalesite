<%@ Page Language="C#" MasterPageFile="~/DigitalUpscale.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">
    <br />
    <h2>Products</h2>
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" DataKeyNames="SoftwareID" DataSourceID="sdsProducts" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True" ShowEditButton="True" />
            <asp:TemplateField HeaderText="SoftwareID" SortExpression="SoftwareID">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("SoftwareID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SoftwareID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name" SortExpression="Name">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="TextBox1" CssClass="error" Display="Dynamic" ErrorMessage="A name is required.">*</asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Version" SortExpression="Version">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" Text='<%# Bind("Version") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvVersion" runat="server" ControlToValidate="TextBox2" CssClass="error" Display="Dynamic" ErrorMessage="A version is required.">*</asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Version") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ReleaseDate" SortExpression="ReleaseDate">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("ReleaseDate") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvReleaseDate" runat="server" ControlToValidate="TextBox3" CssClass="error" Display="Dynamic" ErrorMessage="A release date is required.">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="cvDate" runat="server" OnServerValidate="valDateRange_ServerValidate" ControlToValidate="TextBox3" CssClass="error" Display="Dynamic" ErrorMessage="A valid date is required.">*</asp:CustomValidator>

                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("ReleaseDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <br />
    <h2>Add a Product</h2>
    <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>' CausesValidation="True" Style="margin-left: 0px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" CssClass="error" Display="Dynamic" ErrorMessage="A name is required.">*</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblID" runat="server" Text="Software ID:"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server" Text='<%# Bind("Name") %>' CausesValidation="True"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID" CssClass="error" Display="Dynamic" ErrorMessage="An ID is required.">*</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblVersion" runat="server" Text="Version:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtVersion" runat="server" Text='<%# Bind("Name") %>' CausesValidation="True"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvVersion" runat="server" ControlToValidate="txtVersion" CssClass="error" Display="Dynamic" ErrorMessage="A version is required.">*</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblRelease" runat="server" Text="Release Date:"></asp:Label>
    &nbsp;
    <asp:TextBox ID="txtDate" runat="server" Text='<%# Bind("Name") %>' CausesValidation="True"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvDate" runat="server" ControlToValidate="txtDate" CssClass="error" Display="Dynamic" ErrorMessage="A date is required.">*</asp:RequiredFieldValidator>
    <asp:CustomValidator ID="cvReleaseDate" runat="server" OnServerValidate="valDateRange_ServerValidate" ControlToValidate="txtDate" CssClass="error" Display="Dynamic" ErrorMessage="A valid date is required.">*</asp:CustomValidator>
    <br />
    <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
    <asp:ValidationSummary ID="vsProducts" runat="server" CssClass="error" />
    <br />
    <asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalManagerConnectionString %>" ProviderName="<%$ ConnectionStrings:DigitalManagerConnectionString.ProviderName %>" SelectCommand="SELECT [SoftwareID], [Name], [Version], [ReleaseDate] FROM [Software]" DeleteCommand="DELETE FROM [Software] WHERE [SoftwareID] = ?" InsertCommand="INSERT INTO [Software] ([SoftwareID], [Name], [Version], [ReleaseDate]) VALUES (?, ?, ?, ?)" UpdateCommand="UPDATE [Software] SET [Name] = ?, [Version] = ?, [ReleaseDate] = ? WHERE [SoftwareID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="SoftwareID" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="SoftwareID" Type="String" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Version" Type="Decimal" />
            <asp:Parameter Name="ReleaseDate" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Version" Type="Decimal" />
            <asp:Parameter Name="ReleaseDate" Type="DateTime" />
            <asp:Parameter Name="SoftwareID" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

