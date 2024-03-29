﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Staionery_Inventory.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log in </title>
      <link rel="Stylesheet"  type="text/css" href="~/bootstrap/css/bootstrap.min.css" media="screen" />
       </head>
<body>
 <form id="form1" runat="server">
 <br /><br />
 <div class="container" >
 <div class="row" >
 <div class="col-md-8">
 <asp:Image ID="imgLogo" runat="server" ImageUrl="~/image/iss.jpg" CssClass="img-responsive" AlternateText="Inventory Logo" />
  </div>
 <div class="col-md-4">
 <div class="row ">
 <div class="col-sm-4">
<asp:Label ID="lblUserName" CssClass="text-info " runat="server" >UserName:</asp:Label>
</div>
<div class="col-sm-8">
<asp:TextBox ID="txtName" runat="server" CssClass="form-control text-center" placeholder="Please fill the Name" required />
</div>
</div>
<br />
<div class="row">
<div class="col-sm-4">
<asp:Label ID="lblPass" CssClass="text-info " runat="server" Text="Password:"></asp:Label>
</div>
<div class="col-sm-8">
<asp:TextBox ID="txtPass" runat="server" CssClass="form-control text-center" placeholder="Please fill the Password" TextMode="Password" required />
</div>
</div>
<br />
<div class="row">
<div class="col-sm-5" >
<asp:Button runat="server" ID="btnLogin" Text="Login" CssClass="btn btn-default" onclick="btnLogin_Click" 
         />
        
</div>
<div class="col-sm-7">
<asp:HyperLink ID="hlForgetPassword" runat="server" Text="Forget Password" />
</div>
</div>
<br />
<div class="row">
<asp:CheckBox ID="chkLogin" CssClass="col-sm-10 col-sm-offset-2 checkbox" runat="server" Text="Keep me logged in" />
</div>

<div class="row">
<asp:Label ID="lblLoginInfo" runat="server" CssClass="col-sm-12 text-danger" />
</div>
</div>
</div>
</div>
</form>
</body>
</html>