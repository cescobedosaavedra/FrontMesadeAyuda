<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="principal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilos.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2 {
            width: 99px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="abrigo_general" align="center">


            <div id="login">

                <table>

                    <tr>

                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Css/images/Control_1.png" Width="199px" Height="100px" />
                        </td>


                        <td align="center" class="auto-style2">
                            <h1>Inicio de Sesión</h1>
                        </td>
                    </tr>

                    <tr>
                        <td colspan="2" align="left">Nombre de Usuario:</td>
                    </tr>
                    <tr>
                        <td colspan="2" align="left">
                            <asp:TextBox ID="txtUsuario" runat="server" Width="178px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2" align="left">Password:</td>
                    </tr>
                    <tr>
                        <td colspan="2" align="left">
                            <asp:TextBox ID="txtPassword" runat="server" Width="178px" OnTextChanged="txtPassword_TextChanged"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td colspan="2" align="center">
                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label></td>
                    </tr>

                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Width="150px" OnClick="btnIngresar_Click" /></td>
                    </tr>



                </table>

            </div>


        </div>
    </form>
</body>
</html>
