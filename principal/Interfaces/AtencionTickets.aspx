<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="AtencionTickets.aspx.cs" Inherits="principal.Interfaces.AtencionTickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div id="formulario">
        <%--       <asp:Panel Height="1px" ID="Panel2" runat="server">
        </asp:Panel>--%>
        <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
            <tr>
                <td style="text-decoration: underline">DATOS DE EMPLEADO</td>
                <td ></td>
                <td >&nbsp;</td>
                <td >&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 20%">Código de Empleado:</td>
                <td style="width: 30%">
                    <asp:TextBox CssClass="col-box" ID="txt_dni" runat="server"></asp:TextBox></td>
                <td style="width: 15%">
                    Área:</td>
                <td style="width: 35%">
                    <asp:TextBox CssClass="col-box" ID="txt_area" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nombres:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_nombre" runat="server"></asp:TextBox>
                </td>
                <td>Correo:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_correo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Apellidos:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_apellido" runat="server"></asp:TextBox>
                </td>
                <td>
                    Teléfono / Celular:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_telefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Cargo:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_cargo" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_Id" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <%--  <asp:Panel class="col-Tablebox" Height="420px" ID="Panel1" runat="server" >--%><%--<asp:Label ID="lbl_mensaje" runat="server" Text="Label"></asp:Label>--%><%--       </asp:Panel>--%>
        <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
            <tr>
                <td style="text-decoration: underline; width: 176px;">DETALLE DE TICKET</td>
                <td></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 20%">Número de Ticket:</td>
                <td style="width: 30%">
                    <asp:TextBox CssClass="col-box" ID="txt_Numticket" runat="server"></asp:TextBox>
                </td>
                <td style="width: 15%">Estado actual de ticket:</td>
                <td style="width: 35%">
                    <asp:TextBox CssClass="col-box" ID="txt_estado" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    Fecha de creación:</td>
                <td >
                    <asp:TextBox CssClass="col-box" ID="txt_FechaCreacion" runat="server"></asp:TextBox>
                </td>
                <td>
                    Prioridad:</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_Prioridad" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td >Código de PC:</td>
                <td >
                    <asp:TextBox CssClass="col-box" ID="txt_codigoPC" runat="server"></asp:TextBox>

                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td >&nbsp;</td>
                <td >
                    &nbsp;</td>
                <td align="right">&nbsp;&nbsp;&nbsp; </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:DropDownList CssClass="col-box" ID="comb_estado" runat="server">
                        <asp:ListItem> Seleccionar </asp:ListItem>
                        <asp:ListItem> Pendiente </asp:ListItem>
                        <asp:ListItem> En proceso </asp:ListItem>
                        <asp:ListItem> Resuelto </asp:ListItem>


                    </asp:DropDownList>

                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>


            <tr>
                <td colspan="2">Asunto</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:TextBox CssClass="col-box" ID="txt_asunto" runat="server" Width="900px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">Descripción</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:TextBox CssClass="col-box" ID="txt_descripcion" runat="server" Height="100px" Width="900px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">Detalle Atención</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:TextBox CssClass="col-box" ID="txt_detalleatencion" runat="server" Height="100px" Width="900px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    &nbsp;</td>
                <td >
                    &nbsp;</td >
                <td align="center">
                    <asp:Button ID="btn_registrar" runat="server" Text="Actualizar" Height="26px" Width="126px" OnClick="btn_registrar_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <%--       </asp:Panel>--%>
                    <div id="mensaje"></div>
                </td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
        </table>
        <%--       </asp:Panel>--%>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>


