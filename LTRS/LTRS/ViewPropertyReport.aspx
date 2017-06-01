<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="ViewPropertyReport.aspx.cs" Inherits="LTRS.ViewPropertyReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">
    <div class="container" style="margin-left: 0px">
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
            <div style="height: 300px">
                <div class="row" id="divpropertygrid" runat="server" style="display: none">
                    <div class="col-lg-12 col-md-12">

                        <asp:GridView runat="server" ID="gridproperty" AutoGenerateColumns="false" CssClass="table table-bordered table-striped table-condensed">
                            <Columns>
                                <asp:TemplateField HeaderText="Property id" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblpropertyid" Text='<%#Bind("PROPERTY_ID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Property Photo" ControlStyle-Width="120px" ItemStyle-Width="70px">
                                    <ItemTemplate>
                                        <asp:Image runat="server" ImageUrl='<%#Eval("PHOTOS") %>' Height="70px" Width="70px" ID="imageproperty" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Owner Name" ControlStyle-Width="100px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblownername" Text='<%#Eval("OWNER_NAME") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Property Type" ControlStyle-Width="120px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="Label1" Text='<%#Eval("PROPERTY_TYPE") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Contact Number" ControlStyle-Width="130px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblcontactnumber" Text='<%#Eval("CONTACT_NUMBER") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Built Date" ControlStyle-Width="100px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblbuiltdate" Text='<%#Eval("BUILTDATE") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Property Address" ControlStyle-Width="190px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lbladdress" Text='<%#Eval("PROPERTY_ADDRESS") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="City" ControlStyle-Width="100px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblcity" Text='<%#Eval("CITY") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="State" ControlStyle-Width="100px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblstate" Text='<%#Eval("STATE") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Rent" ControlStyle-Width="100px">
                                    <ItemTemplate>
                                        <asp:Label runat="server" ID="lblrent" Text='<%#Eval("RENT") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
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
