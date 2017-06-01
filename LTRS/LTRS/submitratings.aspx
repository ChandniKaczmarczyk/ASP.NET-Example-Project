<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="submitratings.aspx.cs" Inherits="LTRS.submitratings" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" type="text/javascript">
        function CloseBrowser() {
            window.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">

    <div>
        <table width="100%">
            <tr>

                <td align="center" valign="middle" style="padding-top: 20px">
                    <label id="lblinvalidmessage" runat="server" style="font-size: 40px; font-weight: bold; padding-left: 30px;"></label>
                </td>
            </tr>
        </table>
    </div>


    <div id="divsubmitratings" runat="server" style="display: none; padding-bottom: 30px">
        <table width="100%">
            <tr>
                <td align="center" valign="middle">
                    <h3>Submit Ratings</h3>
                </td>
            </tr>
        </table>
        <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
            <asp:Label runat="server" ID="lblvalidationmessage" Style="font-size: 20px; font-weight: normal; padding-left: 15px"></asp:Label>
        </div>

        <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12">
            <asp:GridView ID="gridratings" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-striped table-condensed">
                <Columns>
                    <asp:TemplateField HeaderText="Property id" Visible="false">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblpropertyid" Text='<%#Bind("PROPERTY_ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="First Name" HeaderStyle-Width="50px" ItemStyle-Width="50px">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblownername" Text='<%#Bind("FIRST_NAME") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name" Visible="false">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lbllastname" Text='<%#Bind("LAST_NAME") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Property Address" HeaderStyle-Width="50px" ItemStyle-Width="50px">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblpropertyaddress" Text='<%#Bind("PROPERTY_ADDRESS") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City" HeaderStyle-Width="10px" ItemStyle-Width="10px">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblcity" Text='<%#Bind("CITY") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="State" Visible="false">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblstate" Text='<%#Bind("STATE") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Zipcode" Visible="false">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblzipcode" Text='<%#Bind("ZIPCODE") %>'></asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="User Type" HeaderStyle-Width="10px" ItemStyle-Width="10px">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblusertype" Text='<%#Bind("USER_TYPE") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="How was overall experience with this Landlord/Tenant?" HeaderStyle-Width="300px" ItemStyle-Width="300px">
                        <ItemTemplate>
                            <asp:RadioButton runat="server" ID="rdbtnrating1" Text="Excellent" GroupName="submitratings" />&nbsp;&nbsp;
                                <asp:RadioButton runat="server" ID="rdbtnrating2" Text="Very Good" GroupName="submitratings" />&nbsp;&nbsp;
                                <asp:RadioButton runat="server" ID="rdbtnrating3" Text="Good" GroupName="submitratings" />&nbsp;&nbsp;
                                <asp:RadioButton runat="server" ID="rdbtnrating4" Text="Fair" GroupName="submitratings" />&nbsp;&nbsp;
                                <asp:RadioButton runat="server" ID="rdbtnrating5" Text="Poor" GroupName="submitratings" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Reviews" HeaderStyle-Width="160px" ItemStyle-Width="160px">
                        <ItemTemplate>
                            <asp:TextBox runat="server" ID="txtreviews" Placeholder="Enter your reviews" Rows="3" Columns="30" TextMode="MultiLine" Style="width: 100%"></asp:TextBox>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField Visible="false">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lbllnadlord" Text='<%#Bind("LANDLORD_ID") %>'></asp:Label>
                            <asp:Label runat="server" ID="lbltenant" Text='<%#Bind("TENANT_ID") %>'></asp:Label>

                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Submit" HeaderStyle-Width="10px" ItemStyle-Width="10px">
                        <ItemTemplate>
                            <asp:Button runat="server" ID="btnrate" CssClass="thead-default" Text="Submit" OnClick="btnrate_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
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

