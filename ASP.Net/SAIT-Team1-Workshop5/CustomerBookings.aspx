<%@ Page Title="Customer Booking Information" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomerBookings.aspx.cs" Inherits="Default2" StyleSheetTheme="Second" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
   
    <hgroup class="title">
        
        <h1><%: Title %>.</h1>
        <h2>Use this page to display information about your travel bookings.</h2>
    </hgroup>

    <!--Darcie Milliken -->

    <!-- This control displays the customer's bookings/packages in display mode only. -->
    
    <div style="margin-right: auto; margin-left: auto; height: 420px; z-index:2; top: 459px; width: 118px; left: 441px; text-align:center">
        
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="CustomerBookingsPackages" Height="132px" Width="628px" CellPadding="5" >
            <Columns>
                <%--<asp:BoundField DataField="PackageID" HeaderText="PackageID" SortExpression="PackageID" />--%>
                <%--<asp:BoundField DataField="PackageID" HeaderText="PackageID" SortExpression="PackageID" />--%>
                <asp:BoundField DataField="PkgName" HeaderText="Package Name" SortExpression="PkgName" />
                <asp:BoundField DataField="PkgStartDate" HeaderText="Start Date" SortExpression="PkgStartDate" />
                <asp:BoundField DataField="PkgEndDate" HeaderText="End Date" SortExpression="PkgEndDate" />
                <asp:BoundField DataField="PkgDesc" HeaderText="Description of Package" SortExpression="PkgDesc" />
                <%--<asp:BoundField DataField="PkgAgencyCommission" HeaderText="PkgAgencyCommission" SortExpression="PkgAgencyCommission" />--%>
                <asp:BoundField DataField="PkgBasePrice" HeaderText="Price" SortExpression="PkgBasePrice" />
                <%--<asp:BoundField DataField="PkgAgencyCommission" HeaderText="PkgAgencyCommission" SortExpression="PkgAgencyCommission" />--%>
                <asp:BoundField DataField="BookingDate" HeaderText="Booking Date" SortExpression="BookingDate" />
                <asp:BoundField DataField="BookingNo" HeaderText="Booking #" SortExpression="BookingNo" />
         </Columns>
        </asp:GridView>

        <!-- Label that displays the total -->
        <div style="position:relative;">
        <asp:Label ID="Label1" runat="server" Text="<strong>Total:</strong>" Style="position: absolute; left: 341px; color:red;"></asp:Label>
        <asp:Label ID="lbltotal" runat="server" Style="position: absolute; left: 380px; font-weight:bold; color:red;"></asp:Label>
            </div>
        <br />
        <br />

        <asp:ObjectDataSource ID="CustomerBookingsPackages" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetPackagesFromCustomers" TypeName="PackagesDB">
            <SelectParameters>
                <asp:SessionParameter Name="customerId" SessionField="customer" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
