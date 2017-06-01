<%@ Page Title="" Language="C#" MasterPageFile="~/LTRSMaster.Master" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="LTRS.Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="USER_ID" OnRowEditing="GridView1_RowEditing" OnRowCommand="GridView1_RowCommand">
        <Columns>

            <asp:TemplateField>
                <HeaderTemplate>
                    User Id<br />

                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label runat="server" ID="lbluserid" Text='<%#Eval("USER_ID") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtid" Text='<%#Eval("USER_ID") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    First name<br />

                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label runat="server" ID="lblfname" Text='<%#Eval("FIRST_NAME") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtfname" Text='<%#Eval("FIRST_NAME") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>
                    Last name<br />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label runat="server" ID="lbllname" Text='<%#Eval("LAST_NAME") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtlname" Text='<%#Eval("LAST_NAME") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width="40px" ItemStyle-Width="40px" ControlStyle-Width="40px">
                <ItemTemplate>
                    <asp:DropDownList runat="server" ID="drpaction" Style="height: 40px" AutoPostBack="true" OnSelectedIndexChanged="drpaction_SelectedIndexChanged">
                        <asp:ListItem Value="Action">Action</asp:ListItem>
                        <asp:ListItem Value="Change">Change</asp:ListItem>
                        <asp:ListItem Value="Delete">Delete</asp:ListItem>
                        <asp:ListItem Value="Query">Query</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width="40px" ItemStyle-Width="40px" ControlStyle-Width="40px">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                </EditItemTemplate>

                <ItemTemplate>
                    <asp:LinkButton runat="server" ID="lnlbtnedit" Text="Edit" CommandName="Edit" CommandArgument='<%# Container.DataItemIndex %>' CausesValidation="false" OnClick="lnlbtnedit_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>


    </asp:GridView>
</asp:Content>
