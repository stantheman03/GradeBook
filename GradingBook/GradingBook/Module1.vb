Module Module1

    Class student
        Public firstname As String
        Public lastname As String
        Public grade As Integer
        Public passsOrfail As String
    End Class

    Dim students(50) As student
    Dim studentcount As Integer = 0

    Sub Main()
        For i = 0 To 50
            students(i) = New student
        Next

        Dim selection As Char

        While selection <> "c"

            Console.WriteLine("welcome to the student gradebook")
        Console.WriteLine("number of students" & studentcount)
        Console.WriteLine("a. add student")
        Console.WriteLine("b. view student")
        Console.WriteLine("c. quit program")

            selection = Console.ReadLine


            If selection = "a" Then
                Console.WriteLine("enter firstname ")
                students(studentcount).firstname = Console.ReadLine
                Console.WriteLine("enter lastname ")
                students(studentcount).lastname = Console.ReadLine
                Console.WriteLine("enter grade ")
                students(studentcount).grade = Console.ReadLine
                Console.WriteLine("enter pass or fail ")
                students(studentcount).passsOrfail = Console.ReadLine

                studentcount += 1

                Console.WriteLine("students entered !! ")
                Console.ReadLine()

            ElseIf selection = "b" Then

                For i = 0 To studentcount - 1
                    Console.WriteLine("student firstname: " & students(i).firstname)
                    Console.WriteLine("student lastname: " & students(i).lastname)
                    Console.WriteLine("student grade: " & students(i).grade)
                    Console.WriteLine("student passorfail: " & students(i).passsOrfail)
                    Console.ReadLine()

                Next

            ElseIf selection = "c" Then



            End If
        End While


    End Sub

End Module
