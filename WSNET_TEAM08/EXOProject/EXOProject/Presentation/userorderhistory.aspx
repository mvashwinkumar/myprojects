<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="userorderhistory.aspx.cs" Inherits="EXOProject.Presentation.userorderhistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="OID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" Height="211px" style="text-align: center" Width="1139px">
    <AlternatingRowStyle BackColor="PaleGoldenrod" />
    <Columns>
        <asp:BoundField DataField="OID" HeaderText="OID" InsertVisible="False" ReadOnly="True" SortExpression="OID" />
        <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="DateIn" HeaderText="DateIn" SortExpression="DateIn" />
        <asp:BoundField DataField="DateOut" HeaderText="DateOut" SortExpression="DateOut" />
        <asp:BoundField DataField="PaxCount" HeaderText="PaxCount" SortExpression="PaxCount" />
        <asp:BoundField DataField="RoomCount" HeaderText="RoomCount" SortExpression="RoomCount" />
        <asp:BoundField DataField="SpecialRequest" HeaderText="SpecialRequest" SortExpression="SpecialRequest" />
    </Columns>
    <FooterStyle BackColor="Tan" />
    <HeaderStyle BackColor="Tan" Font-Bold="True" />
    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    <SortedAscendingCellStyle BackColor="#FAFAE7" />
    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
    <SortedDescendingCellStyle BackColor="#E1DB9C" />
    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HotelDBConnectionString %>" SelectCommand="CustOrderHistory" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:SessionParameter Name="CID" SessionField="CustomerID" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
<asp:Label ID="lblErrorMsg" runat="server"></asp:Label>
<br />
</asp:Content>
