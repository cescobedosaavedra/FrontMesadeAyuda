Imports System.Data.SqlClient


Public Class registrotickets
    Inherits System.Web.UI.Page
    'Dim usuarios As New WebUsuariosServices.Empleados
    'Dim usuarios As New WebUsuariosServices.Empleados

    Dim codigo As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_FechaCreacion.Text = Date.Now()





    End Sub

    Protected Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        'Dim usuarios As New UsuariosServices.Empleado
        'Dim dni As Integer = txt_dni.Text
        'txt_nombre.Text = usuarios.NombreEmpleado



        txt_apellido.Text = ""
        txt_cargo.Text = ""
        txt_correo.Text = ""
        txt_descripcion.Text = ""
        txt_dni.Text = ""
        txt_nombre.Text = ""
        txt_Numticket.Text = ""
        txt_telefono.Text = ""
        txt_TiempoT.Text = ""

    End Sub

    'Sub buscar_usuario()

    '    'Crea la referencia al web service de java

    '    Dim jws As New UsuariosServices.Empleado

    '    Dim ced As String = CInt(Me.txt_dni.Text.Trim)

    '    'Llama al metodo buscarUsuarioCedula del web service que esta en java

    '    'Si devuelve verdadero es porque se encontro ese dato

    '    Dim funciono As Boolean = jws.

    '    If funciono = True Then

    '        'Establece los valores a los controles del formulario

    '        Me.txt_nombre.Text = CStr(jws.ObtenerEmpleado)

    '        Me.txt_apellido.Text = CStr(jws.MostrarApellido)

    '        Me.txt_correo.Text = CStr(jws.MostrarDireccion)

    '        Me.txt_cargo.Text = CStr(jws.MostrarSexo)

    '    Else

    '        MsgBox("No se ha encontrado Ningun Usuario Con la Cedula que usted ha ingresado, Verifique!", MsgBoxStyle.Exclamation, "Notificacion")

    '        limpiar_cajas()

    '    End If

    'End Sub

    Protected Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        'txt_nombre.Text = usuarios.ObtenerEmpleado(CodEmpleado:=Integer.Parse(txt_dni.Text), CodEmpleadoSpecified:=txt_dni.Text).ToString
        'txt_nombre.Text = usuarios.NombreEmpleado(txt_dni.Text)

        'Try
        'If IsDBNull(usuarios.NombreEmpleado(ced)) Then
        '    MsgBox("null")
        'End If



        'txt_nombre.Text = usuarios.ApellidoEmpleado("113")
        'Dim funciono As String = usuarios.NombreEmpleado(ced)
        ''If funciono = True Then
        'txt_nombre.Text = usuarios.NombreEmpleado
        'Else
        'MsgBox("No se ha encontrado Ningun Usuario Con la Cedula que usted ha ingresado, Verifique!", MsgBoxStyle.Exclamation, "Notificacion")
        'End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

    End Sub
End Class