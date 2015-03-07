<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

   <h1>Welcome To The Travel Experts Customer Portal</h1> 

    <h3 class="invisible">&nbsp;</h3>
    <p class="invisible"></p>

    <asp:Panel ID="pnlGreeting" runat="server" Visible="False">
       <h3> Thank you,&nbsp;
        <asp:Label ID="lblWelcomeName" runat="server"></asp:Label>
        ! Would you like to <a href="CustomerInfo.aspx">edit your account information</a>, or view your <a href="CustomerBookings.aspx">package bookings</a>?
           </h3>
    </asp:Panel>

</asp:Content>
