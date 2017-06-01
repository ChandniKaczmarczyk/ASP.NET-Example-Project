<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LTRS.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/mystyle.css" rel="stylesheet" />
    <script type="text/javascript">
        function CloseBrowser() {
            window.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPContent" runat="server">
    <div class="container">

        <div class="row" style="height: 400px">
            <div class="col-sm-12 col-lg-3 col-md-3"></div>
            <div class="col-sm-12 col-lg-5 col-md-5">
                <div class="row">
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="form-group">
                        </div>
                    </div>
                    <div class="col-sm-8 col-lg-8 col-md-8">
                        <div class="form-group">
                            <label class="control-label">
                                <h3>Login Page</h3>
                            </label>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="form-group">
                            <label class="control-label">Userid</label>

                        </div>
                    </div>
                    <div class="col-sm-8 col-lg-8 col-md-8">
                        <div class="form-group">
                            <asp:TextBox ID="txtusername" CssClass="form-control" placeholder="Enter your userid" required="required" runat="server" ValidationGroup="Group1"></asp:TextBox>
                        </div>
                    </div>
                </div>




                <div class="row">
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="form-group">
                            <label class="control-label">Password</label>
                        </div>
                    </div>
                    <div class="col-sm-8 col-lg-8 col-md-8">
                        <div class="form-group">
                            <asp:TextBox type="password" ID="txtpassword" CssClass="form-control" placeholder="Enter your password" required="required" runat="server" ValidationGroup="Group1"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row" runat="server" id="divDBA" style="display: none">
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="form-group">
                            <label class="control-label">DBA Password</label>
                        </div>
                    </div>
                    <div class="col-sm-8 col-lg-8 col-md-8">
                        <div class="form-group">
                            <asp:TextBox type="password" ID="txtdbapassword" CssClass="form-control" placeholder="Enter your password" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="form-group">
                        </div>
                    </div>
                    <div class="col-sm-8 col-lg-8 col-md-8">
                        <label>
                            <a href="forgotpassword.aspx" style="text-decoration: none; color: black">Forgot Password ?</a>
                        </label>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="row">
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="form-group">
                        </div>
                    </div>
                    <div class="col-sm-8 col-lg-8 col-md-8">
                        <div class="row">
                            <div class="col-sm-12 col-lg-3 col-md-3">
                                <asp:Button runat="server" ID="Button1" Text="Submit" CssClass="thead-default" OnClick="btnsubmit_Click" CausesValidation="false" Enabled="true"></asp:Button>
                            </div>
                            <div class="col-sm-12 col-lg-3 col-md-3">
                                <asp:Button runat="server" ID="Button4" Text="Reset" CssClass="thead-default" OnClick="btnreset_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>
                            </div>
                            <div class="col-sm-12 col-lg-6 col-md-6">
                            </div>
                        </div>

                        <label id="lblmessage" runat="server" class="form-group-new"></label>
                    </div>
                </div>

            </div>

            <div class="col-sm-12 col-lg-3 col-md-3"></div>



        </div>

        <table width="100%">
            <tr>

                <td align="center" valign="middle" style="padding-top: 30px">
                    <asp:Button runat="server" ID="btnhome" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" Enabled="true" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="btnback" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>
                    &nbsp;
                        <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />
                </td>
            </tr>
        </table>
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
