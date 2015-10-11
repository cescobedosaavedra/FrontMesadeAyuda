<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="MantenimientoUsuarios.aspx.cs" Inherits="principal.Interfaces.MantenimientoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div id="formulario">
        <%--       <asp:Panel Height="1px" ID="Panel2" runat="server">
        </asp:Panel>--%>
        <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
            <tr>
                <td style="text-decoration: underline">
                    <asp:Button ID="btn_cargar" runat="server" Text="Cargar Datos de empleado" Width="170px" OnClick="btn_cargar_Click" />
                </td>
                <td >&nbsp;</td>
                <td >&nbsp;</td>
                <td >&nbsp;</td>
            </tr>
            <tr>
                <td style="text-decoration: underline">
                    Código de Empleado:</td>
                <td >
                    <asp:TextBox CssClass="col-box" ID="txt_dni" runat="server"></asp:TextBox></td>
                <td >&nbsp;</td>
                <td >&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 20%">Nombres:</td>
                <td style="width: 30%">
                    <asp:TextBox CssClass="col-box" ID="txt_nombre" runat="server"></asp:TextBox>
                </td>
                <td style="width: 15%">
                    Área:</td>
                <td style="width: 35%">
                    <asp:TextBox CssClass="col-box" ID="txt_area" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Apellidos:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_apellido" runat="server"></asp:TextBox>
                </td>
                <td>Correo:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_correo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Cargo:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_cargo" runat="server"></asp:TextBox>
                </td>
                <td>
                    Teléfono / Celular:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_telefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Contador Error Login</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_LoginCountError" runat="server"></asp:TextBox>
                </td>
                <td>Estado</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_estado" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_password" runat="server"></asp:TextBox>
                </td>
                <td>
                    Tipo</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_tipo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <div id="mensaje"></div>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btn_registrar" runat="server" Text="Actualizar" Height="26px" Width="126px" OnClick="btn_registrar_Click" />
                </td>
            </tr>
        </table>
        <%--  <asp:Panel class="col-Tablebox" Height="420px" ID="Panel1" runat="server" >--%><%--<asp:Label ID="lbl_mensaje" runat="server" Text="Label"></asp:Label>--%><%--       </asp:Panel>--%>
        
        <%--       </asp:Panel>--%>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>


