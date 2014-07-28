<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="executivedetail.aspx.cs" Inherits="EXOProject.Presentation.executivedetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 53%;
        }
        .style11
        {
            width: 14%;
        }
        .style12
        {
            width: 35%;
        }
        .style13
        {
            width: 1110px;
        }
        .style14
        {
            height: 23px;
            color: #336699;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <table class="style1" style="width: 1107px">
            <tr>
                <td class="style11">
                    <asp:Image ID="imgEK" runat="server" Height="120px" 
                        ImageUrl="~/Presentation/Images/paraz-executive.jpg" Width="200px" />
                </td>
                <td class="style13">
                    <asp:Label ID="LabelStanKing" runat="server" Font-Bold="True" 
                        ForeColor="#336699" Text="King"></asp:Label>
                    <br />
                    <span style="color: rgb(102, 102, 102); font-family: Arial, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
                    Enjoy a typical Paris experience. Rooms benefit from exceptional views on 
                    surrounding monuments or on our inner courtyard. Each one is unique : some are 
                    traditional &quot;Napoleon Second Empire&quot; style, others are contemporary style and 
                    mix luxurious fabrics. The large bedroom features a sitting room with sofa and 
                    chairs, spacious work area and a plush king bed.&nbsp; Bathrooms are large, in pale 
                    marble or white tiles and most of the time bath and walk-in shower with double 
                    sink.</span></td>
                <td class="style12">
                    <span class="style8">Average Daily Rate</span><br class="style4" />
                    <span class="style14"><strong>525.00 SGD</strong></span><br class="style4" />
                    <span class="style8">Taxes/Fees may apply</span></td>
                <td>
                    <asp:Button ID="btnBookEK" runat="server" Font-Bold="True" Text="Book" OnClick="btnBookEK_Click" />
                </td>
            </tr>
        </table>
    
  
    <table class="style10">
        <tr>
            <td>
                <h3 class="listItems" 
                    style="border-top: 1px solid rgb(207, 205, 205); margin: 0px; padding: 10px 0px 5px; text-transform: none; font-family: Arial, Arial; font-weight: bold; font-size: 13px; color: rgb(102, 102, 102); font-style: normal; font-variant: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 232, 232); width: 485px;">
                    Amenities:</h3>
                <div class="threeColList" 
                    style="margin: 0px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 232, 232);">
                    <ul style="margin: 5px 0px 0px; padding: 0px; list-style: disc outside none; overflow: hidden; height: 142px; width: 552px;">
                        <ul class="splitCols1" 
                            style="margin: 5px 0px 0px; padding: 0px; list-style: disc outside none; width: 183.46875px; float: left; overflow: hidden;">
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Room size: Around 30-40 sq meters / 323-430 sq feet<br />
                            </li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Views on Paris landmarks or into the quiet inner courtyard</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Living Room</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Free Wi-Fi</li>
                        </ul>
                        <ul class="splitCols2" 
                            style="margin: 5px 0px 0px; padding: 0px; list-style: disc outside none; width: 183.46875px; float: left; overflow: hidden;">
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Bose sound system</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                24/7 Room Service</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Air Conditioning</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Plasma screen TV with Satellite Channels</li>
                        </ul>
                        <ul class="splitCols3" 
                            style="margin: 5px 0px 0px; padding: 0px; list-style: disc outside none; width: 183.46875px; float: left; overflow: hidden;">
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                In-Room Annick Goutal Welcoming Products</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Bathrobes and slippers</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                In-Room Safe</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Minibar</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Hairdryer</li>
                        </ul>
                    </ul>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
