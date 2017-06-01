<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="LTRS.registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" type="text/javascript">
        function CloseBrowser() {
            window.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-lg-12 col-md-12">
                <table style="width: 100%">
                    <tr>
                        <td style="width: 20%"></td>
                        <td style="width: 60%">
                            <table style="width: 100%">
                                <tr>
                                    <td></td>
                                    <td>
                                        <h4>Registration Page</h4>
                                    </td>
                                </tr>

                                <tr>
                                    <td style="width: 30%">
                                        <div class="form-group-new">First Name</div>
                                    </td>
                                    <td style="width: 70%">
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtfirstname" runat="server" type="text" class="form-control-new" placeholder="Enter First Name" required></asp:TextBox>
                                        </div>
                                    </td>

                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new">Last Name</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtlastname" runat="server" type="text" class="form-control-new" placeholder="Enter Last Name" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new">Userid</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtusername" runat="server" type="text" class="form-control-new" placeholder="Enter userid to use for login" required>
                                            </asp:TextBox>
                                        </div>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <div class="form-group-new">Password</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtpassword" runat="server" type="password" class="form-control-new" placeholder="Enter password" required="required"></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new" runat="server" id="dba1" style="display: none">DBA Password</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new" runat="server" id="dba2" style="display: none">
                                           
                                            <asp:TextBox ID="TextBox1" runat="server" type="password" class="form-control-new" placeholder="Enter DBA password"></asp:TextBox>
                                             
                                        </div>
                                    </td>
                                </tr>
                                <%--<tr>
                                    <td>
                                        <div class="form-group-new">Confirm Password</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtconfirmpassword" runat="server" type="password" class="form-control-new" placeholder="Enter confirmation password" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>--%>
                                <tr>
                                    <td>
                                        <div class="form-group-new">Email</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtemail" runat="server" type="email" class="form-control-new" placeholder="Enter your Personal email" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new">Contact Number</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtphoneno" runat="server" pattern="[0-9]{10}" onkeypress='return event.charCode >= 48 && event.charCode <= 57' class="form-control-new" placeholder="Enter your contact number" title="Please enter valid contact number" MaxLength="10" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                               <%-- <tr>
                                    <td>
                                        <div class="form-group-new">Address</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtaddress" runat="server" type="text" class="form-control-new" placeholder="Enter your personal Address" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new">City</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtcity" runat="server" type="text" class="form-control-new" placeholder="Enter your City" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new">State</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtstate" runat="server" type="text" class="form-control-new" placeholder="Enter your State" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new">Zip Code</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtzipcode" runat="server" type="text" class="form-control-new" onkeypress='return event.charCode >= 48 && event.charCode <= 57' title="Please enter valid 5 digit Zipcode" placeholder="Enter your Zipcode" MaxLength="5" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>--%>
                                <tr>
                                    <td>
                                        <div class="form-group-new">Security Question</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:Label ID="lblsecurity" runat="server" Text="What is your best friend's first name.?" required>
                                            </asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="form-group-new">Security Answer</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new">
                                            <asp:TextBox ID="txtanswer" runat="server" type="text" class="form-control-new" placeholder="Enter your answer here" required></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <div class="form-group-new" runat="server" id="divusertype" style="display:none">I am</div>
                                    </td>
                                    <td>
                                        <div class="form-group-new" runat="server" id="divusertype1" style="display:none">
                                            <asp:RadioButton runat="server" ID="rdblandlord" Text="Landlord" GroupName="usertype" />
                                            <asp:RadioButton runat="server" ID="rdbtenant" Text="Tenant" GroupName="usertype" />
                                        </div>
                                    </td>
                                </tr>

                                <tr>
                                    <td></td>
                                    <td>
                                        <div class="form-group-new">
                                            <div class="row">
                                                <div class="col-sm-12 col-lg-2 col-md-2">
                                                    <asp:Button runat="server" Text="Submit" ID="btnregister" OnClick="btnregister_Click" CssClass="thead-default"></asp:Button>
                                                </div>
                                                <div class="col-sm-12 col-lg-2 col-md-2">
                                                    <asp:Button runat="server" ID="Button4" Text="Reset" CssClass="thead-default" OnClick="btnreset_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>
                                                </div>
                                                <div class="col-sm-12 col-lg-8 col-md-8">
                                                     <label id="lblmessage" runat="server" class="form-group-new"></label>
                                                </div>
                                               
                                            </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 20%"></td>
                    </tr>
                    <table width="100%">
                        <tr>

                            <td align="center" valign="middle" style="padding-top: 20px">
                                <asp:Button runat="server" ID="Button1" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button2" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="Button3" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                          <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click"  />
                            </td>
                        </tr>
                    </table>
                </table>



            </div>
        </div>
    </div>

    <!-- Latest compiled and minified jQuery -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <!--
     <script src="assets/js/JQuery.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
        -->

</asp:Content>

