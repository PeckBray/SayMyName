'Brayden Peck
'RCET0265
'Spring 2021
'Say My Name
'

Option Strict On
Option Explicit On

Module SayName

    Sub Main()
        Dim name As String

        Console.WriteLine("Please type your name.")
        name = Console.ReadLine()
        Console.WriteLine($"Hello, " & name & "! Have a great day!")
        Console.ReadLine()

    End Sub

End Module
