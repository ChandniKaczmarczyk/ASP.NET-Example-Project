<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="LTRS.Welcome" %>

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
            <div class="col-sm-12 col-lg-12 col-md-12" runat="server" id="divsecondtime">

                <table width="100%" style="height: 320px">
                    <tr>

                        <td align="center" valign="middle" style="padding-top: 30px">
                            <label class="control-label" style="font-size: 50px; font-weight: bold; text-align: center">Welcome </label>
                            &nbsp;&nbsp;
                            <label class="control-label" style="font-size: 50px; font-weight: bold; text-align: center" id="lblusermessage" runat="server"></label>
                            &nbsp;&nbsp;
                            <label class="control-label" runat="server" id="lbltype" style="font-size: 50px; font-weight: bold; text-align: center">&nbsp;</label>
                        </td>
                    </tr>
                   
                </table>
                <%-- <br />
                <br />
                <br />
                <br />
                <br />
                <label class="control-label" style="font-size: 50px; font-weight: bold; text-align: center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Welcome &nbsp;</label>
                <label class="control-label" style="font-size: 50px; font-weight: bold; text-align: center" id="lblusermessage" runat="server">&nbsp;&nbsp;
                </label>
                <label class="control-label" runat="server" id="lbltype" style="font-size: 50px; font-weight: bold; text-align: center">&nbsp;</label>--%>
            </div>
            <table width="100%">
                <tr>

                    <td align="center" valign="middle" style="padding-top: 30px">
                        <asp:Button runat="server" ID="btnhome" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" Enabled="true" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="btnnext" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="btnback" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
