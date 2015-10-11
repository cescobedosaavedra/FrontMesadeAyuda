<%@ Page Title="" Language="C#" MasterPageFile="../MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="BandejaREST.aspx.cs" Inherits="principal.Interfaces.BandejaREST" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1 style="color: #333333; font-family: Verdana, Geneva, Tahoma, sans-serif">Bandeja de Entrada</h1>
    <p>-</p>
    
    <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;">
        <tr>
            <td></td>
        </tr>
       
         <tr>
            <td>Ticket</td>
            <td>
                <asp:TextBox CssClass="col-box" ID="text_numeroTicket" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>Estado</td>
            <td>
                <asp:DropDownList CssClass="col-box" ID="combo_estado" runat="server"></asp:DropDownList></td>
            <td>
                <asp:Button ID="btnListar" runat="server" Text="Listar" Height="26px" Width="126px" OnClick="btn_listar_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
    </table>
    <div>
    <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;" id="table_dv">
        <tr>
            <asp:GridView ID="Grid_tickets" runat="server"></asp:GridView>
        </tr>
    </table>
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

