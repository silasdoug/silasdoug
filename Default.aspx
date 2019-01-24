<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:LinkButton ID="ALinkButton" runat="server" OnClick="ALinkButton_Click" >A</asp:LinkButton>
&nbsp;<asp:LinkButton ID="BLinkButton" runat="server" OnClick="BLinkButton_Click">B</asp:LinkButton>
&nbsp;<asp:LinkButton ID="CLinkButton" runat="server" OnClick="CLinkButton_Click">C</asp:LinkButton>
&nbsp;<asp:LinkButton ID="DLinkButton" runat="server" OnClick="DLinkButton_Click">D</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="ELinkButton" runat="server" OnClick="ELinkButton_Click">E</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="FLinkButton" runat="server" OnClick="FLinkButton_Click">F</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="GLinkButton" runat="server" OnClick="GLinkButton_Click">G</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="HLinkButton" runat="server" OnClick="HLinkButton_Click">H</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="ILinkButton" runat="server" OnClick="ILinkButton_Click">I</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="JLinkButton" runat="server" OnClick="JLinkButton_Click">J</asp:LinkButton>
           &nbsp;<asp:LinkButton ID="KLinkButton" runat="server" OnClick="KLinkButton_Click">K</asp:LinkButton>
           &nbsp;<asp:LinkButton ID="LLinkButton" runat="server" OnClick="LLinkButton_Click">L</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="MLinkButton" runat="server" OnClick="MLinkButton_Click">M</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="NLinkButton" runat="server" OnClick="NLinkButton_Click">N</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="OLinkButton" runat="server" OnClick="OLinkButton_Click">O</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="PLinkButton" runat="server" OnClick="PLinkButton_Click">P</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="QLinkButton" runat="server" OnClick="QLinkButton_Click">Q</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="RLinkButton" runat="server" OnClick="RLinkButton_Click">R</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="SLinkButton" runat="server" OnClick="SLinkButton_Click">S</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="TLinkButton" runat="server" OnClick="TLinkButton_Click">T</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="ULinkButton" runat="server" OnClick="ULinkButton_Click">U</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="VLinkButton" runat="server" OnClick="VLinkButton_Click">V</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="XLinkButton" runat="server" OnClick="XLinkButton_Click">X</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="YLinkButton" runat="server" OnClick="YLinkButton_Click">Y</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="WLinkButton" runat="server" OnClick="WLinkButton_Click">W</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="ZLinkButton" runat="server" OnClick="ZLinkButton_Click">Z</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="TodosLinkButton" runat="server" OnClick="TodosLinkButton_Click">Todos</asp:LinkButton>
            <br />
            <br />
            <asp:GridView ID="testeGridView" runat="server" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" >
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" Text='<%#Eval("nomeContato") %>' CommandName="Select" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>  <ItemTemplate>    <%#Eval("nascimentoContato") %>    </ItemTemplate></asp:TemplateField>
                    <asp:TemplateField><ItemTemplate>    <%#Eval("Email") %>    </ItemTemplate></asp:TemplateField>
                    <asp:TemplateField><ItemTemplate>    <%#Eval("telefoneContato") %>    </ItemTemplate></asp:TemplateField>
                    <asp:TemplateField><ItemTemplate>    <%#Eval("tipoTelefoneContato") %>    </ItemTemplate></asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Cadastro.aspx">Cadastrar Novo Item</asp:LinkButton>
            <br />
                    <br />
                    <br />
            &nbsp;
            <br />
            <br />
            <br />

                    <br />

        </div>
    </form>
</body>
</html>

