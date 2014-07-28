<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="Admin_room.aspx.cs" Inherits="EXOProject.Presentation.Admin_room" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style6">
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Label ID="Label8" runat="server" Text="Room CRUD" Font-Bold="True" 
                    Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Room ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRoomID" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRetrieve" runat="server" Text="Retrieve" 
                    onclick="btnRetrieve_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Room Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRoomName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="No. of Rooms"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRoomCapacity" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Summary"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSummary" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Amenities"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAmenities" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Fare"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Room Type"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRoomType" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Image URL"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtImageURL" runat="server"></asp:TextBox>
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
