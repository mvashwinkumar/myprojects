<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="personal information new.aspx.cs" Inherits="EXOProject.Presentation.personal_information_new" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style12
        {
            width: 52%;
            height: 60px;
        }
        .style13
        {
            height: 60px;
            width: 203px;
        }
        .style14
        {
            width: 529px;
            height: 60px;
        }
        .style15
        {
            width: 52%;
            height: 59px;
        }
        .style16
        {
            height: 59px;
            width: 203px;
        }
        .style17
        {
            width: 529px;
            height: 59px;
        }
        .style18
        {
            width: 52%;
            height: 51px;
        }
        .style19
        {
            height: 51px;
            width: 203px;
        }
        .style20
        {
            width: 529px;
            height: 51px;
        }
        .style21
        {
            width: 52%;
            height: 71px;
        }
        .style22
        {
            width: 529px;
            height: 71px;
        }
        .style23
        {
            height: 71px;
            width: 203px;
        }
        .style24
        {
            width: 52%;
            height: 58px;
        }
        .style25
        {
            height: 58px;
            width: 203px;
        }
        .style26
        {
            width: 529px;
            height: 58px;
        }
        .style27
        {
            width: 52%;
            height: 63px;
        }
        .style28
        {
            height: 63px;
            width: 203px;
        }
        .style29
        {
            width: 529px;
            height: 63px;
        }
        .style30
        {
            width: 52%;
            height: 62px;
        }
        .style31
        {
            height: 62px;
            width: 203px;
        }
        .style32
        {
            width: 529px;
            height: 62px;
        }
        .style33
        {
            width: 52%;
            height: 67px;
        }
        .style34
        {
            height: 67px;
            width: 203px;
        }
        .style35
        {
            width: 529px;
            height: 67px;
        }
        .style36
        {
            width: 485px;
        }
        .style37
        {
            width: 1115px;
        }
        .style38
        {
            margin-left: 0px;
        }
    </style>
    <script language="javascript" type="text/javascript">
                function validateLength(source, arguments) {
                    arguements.IsValid = false;
                    if (arguements.Value.length > 9)
                        return;
                    arguements.IsValid = true;
                }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <table class="style1">
            <tr>
                <td class="style36">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="imgGuest" runat="server" 
                        ImageUrl="~/Presentation/Images/guest.png" />
                </td>
                <td class="style37">
                    <asp:Label ID="lbPernalinformation" runat="server" style="font-size: xx-large" 
                        Text="Personal Information"></asp:Label>
                </td>
            </tr>
        </table>
    <table class="style5">
        <tr>
            <td class="style12">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="style13">
                <asp:TextBox ID="txtName" runat="server" Width="150px" 
                    ontextchanged="txtName_TextChanged"></asp:TextBox>
            </td>
            <td class="style14">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtName" ErrorMessage="Please Enter Name" 
                    ForeColor="Red" Display="Dynamic" ToolTip="Please Enter Name" 
                    ValidationGroup="vd">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Passport NO."></asp:Label>
            </td>
            <td class="style16">
                <asp:TextBox ID="txtPassportNo" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style17">
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txtPassportNo" ErrorMessage="Please Enter Passport NO." 
                    ForeColor="Red" Display="Dynamic" ToolTip="Please Enter Passport NO." 
                    ValidationGroup="vd">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="style18">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Age"></asp:Label>
            </td>
            <td class="style19">
                <asp:TextBox ID="txtAge" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style20">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style21">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
            </td>
            <td class="style23">
                <asp:RadioButton ID="rdbMale" runat="server" Checked="True" GroupName="gender" 
                    Text="Male" />
                <asp:RadioButton ID="rdbFemale" runat="server" GroupName="gender" 
                    Text="Female" />
            </td>
            <td class="style22">
            </td>
        </tr>
        <tr>
            <td class="style24">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="style25">
                <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style26">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Please Enter Email" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    Display="Dynamic" ToolTip="Please Enter Email" ValidationGroup="vd">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style27">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Text="Mobile"></asp:Label>
            </td>
            <td class="style28">
                <asp:TextBox ID="txtMobile" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style29">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtMobile" Display="Dynamic" 
                    ErrorMessage="Please Enter Mobile Number" ForeColor="Red" 
                    ToolTip="Please Enter Mobile Number" 
                    ValidationExpression="\d{8}" ValidationGroup="vd">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="style16">
                <asp:TextBox ID="txtAddress" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style17">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Text="Next-Of-Kin Contact No."></asp:Label>
            </td>
            <td class="style16">
                <asp:TextBox ID="txtNOKContact" runat="server" Width="150px" CssClass="style38"></asp:TextBox>
            </td>
            <td class="style17">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="txtNOKContact" Display="Dynamic" 
                    ErrorMessage="Please Enter Contact Number" ForeColor="Red" 
                    ToolTip="Please Enter Contact Number" 
                    ValidationExpression="\d{8}" ValidationGroup="vd">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style30">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Text="Next-Of-Kin Name"></asp:Label>
            </td>
            <td class="style31">
                <asp:TextBox ID="txtNOKName" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style32">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style33">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label12" runat="server" Text="Next-Of-Kin Address"></asp:Label>
            </td>
            <td class="style34">
                <asp:TextBox ID="txtNOKAddress" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="style35">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style33">
            </td>
            <td class="style34">
                <asp:Button ID="btnRegister" runat="server" Text="Register" ValidationGroup="vd" OnClick="btnRegister_Click" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
            <td class="style35">
            </td>
        </tr>
    </table>
</asp:Content>
