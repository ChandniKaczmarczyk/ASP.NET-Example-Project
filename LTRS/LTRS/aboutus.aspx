<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="aboutus.aspx.cs" Inherits="LTRS.aboutus" %>

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
            <div class="col-sm-12 col-lg-12">
                <label class="control-label" style="padding-top: 40px; font-size: 35px;">About us</label>

            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">

            <div class="row">
                <div class="col-12">
                    <label class="control-label">
                        Landlord Tenant Rating System provides a stage for landlords as well as tenants for rating each other. The goal of this system is to rate the tenants and landlord , to post their property for rent ,search property which are on rent. The system is basically useful to decide whether landlord is good as a landlord and tenenat is good as a tenant.

                    </label>

                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <label class="control-label" style="font-size: 25px; padding-top: 20px;">Our Team</label>
                </div>
                <div class="col-lg-2 col-sm-6 text-center">

                    <h5>Chandni Patel</h5>
                    <h6>Software Developer</h6>
                </div>
                <div class="col-lg-2 col-sm-6 text-center">

                    <h5>Preksha Shah</h5>
                    <h6>Software Developer</h6>
                </div>
                <div class="col-lg-2 col-sm-6 text-center">

                    <h5>Kavan Patel</h5>
                    <h6>Database Designer</h6>
                </div>
                <div class="col-lg-2 col-sm-6 text-center">

                    <h5>Dharav Shah</h5>
                    <h6>Software Developer</h6>
                </div>
                <div class="col-lg-2 col-sm-6 text-center">

                    <h5>Aman Bidla</h5>
                    <h6>Network Assitant</h6>
                </div>
                <div class="col-lg-2 col-sm-6 text-center">

                    <h5>Sai Yenna</h5>
                    <h6>Network Assitant</h6>
                </div>
            </div>


        </div>


    </div>
    <table width="100%">
        <tr>

            <td align="center" valign="middle" style="padding-top: 20px">
                <asp:Button runat="server" ID="Button1" Text="Home" CssClass="thead-default" OnClick="btnhome_Click"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button2" Text="Next" CssClass="thead-default" OnClick="btnnext_Click"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="Button3" Text="Back" CssClass="thead-default" OnClick="btn_back_Click"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />
               
            </td>
        </tr>
    </table>

    <div class="container">
    </div>

</asp:Content>
