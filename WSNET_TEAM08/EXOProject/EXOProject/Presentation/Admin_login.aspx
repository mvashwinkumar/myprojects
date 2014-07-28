<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="Admin_login.aspx.cs" Inherits="EXOProject.Presentation.Admin_login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style6">
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Label ID="Label8" runat="server" Text="Login" Font-Bold="True" 
                    Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="User ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRetrieve" runat="server" Text="Retrieve" 
                    onclick="btnRetrieve_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="User Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Security Question"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSecurityQue" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Security Question Answer"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSecurityQueAns" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Room Type"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRoomType" runat="server"></asp:TextBox>
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
