Module Module1

    Sub Main()
        Dim MName, FatherName, More As String
        Dim RNumber, MembershipValidity As String

        MName = ""
        FatherName = ""
        RNumber = ""
        MembershipValidity = ""
        More = ""

        While More <> "Y"
            Console.WriteLine("Enter Name of the member : ")
            MName = Console.ReadLine

            Console.WriteLine("Enter Father's name : ")
            FatherName = Console.ReadLine

            Console.WriteLine("Enter the Registration number : ")
            RNumber = Console.ReadLine

            Console.WriteLine("Enter years valid for : ")
            MembershipValidity = Console.ReadLine


            FileOpen(1, "D:\PROGRAMS\file practice\test.txt", OpenMode.Output)

            WriteLine(1, MName)
            WriteLine(1, FatherName)
            WriteLine(1, RNumber)
            WriteLine(1, MembershipValidity)

            Console.WriteLine("press Y to exit ...")
            More = Console.ReadLine
            More = UCase(More)

        End While
        FileClose(1)
        Console.ReadKey()

    End Sub

End Module
