<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LTRS.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/mystyle.css" rel="stylesheet" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <script language="javascript" type="text/javascript">
        function CloseBrowser() {
            window.close();
        }
    </script>
    <script type="text/javascript">
        function closepage() {
            var win = window.open('', '_self');
            win.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-lg-12 col-md-12" runat="server" id="divfirsttime" style="height:400px">
                <br>

                <br>
                <h2 style="padding-left: 75px; padding-top: 50px">Are you a Registered User?</h2>
                <label class="control-label" style="padding-left: 75px;">
                    If YES then please <a href="login.aspx" style="text-decoration: none; color: black">login</a> with your Userid
                </label>
                <br>
                <br>


                <h2 style="padding-left: 75px;">New Users ?</h2>
                <label class="control-label" style="padding-left: 75px;">
                    Then you can register with us by clicking <a href="registration.aspx" style="text-decoration: none; color: black">Register </a>.
                </label>
                <%--<label>You can <a href="registration.aspx">Register</a> or <a href="login.aspx">Login</a> from here. </label>--%>
            </div>

            <%--<div>

                <asp:Button runat="server" ID="btnsubmit" Text="Home" CssClass="special" OnClick="Home_Click" Style="margin-left: auto; display: block;"></asp:Button>
                &nbsp;
                <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="special" OnClick="btnnext_Click" Style="margin-right: auto; display: block;"></asp:Button>

            </div>--%>
            <table width="100%">
                <tr>
                    <td align="center" valign="middle">
                        <asp:Button runat="server" ID="btnhome" Text="Home" CssClass="thead-default" OnClick="Home_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />
                    </td>
                </tr>
            </table>


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

