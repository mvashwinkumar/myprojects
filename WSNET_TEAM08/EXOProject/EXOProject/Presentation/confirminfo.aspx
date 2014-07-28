<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/CA.Master" AutoEventWireup="true" CodeBehind="confirminfo.aspx.cs" Inherits="EXOProject.Presentation.confirminfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
            width: 126%;
        }
        .style10
        {
            width: 25%;
            height: 204px;
        }
        .style15
        {
            width: 243px;
            height: 204px;
        }
        .style16
        {
            width: 207px;
            color: #666666;
            height: 204px;
        }
        .style17
        {
            width: 413px;
        }
        .style18
        {
            width: 434px;
        }
        .style19
        {
            height: 237px;
            color: #666666;
        }
        .style21
        {
            width: 1042px;
            height: 23px;
            text-align: left;
            color: #666666;
        }
        .style22
        {
            width: 413px;
            color: #666666;
        }
        .style23
        {
            height: 237px;
            color: #666666;
            font-weight: normal;
        }
        .style24
        {
            font-weight: normal;
        }
        .style25
        {
            height: 46px;
            color: #666666;
            font-weight: normal;
        }
        .style26
        {
            width: 100%;
            font-weight: normal;
        }
        .style27
        {
            width: 1042px;
            height: 23px;
            text-align: left;
            color: #666666;
            font-size: small;
        }
        .style28
        {
            margin-left: 80px;
        }
        .auto-style1 {
            width: 84px;
            color: #666666;
            height: 204px;
        }
        .auto-style2 {
            width: 172%;
        }
        .auto-style3 {
            width: 239px;
        }
        .auto-style5 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
    
        <h3>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Confirm Information</h3>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    
    </div>
    <table class="style1" style="width: 1066px">
        <tr>
            <td class="style10">
                <asp:Image ID="imgOrder" runat="server" Height="200px" CssClass="style28" />
            </td>
            <td class="auto-style1">
                <h4 style="width: 142px">
                    <span class="style25">EXO World Hotel</span><span class="style26"><br 
                        class="style21" />
                    </span><span class="style25">27 Bukit Manis Road</span><span class="style26"><br 
                        class="style21" />
                    </span><span class="style25">Singapore,099892</span><span class="style26"><br 
                        class="style21" />
                    </span><span class="style25">+65 62750090</span></h4>
            </td>
            <td class="style15">
                &nbsp;
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="lblDateIn" runat="server" Text="Date In :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtDateIn" runat="server"></asp:TextBox>
                            <asp:ImageButton ID="btnDateInCal" runat="server" Height="17px" ImageUrl="~/Presentation/Images/calendar.png" OnClick="btnDateInCal_Click" />
                            <br />
                            <asp:Label ID="lblDateOut" runat="server" Text="Date Out :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtDateOut" runat="server"></asp:TextBox>
                            <asp:ImageButton ID="btnDateOutCal" runat="server" Height="17px" ImageUrl="~/Presentation/Images/calendar.png" OnClick="btnDateOutCal_Click" />
                            <br />
                            <asp:Label ID="lblPaxCnt" runat="server" Text="No. of Pax :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPaxCount" runat="server"></asp:TextBox>
                            <br />
                            <asp:Label ID="lblRoomCnt" runat="server" Text="No. of Rooms :"></asp:Label>
&nbsp;<asp:TextBox ID="txtRoomCount" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Calendar ID="CalendarDateIn" runat="server" OnSelectionChanged="CalendarDateIn_SelectionChanged" Visible="False"></asp:Calendar>
                            <asp:Calendar ID="CalendarDateOut" runat="server" OnSelectionChanged="CalendarDateOut_SelectionChanged" Visible="False"></asp:Calendar>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Summary :"></asp:Label>
                <br />
                <asp:TextBox ID="txtSummary" runat="server" Height="101px" Width="444px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Amenities :"></asp:Label>
                <br />
                <asp:TextBox ID="txtAmenities" runat="server" Height="76px" Width="450px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style15">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Special Requests :"></asp:Label>
                <br />
                <asp:TextBox ID="txtSpecialRequest" runat="server" Height="148px" TextMode="MultiLine" Width="335px"></asp:TextBox>
                <br />
                </td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <table class="style1" style="width: 1072px; margin-right: 0px">
        <tr>
            <td class="style17">
                &nbsp;</td>
            <td class="style18">
                <asp:Button ID="btnChkAvail" runat="server" OnClick="btnChkAvail_Click" Text="Check Availability" />
&nbsp;&nbsp;
                <asp:Label ID="lblAvailStatus" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style22">
                <h5 class="style25" style="width: 556px">
                    Note: Additional Fare subjected to special requests will be charged at hotel as per policy if they are fulfilled.</h5>
                <h5 class="style25" style="width: 555px">
                    Changes in taxes or fees will affect total price. 
                    Total rate in hotel currency is guaranteed. Total rate in your&nbsp; selected currency 
                    will vary&nbsp;&nbsp; with fluctuations in exchange rate.</h5>
            </td>
            <td class="style18">
                <table class="auto-style5">
                    <tr>
                        <td>Per Night Fare :</td>
                        <td>
                            <asp:Label ID="lblPerNightFare" runat="server"></asp:Label>
                        </td>
                        <td>SGD</td>
                    </tr>
                    <tr>
                        <td>No. of Nights :</td>
                        <td>
                            <asp:Label ID="lblNumNights" runat="server"></asp:Label>
                        </td>
                        <td>Days</td>
                    </tr>
                    <tr>
                        <td>Total Fare payable :</td>
                        <td>
                            <asp:Label ID="lblTotalFare" runat="server"></asp:Label>
                        </td>
                        <td>SGD</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style17">
                &nbsp;</td>
            <td class="style18">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnConf" runat="server" Font-Bold="True" Text="Confirm" 
                    onclick="btnConf_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Font-Bold="True" Text="Cancel" OnClick="btnCancel_Click" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
