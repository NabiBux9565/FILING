Module Module1

    Sub Main()
        Dim MName, FatherName, More As String
        Dim RNumber, MembershipValidity, SearchedName As String
        Dim IsFound As Boolean

        MName = ""
        FatherName = ""
        RNumber = ""
        MembershipValidity = ""
        More = ""
        SearchedName = ""
        IsFound = False

        Console.WriteLine("Enter the name to be searched in the file :")
        SearchedName = Console.ReadLine
        SearchedName = UCase(SearchedName)


        FileOpen(1, "D:\PROGRAMS\file practice\test.txt", OpenMode.Input)
        While Not EOF(1) And IsFound = False

            Input(1, MName)
            Input(1, FatherName)
            Input(1, RNumber)
            Input(1, MembershipValidity)

            If SearchedName = UCase(MName) Then
                IsFound = True
                Console.WriteLine("Registration ID for the following Name is : " & RNumber)
            End If
          
        End While
        FileClose(1)
        If IsFound = False Then
            Console.WriteLine("Name not found...")
        End If
        Console.ReadKey()

    End Sub

End Module
