/*********************************************ALERTA DE MENSAJES**********************************/
function GenerarMensaje(mensaje, evento) {
    var alerta, alertstyle;

    if (evento == "ok") {
        alertstyle = "alert-success";
    } else if (evento == "error") {
        alertstyle = "alert-danger";
    } else if (evento == "warning") {
        alertstyle = "alert-warning";
    }

    alerta = '<div class="alert alert-block ' + alertstyle + '" runat="server">' + mensaje + '</div>';

    return alerta;
}