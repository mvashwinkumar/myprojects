﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/master.Master" AutoEventWireup="true" CodeBehind="StationeryRequisitionForm.aspx.cs" Inherits="Staionery_Inventory.StationeryRequisitionForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<div class="row">
<asp:Label ID="lblRequestID" runat="server" CssClass="col-md-3 col-md-offset-9 text-info" Text="" />
</div>
<div class="row">
<asp:Label ID="lblDepartment" runat="server" CssClass="col-md-3 text-info" Text="Department Name:" />
<asp:Label ID="lblDepartmentName" runat="server" CssClass="col-md-9 text-info" Text=""  />
</div>
<br />

<div class="row">
<asp:GridView runat="server"  ID="gvStationeryRequisition" 
        CssClass="col-sm-12 table table-striped table-bordered table-hover"  
        AutoGenerateColumns="False" 
        onrowdeleting="gvStationeryRequisition_RowDeleting" >
       <Columns>
             <asp:BoundField DataField="Des1" HeaderText="ItemName" />
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQuatity" runat="server" CssClass="text-left" Text='<%# Eval("Quan1") %>' ></asp:TextBox>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Justify" />
                </asp:TemplateField>
                <asp:BoundField DataField="Umeasure" HeaderText="Unit of Measurement" >
                <ItemStyle HorizontalAlign="Justify" />
                </asp:BoundField>
              <asp:CommandField ShowDeleteButton="True" >
              <ItemStyle HorizontalAlign="Justify" CssClass="btn-default" />
              </asp:CommandField>
            </Columns>
</asp:GridView>
</div>

<div class="row">
<div class="col-md-2">
<asp:label ID="lblSpecialRequest" runat="server" Text="Special Request" CssClass="text-info" />
</div>
<div class="col-md-2">
<asp:TextBox ID="txtSpecialRequest" runat="server" placeholder="Please fill your special request" TextMode="MultiLine" CssClass="text-left"></asp:TextBox>
</div>
</div>

<br />

<div class="row">
<div class="col-md-2">
<asp:Button ID="btnsubmit" runat="server" Text="Submit" CssClass="btn btn-default" 
        OnClientClick="Confrim()" onclick="btnsubmit_Click" />
        <asp:HiddenField ID="hfconfirm" runat="server" ClientIDMode="Static" />
</div>
<div class="col-md-2 ">
<asp:Button ID="btnAddmore" runat="server" Text="Add more" CssClass="btn btn-default" />

</div>
</div>
</asp:Content>
