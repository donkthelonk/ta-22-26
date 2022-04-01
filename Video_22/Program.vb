Imports System

Module Program
    Sub Main(args As String())
        'Video 22 - Replacing Substrings
        Dim myString As String = Nothing
        Dim finalString As String = Nothing
        Console.WriteLine("Please enter a string: ")
        myString = Console.ReadLine()
        finalString = myString.Replace("hello", "fart")
        Console.WriteLine(finalString)
        Console.ReadLine()
    End Sub
End Module
