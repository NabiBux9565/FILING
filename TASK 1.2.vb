Module Module1

    Sub Main()
        Dim MName, FatherName, More As String
        Dim RNumber, MembershipValidity As String

        MName = ""
        FatherName = ""
        RNumber = ""
        MembershipValidity = ""
        More = ""

        FileOpen(1, "D:\PROGRAMS\file practice\test.txt", OpenMode.Input)
        While Not EOF(1)

            Input(1, MName)
            Input(1, FatherName)
            Input(1, RNumber)
            Input(1, MembershipValidity)

            Console.WriteLine("Member's Name : " & MName)
            Console.WriteLine("Father's Name : " & FatherName)
            Console.WriteLine("Registration number : " & RNumber)
            Console.WriteLine("Validity : " & MembershipValidity)

        End While
        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
