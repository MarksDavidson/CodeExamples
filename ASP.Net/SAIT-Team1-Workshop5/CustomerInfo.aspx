<%@ Page Title="Customer Account Information" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomerInfo.aspx.cs" Inherits="Default2" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <hgroup class="title">

        <h1><%: Title %>.</h1>
        <h2>Use this page to edit your account information.</h2>
    </hgroup>

    <!--Darcie Milliken -->

    <!-- When the customer logs in, the customer's data is displayed in view mode. -->

    <!-- The form validates that the first and last name fields are nonempty -->

    <!-- Listview that displays the data -->

    <div style="margin-right: auto; margin-left: auto; height: 420px; z-index:2; top: 459px; width: 118px; left: 441px; text-align:center">

        <br />
        <asp:ListView ID="ListView1" runat="server" DataSourceID="CustomerDataEdit" >
            
            <EditItemTemplate>
                <span style="">
                    <%--CustomerID:
                <asp:TextBox ID="CustomerIDTextBox" runat="server" Readonly="true" Text='<%# Bind("CustomerID") %>' />--%>
                    <%--&nbsp;<asp:TextBox ID="CustomerIDTextBox" runat="server" Text='<%# Bind("CustomerID") %>' />--%>

                    <br />
                    First Name:
                <asp:TextBox ID="CustFirstNameTextBox" runat="server" Text='<%# Bind("CustFirstName") %>' />
                    <br />
                    Last Name:
                <asp:TextBox ID="CustLastNameTextBox" runat="server" Text='<%# Bind("CustLastName") %>' />
                    <br />
                    Address:
                <asp:TextBox ID="CustAddressTextBox" runat="server" Text='<%# Bind("CustAddress") %>' />
                    <br />
                    Municipality:
                <asp:TextBox ID="CustCityTextBox" runat="server" Text='<%# Bind("CustCity") %>' />
                    <br />
                    Province:
                <asp:TextBox ID="CustProvTextBox" runat="server" Text='<%# Bind("CustProv") %>' />
                    <br />
                    Postal Code:
                <asp:TextBox ID="CustPostalTextBox" runat="server" Text='<%# Bind("CustPostal") %>' />
                    <br />
                    Country:
                <asp:TextBox ID="CustCountryTextBox" runat="server" Text='<%# Bind("CustCountry") %>' />
                    <br />
                    Home Phone:
                <asp:TextBox ID="CustHomePhoneTextBox" runat="server" Text='<%# Bind("CustHomePhone") %>' />
                    <br />
                    Business Phone:
                <asp:TextBox ID="CustBusPhoneTextBox" runat="server" Text='<%# Bind("CustBusPhone") %>' />
                    <br />
                    <%--    AgentId:
                <asp:TextBox ID="AgentIdTextBox" runat="server" Text='<%# Bind("AgentId") %>' />--%>
                    Email: &nbsp;<asp:TextBox ID="CustEmailTextBox" runat="server" Text='<%# Bind("CustEmail") %>' />
                    <%--<br />
                    AgentId:
                <asp:TextBox ID="AgentIdTextBox" runat="server" Text='<%# Bind("AgentId") %>' />
                    <br />
                    UserId:
                <asp:TextBox ID="UserIdTextBox" runat="server" Text='<%# Bind("UserId") %>' />
                <br />
                CustPassword:
                <asp:TextBox ID="CustPasswordTextBox" runat="server" Text='<%# Bind("CustPassword") %>' />
                <br />--%>
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    <br />
                    <br />
                </span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            
            <ItemTemplate>
                <span style="">
                    <%--CustomerID:
                <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />--%>
                    <%--&nbsp;<asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />--%>
                    <br />
                    <table width ="300px"> 
                        <tr>
                            <td>First Name: </td>
                            <td> <asp:Label ID="CustFirstNameLabel" runat="server" Text='<%# Eval("CustFirstName") %>' /> </td>
                        </tr> 
                         <tr>
                            <td>Last Name: </td>
                            <td> <asp:Label ID="CustLastNameLabel" runat="server" Text='<%# Eval("CustLastName") %>' /> </td>
                        </tr>
                        <tr>
                            <td> Address: </td>
                            <td> <asp:Label ID="CustAddressLabel" runat="server" Text='<%# Eval("CustAddress") %>' /> </td>
                        </tr>
                        <tr>
                            <td> City: </td>
                            <td> <asp:Label ID="CustCityLabel" runat="server" Text='<%# Eval("CustCity") %>' /> </td>
                        </tr>
                        <tr>
                            <td> Province: </td>
                            <td> <asp:Label ID="CustProvLabel" runat="server" Text='<%# Eval("CustProv") %>' /> </td>
                        </tr>
                        <tr>
                            <td> Postal Code: </td>
                            <td> <asp:Label ID="CustPostalLabel" runat="server" Text='<%# Eval("CustPostal") %>' /> </td>
                        </tr>
                        <tr>
                            <td> Country: </td>
                            <td> <asp:Label ID="CustCountryLabel" runat="server" Text='<%# Eval("CustCountry") %>' /> </td>
                        </tr>
                        <tr>
                            <td> Home Phone: </td>
                            <td> <asp:Label ID="CustHomePhoneLabel" runat="server" Text='<%# Eval("CustHomePhone") %>' /> </td>
                        </tr>
                        <tr>
                            <td> Business Phone: </td>
                            <td> <asp:Label ID="CustBusPhoneLabel" runat="server" Text='<%# Eval("CustBusPhone") %>' /> </td>
                        </tr>
                    </table>
                    
                    <%--AgentId:
                <asp:Label ID="AgentIdLabel" runat="server" Text='<%# Eval("AgentId") %>' />--%>
                   <%-- &nbsp;<asp:Label ID="CustEmailLabel" runat="server" Text='<%# Eval("CustEmail") %>' />
                    <br />
                    AgentId:
                <asp:Label ID="AgentIdLabel" runat="server" Text='<%# Eval("AgentId") %>' />
                    <br />
                    UserId:
                <asp:Label ID="UserIdLabel" runat="server" Text='<%# Eval("UserId") %>' />
                <br />
                CustPassword:
                <asp:Label ID="CustPasswordLabel" runat="server" Text='<%# Eval("CustPassword") %>' />
                <br />--%>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    <br />
                    <br />
                </span>
            </ItemTemplate>
            <LayoutTemplate>
                <div id="itemPlaceholderContainer" runat="server" style="">
                    <span runat="server" id="itemPlaceholder" />
                </div>
                <div style="">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <span style="">
                    <%--CustomerID:
                <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />--%>
                    &nbsp;<asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />
                    <br />
                    CustFirstName:
                <asp:Label ID="CustFirstNameLabel" runat="server" Text='<%# Eval("CustFirstName") %>' />
                    <br />
                    CustLastName:
                <asp:Label ID="CustLastNameLabel" runat="server" Text='<%# Eval("CustLastName") %>' />
                    <br />
                    CustAddress:
                <asp:Label ID="CustAddressLabel" runat="server" Text='<%# Eval("CustAddress") %>' />
                    <br />
                    CustCity:
                <asp:Label ID="CustCityLabel" runat="server" Text='<%# Eval("CustCity") %>' />
                    <br />
                    CustProv:
                <asp:Label ID="CustProvLabel" runat="server" Text='<%# Eval("CustProv") %>' />
                    <br />
                    CustPostal:
                <asp:Label ID="CustPostalLabel" runat="server" Text='<%# Eval("CustPostal") %>' />
                    <br />
                    CustCountry:
                <asp:Label ID="CustCountryLabel" runat="server" Text='<%# Eval("CustCountry") %>' />
                    <br />
                    CustHomePhone:
                <asp:Label ID="CustHomePhoneLabel" runat="server" Text='<%# Eval("CustHomePhone") %>' />
                    <br />
                    CustBusPhone:
                <asp:Label ID="CustBusPhoneLabel" runat="server" Text='<%# Eval("CustBusPhone") %>' />
                    <br />
                    <%--  AgentId:
                <asp:Label ID="AgentIdLabel" runat="server" Text='<%# Eval("AgentId") %>' />--%>
                    Email: 
                    &nbsp;<asp:Label ID="CustEmailLabel" runat="server" Text='<%# Eval("CustEmail") %>' />
                    <br />
                    AgentId:
                <asp:Label ID="AgentIdLabel" runat="server" Text='<%# Eval("AgentId") %>' />
                    <br />
                    UserId:
                <asp:Label ID="UserIdLabel" runat="server" Text='<%# Eval("UserId") %>' />
                <br />
                CustPassword:
                <asp:Label ID="CustPasswordLabel" runat="server" Text='<%# Eval("CustPassword") %>' />
                <br />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    <br />
                    <br />
                </span>
            </SelectedItemTemplate>
        </asp:ListView>
        <!-- Data source and inputs-->
        <asp:ObjectDataSource ID="CustomerDataEdit" runat="server" DataObjectTypeName="System.Customer" DeleteMethod="DeleteCustomer" InsertMethod="AddCustomer" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCustomerByID" TypeName="CustomerDB" UpdateMethod="UpdateCustomer" ConflictDetection="CompareAllValues">
            <SelectParameters>
                <asp:SessionParameter Name="customerID" SessionField="customer" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="original_customer" Type="Object" />
                <asp:Parameter Name="customer" Type="Object" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <br />
    </div>
</asp:Content>
