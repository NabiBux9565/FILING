Module Module1

    Sub Main()
        Dim MName, FatherName, More As String
        Dim RNumber, MembershipValidity, MNum, Adress As String

        MName = ""
        FatherName = ""
        RNumber = ""
        MembershipValidity = ""
        More = ""
        MNum = ""
        Adress = ""

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
            Console.WriteLine("More information.....")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("Enter mobile number")
            MNum = Console.ReadLine
            Console.WriteLine("Enter the adress : ")
            Adress = Console.ReadLine

        End While
        FileClose(1)
        FileOpen(2, "D:\PROGRAMS\file practice\test2.txt", OpenMode.Output)
        WriteLine(2, MName)
        WriteLine(2, FatherName)
        WriteLine(2, RNumber)
        WriteLine(2, MembershipValidity)
        WriteLine(2, MNum)
        WriteLine(2, Adress)

        Console.ReadKey()
    End Sub

End Module
