<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Cadastro Contato</h1>


        
            <br />
            Nome:
            <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Data Nascimento&nbsp;
            <asp:TextBox ID="nascimentoTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Email Profissional&nbsp;&nbsp;
            <asp:TextBox ID="emailProfTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Email Pessoal&nbsp;&nbsp;
            <asp:TextBox ID="emailPessTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Telefone&nbsp;
            <asp:TextBox ID="telefoneTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:DropDownList ID="tipoTelefoneDropDownList" runat="server">
                <asp:ListItem Value="Celular"></asp:ListItem>
                <asp:ListItem Value="Comercial"></asp:ListItem>
                <asp:ListItem Value="Residencial"></asp:ListItem>
                <asp:ListItem Value="Fax"></asp:ListItem>
                <asp:ListItem Value="Outro"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
            <br />


        
        </div>
    </form>
</body>
</html>
