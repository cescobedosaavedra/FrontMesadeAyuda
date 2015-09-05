<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="registrotickets.aspx.vb" Inherits="mesadeayudamvnet.registrotickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div id="formulario">
        <asp:Panel Height="128px" ID="Panel5" runat="server">
            <table width="950px" style="border: 1px double #000000; border-top-left-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
                <tr>
                    <td>Nombres</td>
                    <td>Apellidos</td>
                    <td>Correo</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_nombre" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_apellido" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_correo" runat="server"></asp:TextBox>
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
                    </td>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_telefono" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList CssClass="col-box" ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>

        <asp:Panel Height="1px" ID="Panel2" runat="server">
        </asp:Panel>

        <asp:Panel class="col-Tablebox" Height="420px" ID="Panel1" runat="server">
            <table width="950px" style="border: 1px double #000000; border-top-left-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
                <tr>
                    <td>Ticket</td>
                    <td>Fecha de creación</td>
                    <td>Tiempo transcurrido</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_Numticket" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_FechaCreacion" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_TiempoT" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Estado</td>
                    <td>Prioridad</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox CssClass="col-box" ID="txt_estadoTicket" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txt_prioridad" runat="server" CssClass="col-box"></asp:TextBox>
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
                        <asp:TextBox CssClass="col-box" ID="TextBox1" runat="server" Width="900px"></asp:TextBox>
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
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="btn_registrar" runat="server" Text="Registrar" Height="26px" Width="126px" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td align="center">
                        <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo registro" Height="26px" Width="140px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>

       
  
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
