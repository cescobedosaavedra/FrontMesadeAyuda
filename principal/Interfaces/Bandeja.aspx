<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Bandeja.aspx.cs" Inherits="principal.Interfaces.Bandeja" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"><h1 style="color: #333333; font-family: Verdana, Geneva, Tahoma, sans-serif">Bandeja de Entrada
    </h1>
    <p>-</p>

    <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
        <tr>
            <td></td>
        </tr>

        <tr>
            <td>Ticket</td>
            <td>
                <asp:TextBox CssClass="col-box" ID="txt_numeroTicket" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnUsuarios" runat="server" Text="Mantenimiento Usuarios" Height="26px" Width="159px" OnClick="btnUsuarios_Click"/></td>
        </tr>
        <tr>
            <td>Estado</td>
            <td>
                <asp:DropDownList CssClass="col-box" ID="combo_estado" runat="server"></asp:DropDownList></td>
            <td>
                <asp:Button ID="btnListar" runat="server" Text="Listar" Height="26px" Width="159px" OnClick="btn_listar_Click" /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
    <div>
        <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;" id="table_dv">
            <tr>
                <asp:GridView ID="Grid_tickets" runat="server" AllowSorting="True" AutoGenerateSelectButton="false" Width="98%" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanging="Grid_tickets_SelectedIndexChanging"
                    AutoGenerateColumns="false" DataKeyNames="Id" AllowPaging="True" OnPageIndexChanging="Grid_tickets_PageIndexChanging" PageSize="8" >
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="N_ticket" HeaderText="N.Ticket" />
                        <asp:BoundField DataField="F_creacion" HeaderText="Fec.Creacion" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" />
                        <asp:BoundField DataField="AsuntoTicket" HeaderText="Asunto" />
<%--                        <asp:BoundField DataField="NombreEmpleado" HeaderText="NombreEmpleado" />
                        <asp:BoundField DataField="ApellidoEmpleado" HeaderText="ApellidoEmpleado" />--%>
                    </Columns>
                </asp:GridView>  
            </tr>
        </table>
    </div>
                 <div class="pre-scrollable">
						</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
