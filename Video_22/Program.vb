Imports System

Module Program
    Sub Main(args As String())
        'Video 22 - Replacing Substrings
        'Dim myString As String = Nothing
        'Dim finalString As String = Nothing
        'Console.WriteLine("Please enter a string: ")
        'myString = Console.ReadLine()
        'finalString = myString.Replace("hello", "fart")
        'Console.WriteLine(finalString)
        'Console.ReadLine()

        'Video 23 - Comparing Strings
        'Dim userString As String = Nothing
        'Dim compString As String = "donk bonk"
        'Console.WriteLine("Please enter a string: ")
        'userString = Console.ReadLine()
        'Console.WriteLine(String.Compare(userString, compString))
        'Console.ReadLine()

        'Video 24 - Select Case
        Dim userInt As String = Nothing
        Console.WriteLine("Please enter an integer: ")
        userInt = Console.ReadLine()
        Select Case userInt
            Case 0
                Console.WriteLine("Hello")
            Case 1
                Console.WriteLine("Ayyy")
            Case 2
                Console.WriteLine("OOOK")
        End Select
        Console.ReadLine()
    End Sub
End Module
