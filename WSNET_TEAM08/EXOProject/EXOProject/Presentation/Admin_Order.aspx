<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="Admin_Order.aspx.cs" Inherits="EXOProject.Presentation.Admin_Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style6">
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Label ID="Label8" runat="server" Text="Order CRUD" Font-Bold="True" 
                    Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Order ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRetrieve" runat="server" Text="Retrieve" 
                    onclick="btnRetrieve_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Room ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRoomID" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Customer ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Date In"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateIn" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Date Out"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateOut" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Pax Count"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPaxCount" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Room Count"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRoomCount" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Special Request"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSpecialRequest" runat="server"></asp:TextBox>
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
