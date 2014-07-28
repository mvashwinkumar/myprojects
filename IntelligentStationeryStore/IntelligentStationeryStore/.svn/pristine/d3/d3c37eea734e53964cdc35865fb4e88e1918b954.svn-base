<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/master.Master" AutoEventWireup="true" CodeBehind="SearchItemsPage.aspx.cs" Inherits="Staionery_Inventory.Presentation.Search.SearchItemsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<div class="row">
<div class="col-md-3">
<asp:Label ID="lblSearchItemName" runat="server" CssClass="text-info" Text="Item Name:" />
</div>
<div class="col-md-7">
<asp:TextBox ID="txtSearchItemName" runat="server" CssClass="form-control text-left" />
</div>
<div class="col-md-2">
    <asp:Button ID="btnSearchItemName" runat="server" Text="Search" 
        CssClass="btn btn-default" onclick="btnSearchItemName_Click" />
</div>
</div>
<br />
<div class="row">
<div class="col-md-6">
    <div class="col-md-4">
    <asp:Label ID="lblFilterBy" runat="server" CssClass="text-info" Text="Filter by:"/>
    </div>
    <div class="col-md-4">
    <asp:RadioButton ID="rbtItemCategory" runat="server" Text="Category" 
            GroupName="rbtgpFilter" />
    </div>
    <div class="col-md-4">
    <asp:RadioButton ID="rbtSupplierID" runat="server" Text="SupplierID" 
            GroupName="rbtgpFilter" />
    </div>
</div>
<div class="col-md-4">    
    <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control" />
</div>
<div class="col-md-2">
    <asp:Button ID="btnFilter" runat="server" Text="Filter" 
        CssClass="btn btn-default" onclick="btnFilter_Click" />
</div>
</div>

<br />

<div class="row">
    <asp:GridView ID="gvSearchItems" runat="server" 
    CssClass="col-sm-12 table table-striped table-bordered table-hover"
    AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="ItemID" HeaderText="Item ID" >
        <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Description" HeaderText="Item Name" >
        <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="UnitofMeasure" HeaderText="UOM" />
        <asp:BoundField DataField="QtyLeft" HeaderText="Qty Left" />
        <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                    
                    <asp:CheckBox ID="cbSelectItem" runat="server"   />
                    
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
    </Columns>
    </asp:GridView>
</div>
<br />

<div class="row">
<div class="col-md-2 col-md-offset-8">
<asp:Button ID="btnSelectItems" runat="server" Text="Select" 
        CssClass="btn btn-primary" onclick="btnSelectItems_Click" />
</div>
<div class="col-md-2">
<asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-default" 
        onclick="btnCancel_Click" />
</div>
</div>

</asp:Content>
