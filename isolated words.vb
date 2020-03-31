Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim nextchar As Char
        Dim count As Integer

        str1 = " "
        str2 = " "
        nextchar = " "
        count = 0

        Console.Write("enter sring: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = LCase(Mid(str1, count, 1))
            If nextchar >= "a" And nextchar <= "z" Then

                str2 = str2 & nextchar
            Else
                If nextchar = str2 Then
                    Console.WriteLine(str2)
                    str2 = " "
                End If

            End If
        Next
        Console.WriteLine(str2)
        Console.ReadKey()



    End Sub

End Module
