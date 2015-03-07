<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register2.aspx.cs" Inherits="Account_Register2" %>

<%-- Team Collaboration : All team members worked on this page --%>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div style="height: 840px">

    <div style="margin-right: 3px; margin-left: 0px; margin-top:0px; height: 420px; z-index:2; position: absolute; top: 469px; width: 118px; left: 236px;">

        <div style="margin-left: 0px; margin-right: 0px; margin-top:0px; width: 620px; height: 420px; z-index:2; position: absolute; top: 16px; left: 122px;">
            <h1> Register for an account with Travel Experts</h1>
            <asp:Table runat="server" Width="856px" class="Register">
                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Email: </asp:TableCell>
                    <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%"><asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtemail" ErrorMessage="Email Is Required" ForeColor="Red" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegExEmail" runat="server" ControlToValidate="txtemail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="wrong format. ex) abc@ab.ca" Display="Dynamic"></asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Password: </asp:TableCell>
                    <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%">
                        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtpass"  ErrorMessage="Password Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Confirm Password: </asp:TableCell>
                    <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%">
                        <asp:TextBox ID="txtconpass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtconpass" ControlToValidate="txtpass" ErrorMessage="Password And Confirm Password Must Match" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                    </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >First name: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txtfirst" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtfirst" ErrorMessage="First Name Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                    </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Last name: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txtlast" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtlast" ErrorMessage="Last Name Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Address: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtaddress" ErrorMessage="Address Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >City: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcity" ErrorMessage="City Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Province: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txtprov" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtprov" ErrorMessage="Province is Reqired" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegExProv" runat="server" ControlToValidate="txtprov" Display="Dynamic" ValidationExpression="[A-Za-z]{2}$" ErrorMessage="wrong format. ex)AB"></asp:RegularExpressionValidator></asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Postal Code: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txtpostal" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtpostal" ErrorMessage="Postal Code Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegExPC" runat="server" ControlToValidate="txtpostal" Display="Dynamic" ValidationExpression="[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$" ErrorMessage="wrong format. ex)a1a1a1"></asp:RegularExpressionValidator>
                        </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Country: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txtcountry" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcountry" ErrorMessage="Country Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Home Phone: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > 
                            <asp:TextBox ID="txthomephone" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txthomephone" ErrorMessage="Home Phone Is Required" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegExPhoneNo" runat="server" ControlToValidate="txthomephone" Display="Dynamic" ErrorMessage="wrong format. ex) 111-222-3333" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                        </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell Width="30%" style="line-height: 30px; vertical-align:middle;" >Business Phone: </asp:TableCell>
                        <asp:TableCell style="line-height: 30px; vertical-align:middle;"  Width="70%" > <asp:TextBox ID="txtbusphone" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        
        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btncls" runat="server" Text="Clear" OnClick="btncls_Click" />

    
        </div>

               
        
         </div>
    


     </div>
</asp:Content>
