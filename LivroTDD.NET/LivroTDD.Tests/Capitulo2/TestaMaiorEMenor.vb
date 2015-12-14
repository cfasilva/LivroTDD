Imports System.Text
Imports LivroTDD.NET.Capitulo2
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace Capitulo2

    <TestClass()> Public Class TestaMaiorEMenor

        <TestMethod()> Public Sub OrdemCrescente()
            'Arrange (Cenário)
            Dim carrinho = New CarrinhoDeCompras()
            carrinho.Adiciona(New Produto("Liquidificador", 250.0D))
            carrinho.Adiciona(New Produto("Geladeira", 450.0D))
            carrinho.Adiciona(New Produto("Jogo de pratos", 70.0D))

            'Act (Ação)
            Dim algoritmo = New MaiorEMenor()
            algoritmo.Encontra(carrinho)

            'Assert (Verificação)
            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome)
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome)
        End Sub
        

        <TestMethod()> Public Sub OrdemDecrescente()
            'Arrange (Cenário)
            Dim carrinho = New CarrinhoDeCompras()
            carrinho.Adiciona(New Produto("Geladeira", 450.0D))
            carrinho.Adiciona(New Produto("Liquidificador", 250.0D))
            carrinho.Adiciona(New Produto("Jogo de pratos", 70.0D))

            'Act (Ação)
            Dim algoritmo = New MaiorEMenor()
            algoritmo.Encontra(carrinho)

            'Assert (Verificação)
            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome)
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome)
        End Sub

    End Class
End NameSpace