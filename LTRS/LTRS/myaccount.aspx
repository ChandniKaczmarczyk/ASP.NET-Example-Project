<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="myaccount.aspx.cs" Inherits="LTRS.myaccount" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .mylinkbutton {
            color: black;
            text-decoration: none;
        }

        .disblecontrol {
            cursor: not-allowed;
            pointer-events: all !important;
        }
    </style>
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
                        <label id="lblmessage" runat="server" style="font-size: 40px; font-weight: bold; padding-left: 30px"></label>
                    </td>
                </tr>
            </table>
        </div>
        <div class="row">
            <asp:Label runat="server" ID="lblvalidatemessege" CssClass="control-label" Style="font-size: 20px; font-weight: bold; padding-left: 30px;"></asp:Label>
        </div>
        <div id="txtvalidation" runat="server" style="display: none">
            <table style="width: 95%; padding-left: 10px; padding-right: 10px; margin-bottom: 10px">
                <tr>
                    <td style="padding-left: 10px;">
                        <label>First name </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtfirstnamedemo" CssClass="form-control-new"></asp:TextBox></td>
                    <td style="padding-left: 30px;">
                        <label>Last name </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtlastnamedemo" CssClass="form-control-new"></asp:TextBox></td>
                    <td style="padding-left: 30px;">
                        <label>Contact Number </label>
                    </td>
                    <td style="padding-right: 30px;">
                        <asp:TextBox runat="server" ID="txtphonenumberdemo" pattern="[0-9]{10}" onkeypress='return event.charCode >= 48 && event.charCode <= 57' class="form-control-new" placeholder="Contact number"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="padding-left: 10px;">
                        <label>Email </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtemaidemo" CssClass="form-control-new"></asp:TextBox></td>
                    <td style="padding-left: 30px;">
                        <label>Security Answer </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtsecurityanswer" CssClass="form-control-new"></asp:TextBox></td>
                    <td style="padding-left: 30px;">
                        <asp:Button runat="server" ID="btneditdata" CssClass="thead-default" Text="Change" OnClick="btneditdata_Click" /></td>
                    <td></td>
                </tr>
            </table>
        </div>
        <asp:HiddenField runat="server" ID="hfuserid" />

    </div>
    <div>
        <table width="100%" style="height:320px">
            <tr>

                <td align="center" valign="middle" style="padding-top: 20px; width: 50px; padding-left: 10px; padding-right: 10px;">

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="USER_ID" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    DATE STEAMP<br />

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbldatestamp" Text='<%#Eval("DATE_STAMP") %>' DataFormatString="{0:MM/dd/yyyy HH:mm:ss:fff}" CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <HeaderTemplate>
                                    USER STATUS<br />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbluserstatus" Text='<%#Eval("USER_STATUS") %>' CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <HeaderTemplate>
                                    USER ID<br />

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbluserid" Text='<%#Eval("USER_ID") %>' CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <HeaderTemplate>
                                    USER NAME<br />

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblusername" Text='<%#Eval("USER_NAME") %>' CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    PASSWORD<br />

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblpassword" Text='<%#Eval("PASSWORD") %>' CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    DBA PASSWORD<br />

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbldbapassword" Text='<%#Eval("DBA_PASSWORD") %>' CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    FIRST NAME<br />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblfirstname" Text='<%#Eval("FIRST_NAME") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtfirstname" Text='<%#Eval("FIRST_NAME") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    LAST NAME<br />

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbllastname" Text='<%#Eval("LAST_NAME") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtlastname" Text='<%#Eval("LAST_NAME") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    PHONE NUMBER<br />

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblphonenumber" Text='<%#Eval("PHONE_NUMBER") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtphonenumber" Text='<%#Eval("PHONE_NUMBER") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    EMAIL<br />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblemail" Text='<%#Eval("RECOVERY_EMAIL") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtemail" Text='<%#Eval("RECOVERY_EMAIL") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    SECURITY QUE<br />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblsecurityque" Text='<%#Eval("SECURITY_QUE") %>' CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    SECURITY ANSWER<br />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblsecurityanswer" Text='<%#Eval("SECURITY_ANSWER") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" ID="txtsecurityanswer" Text='<%#Eval("SECURITY_ANSWER") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    USER TYPE<br />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblusertype" Text='<%#Eval("USER_TYPE") %>' CssClass="disblecontrol"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <HeaderTemplate>
                                    ACTION<br />

                                </HeaderTemplate>
                                <ItemTemplate>

                                    <asp:Button runat="server" ID="btnchange" Text="Change" OnClick="btnchange_Click" />


                                </ItemTemplate>
                            </asp:TemplateField>


                        </Columns>
                    </asp:GridView>
                </td>
            </tr>

        </table>
        <label id="lblinvalidmessage" runat="server" style="font-size: 40px; font-weight: bold; padding-left: 30px"></label>
        <div>
            <table width="100%">
                <tr>

                    <td align="center" valign="middle" style="padding-top: 20px; width: 50px"></td>
                </tr>
            </table>
        </div>


        <div>
            <table width="100%">
                <tr>

                    <td align="center" valign="middle" style="padding-top: 20px">
                        <asp:Button runat="server" ID="Button1" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button2" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="Button3" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="Button4" Text="Reset" CssClass="thead-default" OnClick="btnreset_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />

                    </td>
                </tr>
            </table>
        </div>

    </div>
</asp:Content>
