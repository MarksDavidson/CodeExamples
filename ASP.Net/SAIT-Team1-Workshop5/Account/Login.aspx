<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>
    
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <link href="Login.css" rel="stylesheet" type="text/css" />
     <hgroup class="title">
        <h2><asp:Login runat="server" ID="Login1" CssClass="Login" BackColor="#FFFFFF" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" >
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
           
            <LayoutTemplate>

                <fieldset>
                    <legend>Log in Form</legend>
                    <asp:Table runat="server" style="width: 703px">
                        <asp:TableRow runat="server" >  
                           <asp:TableCell runat="server"> <asp:Label runat="server" AssociatedControlID="UserName">Email</asp:Label></asp:TableCell>
                           <asp:TableCell runat="server"> <asp:TextBox runat="server" ID="UserName" Width="211px" style="margin-left: 7px" /></asp:TableCell><asp:TableCell runat="server"><asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." ForeColor="Red" /></asp:TableCell></asp:TableRow><asp:TableRow runat="server" >  
                           <asp:TableCell runat="server"> <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label></asp:TableCell><asp:TableCell runat="server"><asp:TextBox runat="server" ID="Password" TextMode="Password" Width="211px" style="margin-left: 7px" /> </asp:TableCell><asp:TableCell runat="server"><asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="The password field is required." ForeColor="Red" /></asp:TableCell></asp:TableRow><asp:TableRow runat="server" >  
                           <asp:TableCell runat="server"></asp:TableCell><asp:TableCell runat="server"><asp:CheckBox runat="server" ID="RememberMe" height="16px" Width="18px" /> <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Remember me?</asp:Label></asp:TableCell><asp:TableCell runat="server"> </asp:TableCell></asp:TableRow></asp:Table><asp:Button runat="server" CommandName="Login" Text="Log in" OnClick="Login_Click" /><br><br></br></br>
                   
                </fieldset>
            </LayoutTemplate>
             
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
        </asp:Login>
            Please Enter Your Email To Login</h2></hgroup><section id="loginForm">
    </section>
    
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 186px;
        }
    </style>
</asp:Content>
