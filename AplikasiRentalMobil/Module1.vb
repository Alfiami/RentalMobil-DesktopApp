Imports System.Data.Odbc
Module Module1
    Public konek As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand

    Sub KonekDB()
        Try
            konek = New OdbcConnection("DSN=RENTALMOBIL1; multipleactiveresultsets=true")
            If konek.State = ConnectionState.Closed Then
                konek.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal", vbExclamation, "koneksi gagal")


        End Try

    End Sub

End Module
