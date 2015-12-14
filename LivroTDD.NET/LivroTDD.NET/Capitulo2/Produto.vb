Namespace Capitulo2
    Public Class Produto
        Public Property Nome As String
        Public Property Valor As Decimal

        Public Sub New(ByVal nome As String, ByVal valor As Decimal)
            Me.Nome = nome
            Me.Valor = valor
        End Sub
    End Class
End NameSpace