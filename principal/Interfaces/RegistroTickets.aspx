<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="RegistroTickets.aspx.cs" Inherits="principal.Interfaces.RegistroTickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div id="formulario">
        <%-- <asp:Panel Height="128px" ID="Panel5" runat="server">--%>
        <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
            <tr>
                <td>Desarrollo en C#</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Ingrese su DNI</td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_dni" ErrorMessage="RequiredFieldValidator" Text="DNI Requerido" Font-Bold="True" ForeColor="Red" ValidationGroup="dni"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_dni" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btn_cargar" runat="server" Text="Consultar" Height="26px" Width="126px" ValidationGroup="dni" OnClick="btn_cargar_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Nombres</td>
                <td>Apellidos</td>
                <td>Correo</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_nombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_nombre" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_nombre" Text="*" CssClass="col-rf" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_apellido" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_apellido" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_apellido" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_correo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_correo" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_correo" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Cargo</td>
                <td>Teléfono / Celular</td>
                <td>Área</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_cargo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_cargo" runat="server" ErrorMessage="RequiredFieldValidator" Text="*" ControlToValidate="txt_cargo" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_telefono" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_telefono" runat="server" ErrorMessage="RequiredFieldValidator" Text="*" ControlToValidate="txt_telefono" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_area" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <%--    </asp:Panel>--%>
        <%--       <asp:Panel Height="1px" ID="Panel2" runat="server">
        </asp:Panel>--%>
        <%--  <asp:Panel class="col-Tablebox" Height="420px" ID="Panel1" runat="server" >--%>
        <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
            <tr>
                <td>Fecha de creación</td>
                <td>&nbsp;</td>
                <td>Código o Nombre de host PC</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_FechaCreacion" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox CssClass="col-box" ID="txt_codigoPC" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>Estado</td>
                <td>Prioridad</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList CssClass="col-box" ID="comb_estado" runat="server">
                        <asp:ListItem>Pendiente</asp:ListItem>
                        <asp:ListItem>En proceso</asp:ListItem>
                        <asp:ListItem>Resuelto</asp:ListItem>


                    </asp:DropDownList>

                </td>
                <td>
                    <asp:DropDownList CssClass="col-box" ID="comb_prioridad" runat="server">
                        <asp:ListItem>Seleccionar</asp:ListItem>
                        <asp:ListItem>Urgente</asp:ListItem>
                        <asp:ListItem>Alta</asp:ListItem>
                        <asp:ListItem>Media</asp:ListItem>
                        <asp:ListItem>Baja</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>


            <tr>
                <td>Asunto</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:TextBox CssClass="col-box" ID="txt_asunto" runat="server" Width="900px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rf_asunto" runat="server" ErrorMessage="RequiredFieldValidator" Text="*" ControlToValidate="txt_asunto" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Descripción</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:TextBox CssClass="col-box" ID="txt_descripcion" runat="server" Height="100px" Width="900px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" Text="*" ControlToValidate="txt_descripcion" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btn_registrar" runat="server" Text="Registrar" Height="26px" Width="126px" OnClick="btn_registrar_Click" />
                </td>
                <td>&nbsp;</td>
                <td align="center">
                    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo registro" Height="26px" Width="140px" CausesValidation="False" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <%--<asp:Label ID="lbl_mensaje" runat="server" Text="Label"></asp:Label>--%>
                    <div id="mensaje"></div>
                </td>
            </tr>
            <tr>
                <td colspan="3">&nbsp;</td>
            </tr>
        </table>
        <%--       </asp:Panel>--%>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>


