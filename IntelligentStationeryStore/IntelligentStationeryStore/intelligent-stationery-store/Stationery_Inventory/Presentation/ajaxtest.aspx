<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/master.Master" AutoEventWireup="true" CodeBehind="ajaxtest.aspx.cs" Inherits="Staionery_Inventory.Presentation.ajaxtest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <script type="text/javascript">
        var id = $("#TextBox1").val();
        $.ajax({
        type: POST,
        url: "ajaxtest.aspx/getItemName",
        contentType: "application/json",
        data: JSON.stringify({itemID: id}),
        dataType: "json"
        }).success(function(data){
        $("#Label1").val() = data.d;
        });
    </script>

</asp:Content>
