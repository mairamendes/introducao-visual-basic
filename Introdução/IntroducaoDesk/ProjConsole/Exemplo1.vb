Module Exemplo1

    Sub Main()
        ' Dim: Declaração da variável
        Dim info As String

        ' Console.Write: Exibe uma mensagem 
        Console.Write("Entre com a informação: ")

        ' Lê a entrada do usuário
        info = Console.ReadLine()

        ' Exibe a informação digitada
        Console.WriteLine("A informação digitada foi: {0} ", info)

        Console.ReadKey()
    End Sub

End Module
