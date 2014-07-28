<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="suitedetail.aspx.cs" Inherits="EXOProject.Presentation.suitedetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 14%;
        }
        .style11
        {
            width: 15%;
        }
        .style12
        {
            width: 44%;
        }
        .style13
        {
            height: 23px;
            color: #336699;
        }
        .style14
        {
            color: #000000;
        }
        .style16
        {
            width: 1042px;
            height: 23px;
            text-align: left;
            color: rgb(51, 102, 153);
        }
        .style17
        {
            width: 1042px;
            height: 23px;
        }
        .style18
        {
            width: 890px;
        }
        .style19
        {
            width: 5%;
        }
        .style20
        {
            width: 10%;
        }
        .style21
        {
            color: #336699;
        }
        .style23
        {
            height: 20px;
            color: rgb(102, 102, 102);
        }
        .style24
        {
            color: rgb(0, 0, 0);
        }
        .style25
        {
            width: 1042px;
            height: 23px;
            text-align: left;
            color: rgb(102, 102, 102);
        }
        .style27
        {
            color: #666666;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style1" style="width: 1115px">
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style12">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <table class="style1" style="width: 1113px">
        <tr>
            <td class="style19">
                <asp:Image ID="ImageLS" runat="server" Height="120px" 
                    ImageUrl="~/Presentation/Images/paraz-loft.jpg" Width="200px" 
                    CssClass="style24" />
            </td>
            <td class="style18">
                <span class="style13"><strong>Loft</strong></span><br class="style24" />
                <span style="font-family: Arial, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;" 
                    class="style27">
                Enjoy an unforgettable experience in this charming suite with magical views of 
                Paris from every window. Accommodation features contemporary style furnishings 
                that retain a traditional feel. A large bedroom with plush king bed, desk and 
                workspace leads to a sitting area with fine furniture, a sofa and armchairs. The 
                fresh and light bathroom is finished in pale marble and has a separate shower 
                and bath. A walk in dressing room completes a generous space that is both lavish 
                and functional.</span></td>
            <td class="style12">
                <span class="style23">Average Daily Rate</span><br class="style25" />
                <span class="style21"><strong>65</strong></span><span class="style13"><strong>5.00 SGD</strong></span><br 
                    class="style25" />
                <span class="style23">Taxes/Fees may apply</span></td>
            <td>
                <asp:Button ID="btnBookLS" runat="server" Font-Bold="True" Text="Book" 
                    CssClass="style24" OnClick="btnBookLS_Click" />
            </td>
        </tr>
    </table>
    <table class="style1" style="width: 1117px">
        <tr>
            <td class="style20">
                <asp:Image ID="ImageES" runat="server" Height="120px" 
                    ImageUrl="~/Presentation/Images/paraz-exec-suite.jpg" Width="200px" 
                    CssClass="style14" />
            </td>
            <td class="style17">
                <strong><span class="style21">Executive Suite</span><br class="style21" />
                <span style="font-family: Arial, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;" 
                    class="style27">
                These large rooms benefit from exceptional views on surrounding monuments or on 
                our inner courtyard. Each one is unique: some are traditional &quot;Napoleon Second 
                Empire&quot; style, others are contemporary style and mix luxurious fabrics. A large 
                bedroom leads to a separate living room with fine furniture, a sofa and 
                armchairs. The dressing room is ideal for log stays. Bathrooms are large, in 
                pale marble or white tiles and most of the time bath and walk-in shower with 
                double sink.</span></strong></td>
            <td class="style12">
                <span class="style23">Average Daily Rate</span><br class="style16" />
                <span class="style21"><strong>725</strong></span><span class="style13"><strong>.00 SGD</strong></span><br 
                    class="style16" />
                <span class="style23">Taxes/Fees may apply</span></td>
            <td>
                <asp:Button ID="btnBookES" runat="server" Font-Bold="True" Text="Book" 
                    CssClass="style14" OnClick="btnBookES_Click" />
            </td>
        </tr>
    </table>
    <div style="width: 1112px">
    
        <table class="style1" style="width: 1115px">
            <tr>
                <td class="style11">
                    <asp:Image ID="ImagePS" runat="server" Height="120px" 
                        ImageUrl="~/Presentation/Images/paraz-pisarro.jpg" Width="200px" />
                </td>
                <td class="style17">
                    <strong><span class="style21">Pissaro</span><br />
                    <span style="color: rgb(102, 102, 102); font-family: Arial, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
                    The ultimate in Parisian luxury, the Pissarro suite offers an opportunity to be 
                    immersed in the colourful history of the hotel.&nbsp; From the floor-to-ceiling 
                    windows, appreciate the outlook that inspired the artist Pissarro to paint his 
                    impressionist views of Paris. The room colours are inspired by his paintings 
                    with soft grey walls, warm tones of amber. There are two large bathrooms: one 
                    with a Jacuzzi and one with an Hammam. Uninterrupted views of the Opera Garnier 
                    from the Jacuzzi allow you to lie in the bath and marvel. This well furnished 
                    one bedroom suite will make your stay with us a truly unique experience.</span></strong></td>
                <td class="style12">
                    <span class="style23">Average Daily Rate</span><br class="style4" />
                    <span class="style21"><strong>900</strong></span><span class="style13"><strong>.00 SGD</strong></span><br class="style4" />
                    <span class="style23">Taxes/Fees may apply</span></td>
                <td>
                    <asp:Button ID="btnBookPS" runat="server" Font-Bold="True" Text="Book" OnClick="btnBookPS_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
