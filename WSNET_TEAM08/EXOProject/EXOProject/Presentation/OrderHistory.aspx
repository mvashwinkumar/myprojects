<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="webCA.Presentation.OrderHistory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            height: 23px;
            text-align: center;
        }
        .style4
        {
            text-align: center;
        }
        .style11
        {
            text-align: center;
            width: 251px;
        }
        .style12
        {
            height: 23px;
            text-align: center;
            width: 251px;
        }
        .style13
        {
            text-align: center;
            width: 232px;
        }
        .style14
        {
            height: 23px;
            text-align: center;
            width: 232px;
        }
        .style17
        {
            text-align: center;
            width: 162px;
        }
        .style18
        {
            height: 23px;
            text-align: center;
            width: 162px;
        }
        .style19
        {
            text-align: center;
            width: 178px;
        }
        .style20
        {
            height: 23px;
            text-align: center;
            width: 178px;
        }
        .style21
        {
            text-align: center;
            width: 215px;
        }
        .style22
        {
            height: 23px;
            text-align: center;
            width: 215px;
        }
        .style23
        {
            text-align: center;
            width: 212px;
        }
        .style24
        {
            height: 23px;
            text-align: center;
            width: 212px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td bgcolor="Yellow" class="style13">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Customer ID"></asp:Label>
                </td>
                <td bgcolor="Yellow" class="style21">
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Order ID"></asp:Label>
                </td>
                <td bgcolor="Yellow" class="style11">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Room Type"></asp:Label>
                </td>
                <td bgcolor="Yellow" class="style23">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Room ID"></asp:Label>
                </td>
                <td bgcolor="Yellow" class="style17">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Date"></asp:Label>
                </td>
                <td bgcolor="Yellow" class="style19">
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Duration"></asp:Label>
                </td>
                <td bgcolor="Yellow" class="style4">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Status"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                </td>
                <td class="style21">
                    <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="style23">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="style17">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                <td class="style19">
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" Text="day(s)"></asp:Label>
                </td>
                <td class="style4">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>completed</asp:ListItem>
                        <asp:ListItem>pending</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                </td>
                <td class="style21">
                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="style23">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="style17">
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                <td class="style19">
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="day(s)"></asp:Label>
                </td>
                <td class="style4">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>completed</asp:ListItem>
                        <asp:ListItem>pending</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                </td>
                <td class="style22">
                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                </td>
                <td class="style12">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="style24">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="style18">
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td>
                <td class="style20">
                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                    <asp:Label ID="Label8" runat="server" Text="day(s)"></asp:Label>
                </td>
                <td class="style3">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem>completed</asp:ListItem>
                        <asp:ListItem>pending</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                </td>
                <td class="style21">
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                </td>
                <td class="style11">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="style23">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td class="style17">
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td>
                <td class="style19">
                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                    <asp:Label ID="Label9" runat="server" Text="day(s)"></asp:Label>
                </td>
                <td class="style4">
                    <asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem>completed</asp:ListItem>
                        <asp:ListItem>pending</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="EXOProject.CustomerOrderHistoryTableAdapters.OrderTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_OID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="RID" Type="Int32" />
                <asp:Parameter Name="CID" Type="Int32" />
                <asp:Parameter Name="DateIn" Type="DateTime" />
                <asp:Parameter Name="DateOut" Type="DateTime" />
                <asp:Parameter Name="PaxCount" Type="Int32" />
                <asp:Parameter Name="RoomCount" Type="Int32" />
                <asp:Parameter Name="SpecialRequest" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="RID" Type="Int32" />
                <asp:Parameter Name="CID" Type="Int32" />
                <asp:Parameter Name="DateIn" Type="DateTime" />
                <asp:Parameter Name="DateOut" Type="DateTime" />
                <asp:Parameter Name="PaxCount" Type="Int32" />
                <asp:Parameter Name="RoomCount" Type="Int32" />
                <asp:Parameter Name="SpecialRequest" Type="String" />
                <asp:Parameter Name="Original_OID" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
