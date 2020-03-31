Module Module1

    Sub Main()
        Dim firstword, secondword As String
        Dim nextchar As Char
        Dim flag As Boolean
        Dim count As Integer

        firstword = " "
        secondword = " "
        nextchar = " "
        flag = True
        count = 0

        Console.Write("enter firstword: ")
        firstword = Console.ReadLine
        firstword = UCase(firstword)

        Console.Write("enter secondword: ")
        secondword = Console.ReadLine
        secondword = UCase(secondword)

        For count = 1 To Len(firstword)
            nextchar = Mid(firstword, count, 1)
            If InStr(secondword, nextchar) = 0 Then
                flag = False
                Exit For
            End If

            If flag = True Then
                Console.Write("these words are anagram!")
            Else
                Console.Write("these are not anagram")

            End If
            Console.ReadKey()



        Next


    End Sub

End Module
