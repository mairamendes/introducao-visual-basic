Module Exemplo3
    Sub Main()

        Dim nota As Integer = 82
        Dim media As Integer = 60

        ' If nota > media And nota > 55 Then
        If nota < media Or nota < 55 Then
            'Console.WriteLine("Aprovado")
        ElseIf nota > 80 Then
            'Console.WriteLine("Aprovado cm nota boa {0}", nota)
        End If

        'Switch Case
        Select Case nota
            Case Is < 60
                Console.WriteLine("Reprovado")
            Case 60 To 80
                Console.WriteLine("Aprovado")
            Case Is > 80
                Console.WriteLine("Aprovado com nota boa {0}", nota)
            Case Else
                Console.WriteLine("Nota inválida")
        End Select

        Console.ReadKey()

    End Sub
End Module
