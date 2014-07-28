<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="Admin_Customer.aspx.cs" Inherits="EXOProject.Presentation.Admin_Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style6">
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Label ID="Label8" runat="server" Text="Customer CRUD" Font-Bold="True" 
                    Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Cutomer ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRetrieve" runat="server" Text="Retrieve" 
                    onclick="btnRetrieve_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="User ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Age"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Sex"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Mobile"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label16" runat="server" Text="NOK Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNOKName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label17" runat="server" Text="NOK Contact"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNOKContact" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label18" runat="server" Text="NOK Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNOKAddress" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label19" runat="server" Text="Passport"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassport" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnCreate" runat="server" onclick="btnCreate_Click" 
                    Text="Create" />
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
                    Text="Update" />
            </td>
            <td>
                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                    Text="Delete" />
            </td>
        </tr>
    </table>
</asp:Content>
