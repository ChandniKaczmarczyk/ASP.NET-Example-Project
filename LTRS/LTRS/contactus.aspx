<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="contactus.aspx.cs" Inherits="LTRS.contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/mystyle.css" rel="stylesheet" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <script language="javascript" type="text/javascript">
        function CloseBrowser() {
            window.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-lg-12">
                <label class="control-label" style="font-size: 35px">Contact us</label>

            </div>
        </div>
    </div>
    <div class="container">

        <div class="row">

            <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">

                <div class="row">
                    <div class=" col-xs-6 col-sm-6 col-md-6 col-lg-6">
                        <div class="form-group">
                            <label for="firstname">First Name</label>
                            <asp:TextBox ID="txtfirstname" runat="server" class="form-control" placeholder="Enter first name" required="required"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label for="lasttname">Last Name</label>
                            <asp:TextBox ID="txtlastname" runat="server" type="text" class="form-control" placeholder="Enter last name" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="lasttname">How can we contact to you?</label>

                        </div>
                        <div class="row">
                            <div class=" col-xs-1 col-sm-1 col-md-1 col-lg-1">
                                <asp:CheckBox CssClass="form-control" ID="chkemail" runat="server" BorderStyle="None" />
                            </div>
                            <div class=" col-xs-11 col-sm-11 col-md-11 col-lg-11">
                                <div class="form-group">

                                    <div class="input-group">
                                        <%--<span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span></span>--%>
                                        <asp:TextBox ID="txtemail" runat="server" type="email" class="form-control" placeholder="Enter your Email" required="required"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class=" col-xs-1 col-sm-1 col-md-1 col-lg-1">
                                <asp:CheckBox CssClass="form-control" ID="chkphone" runat="server" BorderStyle="None" />
                            </div>
                            <div class=" col-xs-11 col-sm-11 col-md-11 col-lg-11">
                                <div class="form-group">
                                    <div class="input-group">
                                        <%--<span class="input-group-addon"><span class="glyphicon glyphicon-earphone"></span></span>--%>
                                        <asp:TextBox ID="phoneno" runat="server" class="form-control" pattern="[0-9]{10}" onkeypress='return event.charCode >= 48 && event.charCode <= 57' placeholder="Enter Contact number" MaxLength="10" required="required"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>



                    <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
                        <div class="form-group">
                            <label for="inquiry">Your Inquiry</label>
                            <textarea name="inquiry" id="inquiry" runat="server" type="text" class="form-control" rows="14" cols="25" required="required" placeholder="Your Inquiry"></textarea>
                        </div>
                    </div>

                    <div class="col-sm-12 col-lg-12 col-md-12">
                        <div class="row">
                            <div class="col-xs-6 col-md-6 col-lg-6">
                                <div class="form-group">
                                    <asp:Label ID=""></asp:Label>
                                </div>
                            </div>
                            <div class="col-xs-1 col-md-1 col-lg-1">
                                <div class="form-group">
                                    <asp:Button runat="server" ID="btnsubmit" Text="Submit" OnClick="btnsubmit_Click"></asp:Button>
                                </div>
                            </div>
                            <div class="col-xs-1 col-md-1 col-lg-1">
                                <div class="form-group">
                                    <asp:Button runat="server" ID="btnreset" Text="Reset" CssClass="thead-default" OnClick="btnreset_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>
                                </div>
                            </div>
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <asp:Label ID="lblmessage" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
                <table width="100%">
                    <tr>

                        <td align="center" valign="middle" style="padding-top: 30px">
                            <asp:Button runat="server" ID="btnhome" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="btnback" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         &nbsp;
                             <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click"/>
                        </td>
                    </tr>
                </table>
            </div>

            <!-- bootstrap javascript-->
            <script src="js/bootstrap.min.js"></script>
</asp:Content>
