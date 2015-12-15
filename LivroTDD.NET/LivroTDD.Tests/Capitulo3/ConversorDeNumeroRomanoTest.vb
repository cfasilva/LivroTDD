Imports LivroTDD.NET.Capitulo3
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace Capitulo3

    <TestClass()> Public Class ConversorDeNumeroRomanoTest

        <TestMethod()> Public Sub DeveEntenderOSimboloI()
            Dim romano = New ConversorDeNumeroRomano()
            Dim numero As Integer = romano.Converte("I")
            Assert.AreEqual(1, numero)
        End Sub

        <TestMethod()> Public Sub DeveEntenderOSimboloV()
            Dim romano = New ConversorDeNumeroRomano()
            Dim numero As Integer = romano.Converte("V")
            Assert.AreEqual(5, numero)
        End Sub

        <TestMethod()> Public Sub DeveEntenderOSimboloX()
            Dim romano = New ConversorDeNumeroRomano()
            Dim numero As Integer = romano.Converte("X")
            Assert.AreEqual(10, numero)
        End Sub

        <TestMethod()> Public Sub DeveEntenderDoisSimbolosComoII()
            Dim romano = New ConversorDeNumeroRomano()
            Dim numero As Integer = romano.Converte("II")
            Assert.AreEqual(2, numero)
        End Sub

        <TestMethod()> Public Sub DeveEntenderQuatroSimbolosDoisADoisComoXXII()
            Dim romano = New ConversorDeNumeroRomano()
            Dim numero As Integer = romano.Converte("XXII")
            Assert.AreEqual(22, numero)
        End Sub

        <TestMethod()> Public Sub DeveEntenderNumerosComoIX()
            Dim romano = New ConversorDeNumeroRomano()
            Dim numero As Integer = romano.Converte("IX")
            Assert.AreEqual(9, numero)
        End Sub

        <TestMethod()> Public Sub DeveEntenderNumerosComplexosComoXXIV()
            Dim romano = New ConversorDeNumeroRomano()
            Dim numero As Integer = romano.Converte("XXIV")
            Assert.AreEqual(24, numero)
        End Sub

    End Class
End NameSpace