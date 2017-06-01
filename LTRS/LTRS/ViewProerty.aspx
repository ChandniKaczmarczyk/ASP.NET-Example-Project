<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="ViewProerty.aspx.cs" Inherits="LTRS.ViewProerty" EnableEventValidation="false" %>

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

                        <td align="center" valign="middle" style="padding-top: 10px">
                            <label id="lblmessage" runat="server" style="font-size: 40px; font-weight: bold; padding-left: 30px"></label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="row" id="divpropertylisting" runat="server" style="display: none">
                <div class="col-lg-12 col-md-12">
                    <asp:Label runat="server" ID="lblvalidation" Style="font-size: 25px; font-weight: bold"></asp:Label>
                </div>
                <div class="col-lg-12 col-md-12" style="height: 350px; overflow-y: auto;">
                    <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                        <HeaderTemplate>
                            <h3>Property Listing</h3>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table style="border: 1px solid #eee; width: 100%">
                                <tr>
                                    <td>
                                        <asp:Image runat="server" ImageUrl='<%#Eval("PHOTOS") %>' Height="150px" Width="150px" ID="imageproperty" />
                                        <asp:Label runat="server" ID="lblimagepath" Visible="false" Text='<%#Eval("PHOTOS") %>'></asp:Label>
                                        <asp:Label runat="server" ID="lblpropertyid" Text='<%#Eval("PROPERTY_ID") %>' Visible="false"></asp:Label>
                                        <asp:Label runat="server" ID="hflandlorduserid" Text='<%#Eval("USER_ID") %>' Visible="false"></asp:Label>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td><b>Owner Name:</b></td>
                                                <td>
                                                    <asp:Label runat="server" ID="lblownername" Text='<%#Eval("OWNER_NAME") %>'></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td><b>Property Type:</b></td>
                                                <td>
                                                    <asp:Label runat="server" ID="Label1" Text='<%#Eval("PROPERTY_TYPE") %>'></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td><b>Contact Number:</b></td>
                                                <td>
                                                    <asp:Label runat="server" ID="lblcontactnumber" Text='<%#Eval("CONTACT_NUMBER") %>'></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td><b>Built Date:</b>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="lblbuiltdate" Text='<%#Eval("BUILTDATE") %>'></asp:Label></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td><b>Property Address:</b>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="lbladdress" Text='<%#Eval("PROPERTY_ADDRESS") %>'></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td><b>City:</b>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="lblcity" Text='<%#Eval("CITY") %>'></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td><b>State:</b>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="lblstate" Text='<%#Eval("STATE") %>'></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td><b>Rent:</b>
                                                </td>
                                                <td>
                                                    <span>$</span><asp:Label runat="server" ID="lblrent" Text='<%#Eval("RENT") %>'></asp:Label></td>
                                            </tr>

                                        </table>
                                    </td>
                                </tr>
                            </table>
                            <asp:Button runat="server" ID="btnRequestProperty" Text="Request Property" Style="float: right" CssClass="thead-default" OnClick="btnRequestProperty_Click" />
                        </ItemTemplate>
                        <FooterTemplate>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>

            </div>

        </div>


        <table width="100%">
            <tr>

                <td align="center" valign="middle" style="padding-top: 20px">
                    <asp:Button runat="server" ID="Button1" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button2" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="Button3" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                          <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
