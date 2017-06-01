<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="forgotpassword.aspx.cs" Inherits="LTRS.forgotpassword" %>

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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="uplogin" runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row" style="height:400px">
                    <div class="col-sm-12 col-lg-4 col-md-4"></div>
                    <div class="col-sm-12 col-lg-6 col-md-4">

                        <asp:Panel ID="Panel1" runat="server">
                            <label class="control-label">
                                <h3>Forgot Password</h3>
                            </label>
                            <br />
                            <label class="control-label">Enter Userid</label>

                            <asp:TextBox ID="txtEmail" class="form-control" placeholder="Enter your registered userid" required="required" runat="server" />


                            <label>We will send you the password on your Personal email address which you have provoided at the time of registration.</label>

                            <asp:Button runat="server" ID="btnsubmit" Text="Send my password" OnClick="btnsubmit_Click"></asp:Button>&nbsp;&nbsp;&nbsp;<asp:Button runat="server" ID="btnreset" Text="Reset" CssClass="thead-default" OnClick="btnreset_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button> &nbsp;&nbsp;<asp:Label ID="lblMessage" runat="server" />

                        </asp:Panel>

                    </div>
                    <div class="col-sm-12 col-lg-6 col-md-4"></div>
                </div>
                <table width="100%">
                    <tr>

                        <td align="center" valign="middle" style="padding-top: 30px">
                            <asp:Button runat="server" ID="btnhome" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="btnback" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         &nbsp;
                             <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default"  CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click"/>
                        </td>
                    </tr>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <script src="assets/js/bootstrap.min.js"></script>

</asp:Content>
