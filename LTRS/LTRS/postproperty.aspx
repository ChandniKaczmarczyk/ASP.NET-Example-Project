<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="postproperty.aspx.cs" Inherits="LTRS.postproperty" %>

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
        <div id="divproperty" runat="server" style="display: none">
            <div class="container">
                <div class="row">

                    <div class="col-sm-12 col-lg-12 col-md-12">
                        <div class="row">
                            <div class="col-xs-5 col-md-5 col-lg-5">
                                <div class="form-group">
                                    <label for=""></label>
                                </div>
                            </div>
                            <div class="col-xs-3 col-md-3 col-lg-3">
                                <div class="form-group">
                                    <label style="font-size: 27px; text-align: center">Post Property</label>
                                </div>
                            </div>
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for=""></label>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>


                <div class="row">
                    <div class="col-sm-12 col-lg-6 col-md-6">


                        <div class="row">
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for="drppropertytype">Property Type </label>
                                </div>
                            </div>
                            <div class="col-xs-8 col-md-8 col-lg-8">
                                <div class="form-group">
                                    <%--<asp:DropDownList runat="server" ID="drppropertytype" class="form-control" required="required">
                                <asp:ListItem Value="0">Select Property Type</asp:ListItem>
                                <asp:ListItem Value="1" Text="Apartment">Apartment</asp:ListItem>
                                <asp:ListItem Value="2" Text="Condo">Condo</asp:ListItem>
                                <asp:ListItem Value="3" Text="House">House</asp:ListItem>
                            </asp:DropDownList>--%>
                                    <select id="drppropertytype" class="form-control" required="required" runat="server">
                                        <option value="">Select Property Type</option>
                                        <option value="Apartment">Apartment</option>
                                        <option value="Condo">Condo</option>
                                        <option value="House">House</option>
                                    </select>


                                    <%--<asp:RequiredFieldValidator ID="re1" runat="Server" ControlToValidate="drppropertytype" InitialValue="0" ErrorMessage="Please select property type" ></asp:RequiredFieldValidator>--%>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for="txtownername">Owner Name</label>
                                </div>
                            </div>
                            <div class="col-xs-8 col-md-8 col-lg-8">
                                <div class="form-group">
                                    <asp:TextBox ID="txtownername" runat="server" type="text" class="form-control" placeholder="Enter Owner name" required="required"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for="txtcontactnumber">Contact Number </label>
                                </div>
                            </div>
                            <div class="col-xs-8 col-md-8 col-lg-8">
                                <div class="form-group">
                                    <asp:TextBox ID="txtcontactnumber" MaxLength="10" pattern="[0-9]{10}" onkeypress='return event.charCode >= 48 && event.charCode <= 57' runat="server" class="form-control" placeholder="Enter contact number" title="Please enter valid contact number" required="required"></asp:TextBox>

                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for="txtaddress">Property Address </label>
                                </div>
                            </div>
                            <div class="col-xs-8 col-md-8 col-lg-8">
                                <div class="form-group">
                                    <asp:TextBox ID="txtaddress" runat="server" type="text" class="form-control" placeholder="Enter Address" required="required"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for="txtcity">City </label>
                                    <asp:TextBox ID="txtcity" runat="server" type="text" class="form-control" placeholder="Enter City" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for="drpstate">State</label>
                                    <asp:TextBox ID="txtstate" runat="server" type="text" class="form-control" placeholder="Enter State" required="required"></asp:TextBox>
                                    <%--<asp:DropDownList ID="drpstate" runat="server" CssClass="form-control">
                                    <asp:ListItem>Connecticut</asp:ListItem>
                                    <asp:ListItem>Newyork</asp:ListItem>
                                    <asp:ListItem>New Jersey</asp:ListItem>
                                </asp:DropDownList>--%>
                                </div>
                            </div>
                            <div class="col-xs-4 col-md-4 col-lg-4">
                                <div class="form-group">
                                    <label for="txtzipcode">Zip Code</label>
                                    <asp:TextBox ID="txtzipcode" runat="server" type="text" class="form-control" placeholder="Enter zip code" MaxLength="5" onkeypress='return event.charCode >= 48 && event.charCode <= 57' title="Please enter valid Zip Code" required="required"></asp:TextBox>
                                </div>
                            </div>
                        </div>




                    </div>
                    <div class="col-sm-12 col-lg-6 col-md-6">

                        <%--     <div class="row">
                        <div class="col-xs-5 col-md-5 col-lg-5">
                            <div class="form-group">
                                <label for="drprentorsale">Post Property for</label>
                            </div>
                        </div>
                        <div class="col-xs-7 col-md-7 col-lg-7">
                            <div class="form-group">
                                <asp:DropDownList ID="drprentorsale" runat="server" CssClass="form-control">
                                    <asp:ListItem>Rent</asp:ListItem>
                                    <asp:ListItem>Sale</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>--%>
                        <div class="row">
                            <div class="col-xs-5 col-md-5 col-lg-5">
                                <div class="form-group">
                                    <label for="txtbuitdate">Built Date</label>
                                </div>
                            </div>
                            <div class="col-xs-7 col-md-7 col-lg-7">
                                <div class="form-group">
                                    <%-- <asp:Calendar ID="Calendar1" runat="server" ></asp:Calendar>--%>

                                    <input id="txtdate" runat="server" class="form-control" place-holder="yyyy/mm/dd" type="date" name="bday" />
                                </div>
                            </div>
                        </div>
                        <%-- <div class="row">
                        <div class="col-xs-5 col-md-5 col-lg-5">
                            <div class="form-group">
                                <label for="txtsquarefeet">Square Feets</label>
                            </div>
                        </div>
                        <div class="col-xs-7 col-md-7 col-lg-7">
                            <div class="form-group">
                              
                                <asp:TextBox ID="txtsquarefeet" placeholder="Enter square feets" runat="server" CssClass="form-control"> </asp:TextBox>
                            </div>
                        </div>
                    </div>--%>
                        <div class="row">
                            <div class="col-xs-5 col-md-5 col-lg-5">
                                <div class="form-group">
                                    <label for="txtbathroom">Bathroom and Bedroom </label>
                                </div>
                            </div>
                            <div class="col-xs-7 col-md-7 col-lg-7">
                                <div class="form-group">

                                    <asp:TextBox ID="txtbedbath" placeholder="Enter no of Bathroom and Bedroom" runat="server" CssClass="form-control"> </asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-5 col-md-5 col-lg-5">
                                <div class="form-group">
                                    <label for="txtbathroom">Rent per Month in Dollars </label>
                                </div>
                            </div>
                            <div class="col-xs-7 col-md-7 col-lg-7">
                                <div class="form-group">
                                    <asp:TextBox ID="txtrent" placeholder="Example: 2500 " runat="server" CssClass="form-control" onkeypress='return event.charCode >= 48 && event.charCode <= 57' title="Please only numeric values for a rent." required> </asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-5 col-md-5 col-lg-5">
                                <div class="form-group">
                                    <label for="">Upload Property Photos</label>
                                </div>
                            </div>
                            <div class="col-xs-7 col-md-7 col-lg-7">
                                <div class="form-group">
                                    <asp:FileUpload runat="server" CssClass="form-control" BorderStyle="None" ID="fileupload1" Style="padding-left: 0px" />
                                    <%--<asp:FileUpload runat="server" CssClass="file form-control" BorderStyle="None" ID="fileupload2" Style="padding-left: 0px" />
                            <asp:FileUpload runat="server" CssClass="file form-control" BorderStyle="None" ID="fileupload3" Style="padding-left: 0px" />--%>
                                </div>
                            </div>




                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-sm-12 col-lg-12 col-md-12">
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-12 col-lg-12 col-md-12">
                            <div class="row">
                                <div class="col-xs-5 col-md-5 col-lg-5">
                                    <div class="form-group">
                                        <label for=""></label>
                                    </div>
                                </div>
                                <div class="col-xs-2 col-md-2 col-lg-2">
                                    <div class="form-group">
                                        <asp:Button runat="server" ID="btnsubmit" Text="Submit" CssClass="control-label" OnClick="btnsubmit_Click"></asp:Button>

                                    </div>
                                </div>
                                <div class="col-xs-2 col-md-2 col-lg-2">
                                    <div class="form-group">
                                        <asp:Button runat="server" ID="Button4" Text="Reset" CssClass="thead-default" OnClick="btnreset_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>

                                    </div>
                                </div>
                                <div class="col-xs-3 col-md-3 col-lg-3">
                                    <div class="form-group">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-12 col-lg-12 col-md-12">
                            <div class="row">
                                <div class="col-xs-5 col-md-5 col-lg-5">
                                    <div class="form-group">
                                        <label for=""></label>
                                    </div>
                                </div>
                                <div class="col-xs-7 col-md-7 col-lg-7">
                                    <div class="form-group">
                                        <label id="lblmessage" runat="server" class="form-group-new"></label>
                                    </div>
                                </div>
                            </div>
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
                     <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
