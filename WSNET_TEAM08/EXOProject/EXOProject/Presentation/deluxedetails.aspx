<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="deluxedetails.aspx.cs" Inherits="EXOProject.Presentation.deluxedetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 54%;
        }
        .style11
        {
            width: 15%;
        }
        .style13
        {
            width: 14%;
        }
        .style15
        {
            height: 23px;
            color: #336699;
        }
        .style18
        {
            width: 807px;
        }
        .style19
        {
            width: 1490px;
        }
        .style20
        {
            width: 45px;
        }
        .style22
        {
            width: 16px;
        }
        .style23
        {
            height: 20px;
            color: #666666;
        }
        .style24
        {
            width: 1042px;
            height: 23px;
            text-align: left;
            color: #666666;
        }
        .style25
        {
            margin-left: 0px;
        }
        .style26
        {
            width: 24%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <table class="style1" style="height: 109px; width: 1094px">
            <tr>
                <td class="style11">
                    <asp:Image ID="imgDK" runat="server" Height="120px" 
                        ImageUrl="~/Presentation/Images/paraz-deluxe.jpg" Width="200px" />
                </td>
                <td class="style19">
                    <asp:Label ID="LabelStanKing" runat="server" Font-Bold="True" 
                        ForeColor="#336699" Text="King"></asp:Label>
                    <br />
                    <span style="color: rgb(102, 102, 102); font-family: Arial, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
                    These rooms are spacious and welcoming. Throught the Parisian double windows 
                    look out over the spectacular surroundings or our quiet inner courtyard. 
                    Experience a true French décor, with contemporary touches. Lean back and 
                    appreciate the reading area,&nbsp; with comfortable chairs and a low table&nbsp; Bathrooms 
                    are light and airy with white tiles or pale marble.</span></td>
                <td class="style26">
                    <span class="style23">Average Daily Rate</span><br class="style24" />
                    <span class="style15"><strong>415.00 SGD</strong></span><br class="style24" />
                    <span class="style23">Taxes/Fees may apply</span></td>
                <td class="style20">
                    <asp:Button ID="btnBookDK" runat="server" Font-Bold="True" Text="Book" OnClick="btnBookDK_Click" />
                </td>
            </tr>
        </table>
    
    <table class="style1" style="width: 1097px">
        <tr>
            <td class="style13">
                <asp:Image ID="ImgDT" runat="server" Height="120px" 
                    ImageUrl="~/Presentation/Images/paraz-deluxe.jpg" Width="200px" 
                    CssClass="style25" />
            </td>
            <td class="style18">
                <span class="style15"><strong>Twin</strong></span><br />
                <span style="color: rgb(102, 102, 102); font-family: Arial, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
                These rooms are spacious and welcoming. Throught the Parisian double windows 
                look out over the spectacular surroundings or our quiet inner courtyard. 
                Experience a true French décor, with contemporary touches. Lean back and 
                appreciate the reading area,&nbsp; with comfortable chairs and a low table&nbsp; Bathrooms 
                are light and airy with white tiles or pale marble.</span></td>
            <td class="style26">
                <span class="style23">Average Daily Rate</span><br class="style24" />
                <span class="style15"><strong>415.00 SGD</strong></span><br class="style24" />
                <span class="style23">Taxes/Fees may apply</span></td>
            <td class="style22">
                <asp:Button ID="btnBookDT" runat="server" Font-Bold="True" Text="Book" 
                    Width="53px" OnClick="btnBookDT_Click" />
            </td>
        </tr>
    </table>
    
    <table class="style10">
        <tr>
            <td>
                <h3 class="style1" 
                    
                    style="border-top: 1px solid rgb(207, 205, 205); margin: 0px; padding: 10px 0px 5px; text-transform: none; font-family: Arial, Arial; font-weight: bold; font-size: 13px; color: rgb(102, 102, 102); font-style: normal; font-variant: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 232, 232); width: 364px;">
                    Amenities:</h3>
                <div class="threeColList" 
                    style="margin: 0px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 232, 232);">
                    <ul style="margin: 5px 0px 0px; padding: 0px; list-style: disc outside none; overflow: hidden; color: rgb(102, 102, 102); font-family: Arial, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 232, 232); height: 122px; width: 551px;">
                        <ul class="splitCols1" 
                            style="margin: 5px 0px 0px; padding: 0px; list-style: disc outside none; width: 183.46875px; float: left; overflow: hidden;">
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Room size: Around 15-25 sq meters / 161-290 sq feet</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Breathtaking views on Paris landmarks</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Free Wi-Fi</li>
                        </ul>
                        <ul class="splitCols2" 
                            style="margin: 5px 0px 0px; padding: 0px; list-style: disc outside none; width: 183.46875px; float: left; overflow: hidden;">
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                24/7 Room Service</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Air Conditioning</li>
                            <li style="margin: 0px 6px 2px 18px; padding: 0px; font-family: Arial, sans-serif; color: rgb(102, 102, 102); line-height: 18px; font-size: 12px;">
                                Plasma Screen TV with Satellite Channels</li>
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
            </td>
        </tr>
    </table>
</asp:Content>
