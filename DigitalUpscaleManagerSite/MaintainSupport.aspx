<%@ Page Language="C#" MasterPageFile="~/DigitalUpscale.master" AutoEventWireup="true" CodeFile="MaintainSupport.aspx.cs" Inherits="MaintainSupport" %>

<asp:Content ID="headContent" ContentPlaceHolderID="headPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="formContent" ContentPlaceHolderID="formPlaceHolder" runat="server">

    <asp:DropDownList ID="ddlSupport" runat="server" AutoPostBack="True" DataSourceID="sdsSupport" DataTextField="Name" DataValueField="SupportID">
    </asp:DropDownList>

    <asp:SqlDataSource ID="sdsSupport" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalUpscaleConnectionString %>" DeleteCommand="DELETE FROM [Support] WHERE [SupportID] = ?" InsertCommand="INSERT INTO [Support] ([SupportID], [Name], [Email], [Phone]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:DigitalUpscaleConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Support] ORDER BY [Name]" UpdateCommand="UPDATE [Support] SET [Name] = ?, [Email] = ?, [Phone] = ? WHERE [SupportID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="SupportID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="SupportID" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="SupportID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <br />
    <asp:FormView ID="fvSelectedStaff" runat="server" DataKeyNames="SupportID" DataSourceID="sdsSelectedStaff" OnItemDeleted="fvSelectedStaff_ItemDeleted" OnItemInserted="fvSelectedStaff_ItemInserted" OnItemUpdated="fvSelectedStaff_ItemUpdated">
        <EditItemTemplate>
            SupportID:
            <asp:Label ID="SupportIDLabel1" runat="server" Text='<%# Eval("SupportID") %>' />
            <br />
            Name:
            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="NameTextBox" CssClass="error" Display="Dynamic" ErrorMessage="A name is required.">*</asp:RequiredFieldValidator>
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="EmailTextBox" CssClass="error" Display="Dynamic" ErrorMessage="An email is required.">*</asp:RequiredFieldValidator>
            <br />
            Phone:
            <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="PhoneTextBox" CssClass="error" Display="Dynamic" ErrorMessage="A phone number is required.">*</asp:RequiredFieldValidator>
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            ID:
            <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("SupportID") %>' />
            <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="IDTextBox" CssClass="error" Display="Dynamic" ErrorMessage="An ID is required.">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvID" runat="server" ControlToValidate="IDTextBox" Display="Dynamic" ErrorMessage="A valid number is required for the ID." Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
            <br />
            Name:
            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="NameTextBox" CssClass="error" Display="Dynamic" ErrorMessage="A name is required.">*</asp:RequiredFieldValidator>
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="EmailTextBox" CssClass="error" Display="Dynamic" ErrorMessage="An email is required.">*</asp:RequiredFieldValidator>
            <br />
            Phone:
            <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="PhoneTextBox" CssClass="error" Display="Dynamic" ErrorMessage="A phone number is required.">*</asp:RequiredFieldValidator>
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            SupportID:
            <asp:Label ID="SupportIDLabel" runat="server" Text='<%# Eval("SupportID") %>' />
            <br />
            Name:
            <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
            <br />
            Email:
            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            Phone:
            <asp:Label ID="PhoneLabel" runat="server" Text='<%# Bind("Phone") %>' />
            <br />
            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
        </ItemTemplate>
    </asp:FormView>
    <br />
    <asp:SqlDataSource ID="sdsSelectedStaff" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalManagerConnectionString %>" DeleteCommand="DELETE FROM [Support] WHERE [SupportID] = ?" InsertCommand="INSERT INTO [Support] ([SupportID], [Name], [Email], [Phone]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:DigitalManagerConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Support] WHERE ([SupportID] = ?)" UpdateCommand="UPDATE [Support] SET [Name] = ?, [Email] = ?, [Phone] = ? WHERE [SupportID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="SupportID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="SupportID" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlSupport" Name="SupportID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="SupportID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:Label ID="lblError" runat="server" CssClass="error"></asp:Label>
    <asp:ValidationSummary ID="vsProducts" runat="server" CssClass="error" />
    
</asp:Content>
