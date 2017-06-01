<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="ViewRatings.aspx.cs" Inherits="LTRS.ViewRatings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" type="text/javascript">
        function CloseBrowser() {
            window.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">

    <div class="container">
        <div class="col-lg-12 col-md-12">
            <div>
                <table width="100%">
                    <tr>

                        <td align="center" valign="middle" style="padding-top: 20px">
                            <label id="lblinvalidmessage" runat="server" style="font-size: 40px; font-weight: bold; padding-left: 30px"></label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="row">
                <asp:Label runat="server" ID="lblmessege" Style="font-size: 40px; font-weight: bold; padding-left: 30px">

                </asp:Label>
            </div>
            <div class="row">
                <div class="col-lg-12" style="height: 350px; overflow-y: auto;">

                    <asp:Repeater runat="server" ID="Repeater1">
                        <HeaderTemplate>
                            <h3>View Landlord/Tenant Ratings</h3>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                    <label class="control-label" style="font-size: 18px; font-weight: bold">Name:</label>
                                    <asp:Label CssClass="control-label" Style="font-size: 18px;" ID="lblname" runat="server" Text='<%#Bind("TO_FULL_NAME") %>'></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                    <label class="control-label" style="font-size: 18px; font-weight: bold">Property Address: </label>
                                    <asp:Label CssClass="control-label" Style="font-size: 18px;" ID="lblpropertyaddress" runat="server" Text='<%#Bind("PROPERTY_ADDRESS") %>'></asp:Label>

                                    <asp:HiddenField runat="server" ID="hffromuser" Value='<%#Bind("FROM_USER_ID") %>' />
                                    <asp:HiddenField runat="server" ID="hftouser" Value='<%#Bind("TO_USER_ID") %>' />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                    <label class="control-label" style="font-size: 18px; font-weight: bold">Who gave you Ratings:</label>
                                    <asp:Label CssClass="control-label" Style="font-size: 18px;" ID="lblratinggivenname" runat="server" Text='<%#Bind("FIRST_NAME") %>'></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                    <label class="control-label" style="font-size: 18px; font-weight: bold">Ratings: </label>
                                    <asp:RadioButton ID="RadioButton1" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Excellent" Enabled="false" />
                                    <asp:RadioButton ID="RadioButton2" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Very Good" Enabled="false" />
                                    <asp:RadioButton ID="RadioButton3" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Good" Enabled="false" />
                                    <asp:RadioButton ID="RadioButton4" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Fair" Enabled="false" />
                                    <asp:RadioButton ID="RadioButton5" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Poor" Enabled="false" />
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                    <label class="control-label" style="font-size: 18px; font-weight: bold">Reviews: </label>
                                    <asp:Label ID="lblreviews" runat="server" CssClass="control-label" Style="font-size: 18px;" Text='<%#Bind("REVIEWS") %>'></asp:Label>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>



                </div>
            </div>

            <table width="100%">
                <tr>
                    <td align="center" valign="middle" style="padding-top: 20px">
                        <asp:Button runat="server" ID="Button1" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button2" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button3" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false"  OnClick="btnexit_Click" />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
