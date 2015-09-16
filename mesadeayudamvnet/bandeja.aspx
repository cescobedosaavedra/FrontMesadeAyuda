<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="bandeja.aspx.vb" Inherits="mesadeayudamvnet.bandeja" %>

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
                <asp:TextBox CssClass="col-box" ID="TextBox1" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>Estado</td>
            <td>
                <asp:DropDownList CssClass="col-box" ID="DropDownList1" runat="server"></asp:DropDownList></td>
            <td>
                <asp:Button ID="btn_listar" runat="server" Text="Listar" Height="26px" Width="126px" /></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
    </table>
    <table width="950px" style="border: 1px double #666666; border-radius: 6px; -webkit-box-shadow: 10 1px 2px #ff0000; font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: 11px; color: #3C3C3C; background-color: #FFFFFF;" id="table_dv">
        <tr>
            <asp:GridView ID="grid_tickets" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="195px">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
