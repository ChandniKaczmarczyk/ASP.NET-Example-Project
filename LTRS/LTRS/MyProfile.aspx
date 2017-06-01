<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="LTRS.MyProfile" EnableEventValidation="false" %>

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
            <div class="col-lg-12 col-md-12">
                <div>
                    <table width="100%">
                        <tr>

                            <td align="center" valign="middle" style="padding-top: 10px">
                                <label id="lblinvalidmessage" runat="server" style="font-size: 40px; font-weight: bold; padding-left: 30px"></label>
                            </td>
                        </tr>
                    </table>
                </div>
                 <div>
                    <table width="100%">
                        <tr>

                            <td align="center" valign="middle">
                                <label id="lblmessege" runat="server" style="font-size: 20px; font-weight: bold; padding-left: 30px"></label>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="divmyprofile" runat="server" style="display: none;">

                    <div class="container">
                        <div class="row">
                            <div class="col-xs-12 col-md-12 col-lg-12">
                                <label style="font-size: 25px; font-weight: bold;">Personal Details</label>
                            </div>
                        </div>
                        <div class="row">

                            <div class="col-xs-2 col-md-2 col-lg-2">
                                <div class="form-group-new">
                                    <label style="font-size: 20px; font-weight: bold;">First name :</label>
                                </div>
                            </div>
                            <div class="col-xs-3 col-md-3 col-lg-3">
                                <div class="form-group-new">
                                    <asp:Label runat="server" ID="lblfirstname" Style="font-size: 20px;"></asp:Label>
                                </div>
                            </div>
                            <div class="col-xs-2 col-md-2 col-lg-2">
                                <div class="form-group-new">
                                    <label style="font-size: 20px; font-weight: bold;">Last name :</label>
                                </div>
                            </div>
                            <div class="col-xs-3 col-md-3 col-lg-3">
                                <div class="form-group-new">
                                    <asp:Label runat="server" ID="lbllastname" Style="font-size: 20px;"></asp:Label>
                                </div>
                            </div>
                            <div class="col-xs-2 col-md-2 col-lg-2">
                                <div class="form-group-new">
                                </div>
                            </div>
                            <div class="col-xs-1 col-md-1 col-lg-1">
                            </div>

                        </div>
                        <div class="row">

                            <div class="col-xs-2 col-md-2 col-lg-2">
                                <div class="form-group-new">
                                    <label style="font-size: 20px; font-weight: bold;">Email : </label>
                                </div>
                            </div>
                            <div class="col-xs-3 col-md-3 col-lg-3">
                                <asp:Label runat="server" ID="lblemail" Style="font-size: 18px;"></asp:Label>
                            </div>

                            <div class="col-xs-2 col-md-2 col-lg-2">
                                <label style="font-size: 18px; font-weight: bold;">Contact Number:</label>
                            </div>
                            <div class="col-xs-3 col-md-3 col-lg-3">
                                <asp:Label runat="server" ID="lblcontactnumber" Style="font-size: 18px;"></asp:Label>
                            </div>
                            <div class="col-xs-2 col-md-2 col-lg-2">
                            </div>
                        </div>


                        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                            
                            <HeaderTemplate>
                                <label style="font-size: 25px; font-weight: bold;">Requested Property List</label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table style="border: 1px solid #eee; width: 100%">
                                    <tr>
                                        <td>
                                            <asp:Image runat="server" ImageUrl='<%#Eval("PHOTOS") %>' Height="100px" Width="100px" ID="imageproperty" AlternateText="No Image" />
                                            <asp:Label runat="server" ID="lblimagepath" Visible="false" Text='<%#Eval("PHOTOS") %>'></asp:Label>
                                            <asp:Label runat="server" ID="lblpropertyid" Visible="false" Text='<%#Eval("PROPERTY_ID") %>' />
                                            <asp:HiddenField runat="server" ID="hftenantuserid" Value='<%#Eval("USER_ID") %>' />
                                        </td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td><b>Tenant First Name:</b></td>
                                                    <td>
                                                        <asp:Label runat="server" ID="lblfname" Text='<%#Eval("FIRST_NAME") %>'></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td><b>Tenant Last Name:</b></td>
                                                    <td>
                                                        <asp:Label runat="server" ID="lbllastname" Text='<%#Eval("LAST_NAME") %>'></asp:Label></td>
                                                </tr>

                                            </table>
                                        </td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td><b>Contact Number:</b></td>
                                                    <td>
                                                        <asp:Label runat="server" ID="lblcontactnumber" Text='<%#Eval("PHONE_NUMBER") %>'></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td><b>Eamil:</b>
                                                    </td>
                                                    <td>
                                                        <asp:Label runat="server" ID="lblbuiltdate" Text='<%#Eval("RECOVERY_EMAIL") %>'></asp:Label></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                                <asp:Button runat="server" ID="btndeclineRequest" Text="Decline" Style="float: right" CssClass="thead-default" OnClick="btndeclineRequest_Click" />
                                <asp:Button runat="server" ID="btnacceptRequest" Text="Leased" Style="float: right" CssClass="thead-default" OnClick="btnacceptRequest_Click" />

                            </ItemTemplate>
                            <FooterTemplate>
                            </FooterTemplate>
                        </asp:Repeater>



                        <asp:Repeater ID="Repeater2" runat="server" OnItemDataBound="Repeater2_ItemDataBound">
                            <HeaderTemplate>
                                <label style="font-size: 25px; font-weight: bold;">Posted Property List</label>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table style="border: 1px solid #eee; width: 100%">
                                    <tr>
                                        <td style="width: 15%">
                                            <asp:Image runat="server" ImageUrl='<%#Eval("PHOTOS") %>' Height="100px" Width="100px" ID="imageproperty2" AlternateText="No Image" />
                                            <asp:Label runat="server" ID="lblimagepath2" Visible="false" Text='<%#Eval("PHOTOS") %>'></asp:Label>
                                            <asp:Label runat="server" ID="lblpropertyid2" Visible="false" Text='<%#Eval("PROPERTY_ID") %>' />
                                            <asp:Label runat="server" ID="lbllandlorduserid2" Visible="false" Text='<%#Eval("USER_ID") %>' />
                                        </td>
                                        <td style="width: 40%">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td style="width: 40%"><b>Owner Name:</b></td>
                                                    <td style="width: 60%">
                                                        <asp:Label runat="server" ID="lblownername" Text='<%#Eval("OWNER_NAME") %>'></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 40%"><b>Property Type:</b></td>
                                                    <td style="width: 60%">
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
                                        <td style="width: 45%">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td style="width: 40%"><b>Property Address:</b>
                                                    </td>
                                                    <td style="width: 60%">
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
                                                <tr>
                                                    <td></td>
                                                    <td>
                                                        <asp:Button ID="btnDeleteprop" runat="server" Style="float: right" Text="Delete Property" CssClass="thead-default" OnClick="btnDeleteprop_Click" /> &nbsp;&nbsp;&nbsp;
                                                        <asp:Button ID="btnEditproperty" runat="server" Style="float: left" Text="Change Property" CssClass="thead-default" OnClick="btnEditproperty_Click" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>

                            </ItemTemplate>
                            <FooterTemplate>
                            </FooterTemplate>
                        </asp:Repeater>

                        <asp:Repeater runat="server" ID="Repeater3">
                            <HeaderTemplate>
                                <h3>My Ratings and Reviews</h3>
                            </HeaderTemplate>
                            <ItemTemplate >
                                <div class="row">
                                    <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                        <label class="control-label" style="font-size: 15px; font-weight: bold">Name:</label>
                                        <asp:Label CssClass="control-label" Style="font-size: 15px;" ID="lblname" runat="server" Text='<%#Bind("TO_FIRST_NAME") %>'></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                        <label class="control-label" style="font-size: 15px; font-weight: bold">Property Address: </label>
                                        <asp:Label CssClass="control-label" Style="font-size: 15px;" ID="lblpropertyaddress" runat="server" Text='<%#Bind("PROPERTY_ADDRESS") %>'></asp:Label>

                                        <asp:HiddenField runat="server" ID="hffromuser" Value='<%#Bind("FROM_USER_ID") %>' />
                                        <asp:HiddenField runat="server" ID="hftouser" Value='<%#Bind("TO_USER_ID") %>' />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                        <label class="control-label" style="font-size: 15px; font-weight: bold">Who gave you Ratings:</label>
                                        <asp:Label CssClass="control-label" Style="font-size: 15px;" ID="lblratinggivenname" runat="server" Text='<%#Bind("FROM_FIRST_NAME") %>'></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                        <label class="control-label" style="font-size: 15px; font-weight: bold">Ratings: </label>
                                        <asp:RadioButton ID="RadioButton1" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Excellent" Enabled="false" />
                                        <asp:RadioButton ID="RadioButton2" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Very Good" Enabled="false" />
                                        <asp:RadioButton ID="RadioButton3" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Good" Enabled="false" />
                                        <asp:RadioButton ID="RadioButton4" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Fair" Enabled="false" />
                                        <asp:RadioButton ID="RadioButton5" GroupName="ratings" Style="margin-right: 20px" runat="server" Text=" Poor" Enabled="false" />
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
                                        <label class="control-label" style="font-size: 15px; font-weight: bold">Reviews: </label>
                                        <asp:Label ID="lblreviews" runat="server" CssClass="control-label" Style="font-size: 15px;" Text='<%#Bind("REVIEWS") %>'></asp:Label>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>


                    </div>
                </div>

            </div>


        </div>
    </div>
    <table width="100%">
        <tr>
            <td align="center" valign="middle" style="padding-top: 20px">
                <asp:Button runat="server" ID="Button1" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button2" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="Button3" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick ="btnexit_Click" />

            </td>
        </tr>
    </table>
</asp:Content>
