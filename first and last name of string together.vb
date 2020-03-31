Module Module1

    Sub Main()
        Dim s1, s2, firstword, secword As String
        Dim sp As Integer

        s1 = " "
        s2 = " "
        firstword = " "
        secword = " "
        sp = 0

        Console.Write("enter first string: ")
        s1 = Console.ReadLine

        Console.Write("enter sec string: ")
        s2 = Console.ReadLine

        sp = InStr(s1, " ")
        firstword = Left(s1, sp - 1)


        sp = InStr(s2, " ")
        secword = Right(s2, Len(s2) - sp)

        Console.WriteLine("final string = " & firstword & " " & secword)
        Console.ReadKey()





    End Sub

End Module
