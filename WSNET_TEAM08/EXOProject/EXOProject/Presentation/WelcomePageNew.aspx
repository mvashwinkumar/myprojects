<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePageNew.aspx.cs" Inherits="webCA.WelcomePageNew" MasterPageFile="~/Presentation/CA.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
            height: 100px;
            width: 1176px;
        }
        .style10
        {
            width: 1176px;
        }
    .style11
    {}
    .style12
    {
        height: 30px;
        width: 1176px;
    }
    .style13
    {
        width: 193px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1" style="height: 510px; width: 1087px; margin-right: 0px">
            <tr>
                <td style="text-align: center" class="style12">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                        ForeColor="Red" Text="Welcome to EXO World"></asp:Label>
                </td>

            </tr>
            <tr>
                <td class="style10">
                    <table class="style2" style="width: 100%; height: 338px;">
                        <tr>
                            <td class="style13">
                    <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
                    </asp:TreeView> 
                    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
                            </td>
                            <td class="style3" style="text-align: center">
                                &nbsp;<asp:Image ID="Image2" runat="server" Height="300px" 
                                    ImageUrl="~/Presentation/Images/paraz-view-room.jpg" Width="420px" />
                                <asp:Image ID="Image3" runat="server" Height="300px" 
                                    ImageUrl="~/Presentation/Images/paraz-twin.jpg" Width="420px" 
                                    CssClass="style11" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    <asp:Label ID="lblFooter" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>
