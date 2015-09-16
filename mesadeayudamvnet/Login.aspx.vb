Imports System.Web.UI.WebControls

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "" And txtPassword.Text = "" Then
            MsgBox("Los campos se encuentran vacios")
        Else
            If txtUsuario.Text = "" Then
                MsgBox("El campo USUARIO se encuentra vacio")
            Else
                If txtPassword.Text = "" Then
                    MsgBox("El campo CONTRASEÑA se encuentra vacio")
                Else
                    If txtUsuario.Text = "Christian" And txtPassword.Text = "1234" Then
                        Response.Redirect("principal.RegistroTickets.aspx")

                    Else
                        MsgBox("Los datos son incorrectos")
                    End If
                End If
            End If
        End If


        'If txtUsuario.Text <> "Christian" And txtPassword.Text <> "123456" Then

        'Else
        '    lblError.Text = "Faltan completar datos"
        '    lblError.Visible = True

        'End If





    End Sub
End Class