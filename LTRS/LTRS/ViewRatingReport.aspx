<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="ViewRatingReport.aspx.cs" Inherits="LTRS.ViewRatingReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    </div>
    <div class="col-xl-12 col-md-12 col-sm-12 col-lg-12" style="height:300px">
        <asp:GridView ID="gridratings" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-striped table-condensed">
            <Columns>

                <asp:TemplateField HeaderText="From" HeaderStyle-Width="50px" ItemStyle-Width="50px">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblownername" Text='<%#Bind("FIRST_NAME") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="To" HeaderStyle-Width="50px" ItemStyle-Width="50px">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lbllastname" Text='<%#Bind("TO_FULL_NAME") %>'></asp:Label>
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
                <asp:TemplateField HeaderText="From User" HeaderStyle-Width="30px" ItemStyle-Width="30px">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblusertypefrom" Text='<%#Bind("FROM_USER_TYPE") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="From User" HeaderStyle-Width="30px" ItemStyle-Width="30px">
                    <ItemTemplate>
                        <asp:Label runat="server" ID="lblusertypeTo" Text='<%#Bind("TO_USER_TYPE") %>'></asp:Label>
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
                        <asp:Label runat="server" ID="lblreview" Text='<%#Bind("REVIEWS") %>'></asp:Label>

                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>
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
