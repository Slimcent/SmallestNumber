Module Module1

    Sub Main()
        Dim number1 As Integer = InputBox("")
        Dim number2 As Integer = InputBox("")
        Dim number3 As Integer = InputBox("")

        If number1 < number2 AndAlso number1 < number3 Then
            number1 = Integer.Parse(Console.ReadLine())
            MsgBox($"The Smallest number is {number1}")
        ElseIf number2 < number1 AndAlso number2 < number3 Then
            number2 = Integer.Parse(Console.ReadLine())
            MsgBox($"The Smallest number is {number2}")
        ElseIf number3 < number1 AndAlso number3 < number2 Then
            number3 = Integer.Parse(Console.ReadLine())
            MsgBox($"The Smallest number is {number3}")
        End If

    End Sub

End Module
