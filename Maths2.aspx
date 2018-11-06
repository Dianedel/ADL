<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Maths2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Maths<br />
            <br />
            <asp:TextBox ID="Nb_1" runat="server" Width="67px" OnTextChanged="Nb_1_TextChanged"></asp:TextBox>
&nbsp;<asp:TextBox ID="Nb_2" runat="server" Width="67px" Height="16px" OnTextChanged="Nb_2_TextChanged"></asp:TextBox>
&nbsp;<asp:TextBox ID="Nb_3" runat="server" Height="16px" Width="67px" OnTextChanged="Nb_3_TextChanged"></asp:TextBox>
&nbsp;<asp:TextBox ID="Nb_4" runat="server" Height="16px" Width="67px" OnTextChanged="Nb_4_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Btn_fairedesmaths" runat="server" OnClick="Btn_fairedesmaths_Click" Text="Calculer" Width="312px" />
            <br />
            <br />
            Somme : <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="247px"></asp:TextBox>
            <br />
            <br />
            Valeur minimale :
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="196px"></asp:TextBox>
            <br />
            <br />
            Valeur maximale :
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="190px"></asp:TextBox>
            <br />
            <br />
            Carré des valeurs :
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" Width="49px"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged" Width="51px"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged" Width="40px"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged" Width="44px"></asp:TextBox>
            <br />
            <br />
            <br />
            <a href="Default.aspx">Page d&#39;accueil</a></div>
    </form>
</body>
</html>
