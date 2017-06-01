<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="LTRS.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .mylinkbutton {
            color: black;
            text-decoration: none;
        }

        input[disabled] {
            cursor: not-allowed;
            pointer-events: all !important;
        }

        .disblecontrol {
            cursor: not-allowed;
            pointer-events: all !important;
        }
    </style>
    <link href="assets/css/mystyle.css" rel="stylesheet" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <script language="javascript" type="text/javascript">
        function CloseBrowser() {
            window.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td align="center" valign="middle" style="padding-top: 20px">
                <label runat="server" id="lblmessage" style="font-size: 40px; font-weight: bold"></label>
            </td>
        </tr>
    </table>
    <div>
        <asp:Label runat="server" ID="lblvalidatemessege" CssClass="control-label" Style="font-size: 20px; font-weight: bold; padding-left: 30px;"></asp:Label>
    </div>
    <div runat="server" id="divchangedata" style="display: none;">
        <table style="width: 95%; padding-left: 10px; padding-right: 10px; margin-bottom: 20px">
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




    <div id="divquery" runat="server" style="display: none;">

        <table style="width: 100%">
            <tr>
                <td class="auto-style1" style="display: none; padding-left: 10px;">
                    <label runat="server" id="lbldatestamp">Date Stamp</label>
                </td>
                <td class="auto-style1" style="padding-left: 10px;">
                    <label runat="server" id="lbluserstatus">User Status</label>
                </td>
                <td class="auto-style1">
                    <label runat="server" id="lbluserid">User Id</label>
                </td>
                <td class="auto-style1">
                    <label runat="server" id="lblusername">User Name</label>
                </td>
                <%--  <td class="auto-style1">
                    <label runat="server" id="lblpassword">Password</label>
                </td>
                <td class="auto-style1">
                    <label runat="server" id="lbldabpassword">DBA Password</label>
                </td>--%>
                <td class="auto-style1">
                    <label runat="server" id="lblslectfirstname">First Name</label>
                </td>

                <td class="auto-style1">
                    <label runat="server" id="lbllastname">Last Name</label>
                </td>
                <td class="auto-style1">
                    <label runat="server" id="lblphoneno">Phone Number</label>
                </td>
                <td class="auto-style1">
                    <label runat="server" id="lblrecoveryemail">Recovery Email</label>
                </td>

                <td class="auto-style1">
                    <label runat="server" id="lblsecurityanswer">Security Answer</label>
                </td>
                <td class="auto-style1">
                    <label runat="server" id="lblusertype">User Type</label>
                </td>
            </tr>
            <tr>
                <td style="padding-left: 10px; display: none">
                    <asp:DropDownList ID="DropDownListdatestamp" runat="server" CssClass="form-control-new" DataValueField="DATE_STAMP" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="DATE_STAMP">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="padding-left: 10px;">
                    <asp:DropDownList ID="DropDownListuserstatus" runat="server" CssClass="form-control-new" DataValueField="USER_STATUS" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="USER_STATUS">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListuserid" runat="server" CssClass="form-control-new" DataValueField="USER_ID" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="USER_ID">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>

                </td>
                <td>
                    <asp:DropDownList ID="DropDownListusername" runat="server" CssClass="form-control-new" DataValueField="USER_NAME" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="USER_NAME">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <%-- <td>
                    <asp:DropDownList ID="DropDownListpassword" runat="server" DataValueField="PASSWORD" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="PASSWORD">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListDbaPassword" runat="server" DataValueField="DBA_PASSWORD" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="DBA_PASSWORD">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>--%>
                <td>
                    <asp:DropDownList ID="DropDownListfirstname" runat="server" CssClass="form-control-new" DataValueField="FIRST_NAME" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="FIRST_NAME">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListlastname" runat="server" CssClass="form-control-new" DataValueField="LAST_NAME" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="LAST_NAME">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListphoneno" runat="server" CssClass="form-control-new" DataValueField="PHONE_NUMBER" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="PHONE_NUMBER">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListrecoveryemail" runat="server" CssClass="form-control-new" DataValueField="RECOVERY_EMAIL" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="RECOVERY_EMAIL">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListSecurityAns" runat="server" CssClass="form-control-new" DataValueField="SECURITY_ANSWER" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="SECURITY_ANSWER">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListusertype" runat="server" CssClass="form-control-new" DataValueField="USER_TYPE" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="USER_TYPE">
                        <asp:ListItem Text="Select" Value="%"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="padding-left: 10px">
                    <asp:Button runat="server" ID="btnsearch" OnClick="btnsearch_Click" Text="Search" />
                </td>

            </tr>

        </table>
    </div>


    <table style="width: 100%;height:320px">
        <tr>

            <td style="padding-top: 20px; width: 100%; padding-left: 10px; padding-right: 10px">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="USER_ID" OnRowDataBound="GridView1_RowDataBound" Visible="False" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderStyle-Width="25px" ItemStyle-Width="95px" ItemStyle-Font-Size="Small">
                            <HeaderTemplate>
                                DATE STEAMP<br />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbldatestamp" Text='<%#Eval("DATE_STAMP") %>' DataFormatString="{0:hh:mm tt}" CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderStyle-Width="15px" ItemStyle-Width="15px">
                            <HeaderTemplate>
                                USER STATUS<br />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbluserstatus" Text='<%#Eval("USER_STATUS") %>' CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderStyle-Width="10px" ItemStyle-Width="10px">
                            <HeaderTemplate>
                                USER ID<br />

                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbluserid" Text='<%#Eval("USER_ID") %>' CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderStyle-Width="30px" ItemStyle-Width="30px">
                            <HeaderTemplate>
                                USER NAME<br />

                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblusername" Text='<%#Eval("USER_NAME") %>' CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-Width="25px" ItemStyle-Width="25px">
                            <HeaderTemplate>
                                PASSWORD<br />

                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblpassword" Text='<%#Eval("PASSWORD") %>'  CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-Width="25px" ItemStyle-Width="25px">
                            <HeaderTemplate>
                                DBA PASSWORD<br />

                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbldbapassword" Text='<%#Eval("DBA_PASSWORD") %>' CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-Width="100px" ItemStyle-Width="100px">
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
                        <asp:TemplateField HeaderStyle-Width="100px" ItemStyle-Width="100px">
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
                        <asp:TemplateField HeaderStyle-Width="45px" ItemStyle-Width="45px">
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
                        <asp:TemplateField HeaderStyle-Width="35px" ItemStyle-Width="35px">
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
                        <asp:TemplateField HeaderStyle-Width="200px" ItemStyle-Width="200px">
                            <HeaderTemplate>
                                SECURITY QUE<br />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblsecurityque" Text='<%#Eval("SECURITY_QUE") %>' CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-Width="100px" ItemStyle-Width="100px">
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
                        <asp:TemplateField HeaderStyle-Width="15px" ItemStyle-Width="15px">
                            <HeaderTemplate>
                                USER TYPE<br />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblusertype" Text='<%#Eval("USER_TYPE") %>' CssClass="disblecontrol"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderStyle-Width="15px" ItemStyle-Width="15px">
                            <HeaderTemplate>
                                <asp:DropDownList runat="server" ID="d" Style="height: 35px; width: 80px" CssClass="form-control-new">
                                    <asp:ListItem Value="Action">Action</asp:ListItem>
                                    <asp:ListItem Value="Change">Change</asp:ListItem>
                                    <asp:ListItem Value="Delete">Delete</asp:ListItem>
                                    <asp:ListItem Value="Query">Query</asp:ListItem>
                                </asp:DropDownList>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:DropDownList runat="server" ID="drpnewaction" CssClass="form-control-new" AutoPostBack="true" OnSelectedIndexChanged="drpnewaction_SelectedIndexChanged" Style="height: 35px; width: 80px">
                                    <asp:ListItem Value="Action">Action</asp:ListItem>
                                    <asp:ListItem Value="Change">Change</asp:ListItem>
                                    <asp:ListItem Value="Delete">Delete</asp:ListItem>
                                    <asp:ListItem Value="Query">Query</asp:ListItem>
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

    </table>

    <asp:Label runat="server" ID="lbluname" Visible="false"></asp:Label>
    <asp:Label runat="server" ID="lblpass1" Visible="false"></asp:Label>
    <asp:Label runat="server" ID="lblpass2" Visible="false"></asp:Label>
    <asp:Label runat="server" ID="lblque" Visible="false"></asp:Label>
    <asp:Label runat="server" ID="lblutype" Visible="false"></asp:Label>
    <table width="100%">
        <tr>

            <td align="center" valign="middle" style="padding-top: 20px">
                <asp:Button runat="server" ID="Button1" Text="Home" CssClass="thead-default" OnClick="btnhome_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="Button2" Text="Next" CssClass="thead-default" OnClick="btnnext_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                         <asp:Button runat="server" ID="Button3" Text="Back" CssClass="thead-default" OnClick="btn_back_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                            <asp:Button runat="server" ID="Button4" Text="Reset" CssClass="thead-default" OnClick="Button4_Click" CausesValidation="false" UseSubmitBehavior="false"></asp:Button>&nbsp;
                        <asp:Button runat="server" ID="btnexit" Text="Exit" CssClass="thead-default" CausesValidation="false" UseSubmitBehavior="false" OnClick="btnexit_Click" />
            </td>
        </tr>
    </table>


</asp:Content>
