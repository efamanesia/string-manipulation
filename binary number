Module Module1

    Sub Main()
        Dim str1, nextchar As String
        Dim index, counter As Integer
        Dim flag As Boolean


        str1 = " "
        nextchar = " "
        index = 0
        flag = True
        counter = 0

        Console.Write("enter binary number: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar > 1 Or nextchar < 8 Then
                flag = True
            Else
                flag = False

            End If


            For index = 1 To Len(str1)
                nextchar = Mid(str1, count, 1)
                If nextchar = 0 Or nextchar = 1 Then
                    flag = True
                Else
                    flag = False
                End If



 
                    If flag = False Then
                    Console.WriteLine("not a valid binary number")
                Else
                    Console.WriteLine("valid binary number")

                    Console.ReadKey()


                    End If



            Next



        Next

    End Sub

End Module
