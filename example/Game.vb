﻿Imports System.Formats.Asn1.AsnWriter

Public Class Game
    Dim Enter As String
    Dim abc As Double
    Public Sub WordGame()
        Console.WriteLine("GAME" + vbCrLf)
        Console.WriteLine("MASTER" + vbCrLf)
        Console.WriteLine("Basic instructions of game:")
        Console.WriteLine("1. You should create a new word only within these letter MASTER or else it will not considered as a word." + vbCrLf + "2. Only once a word should repeat " + vbCrLf + "3.Your Score will Be increased by 1, if it is correct" + vbCrLf)
        Console.WriteLine("Use Multiple words using MASTER: " + vbCrLf)
        Dim Score As Integer = 0
        While abc <= 3
            Enter = Console.ReadLine()


            Dim A As Integer = Enter.Length
            Console.WriteLine(A)


            Dim c As Int32
            c = 0

            Dim k As Char
            Dim z As Integer = 0

            For Each k In Enter

                If k = "m" Or k = "a" Or k = "s" Or k = "t" Or k = "e" Or k = "r" Then
                    c += 1
                Else
                    c -= 1
                End If
            Next

            If c = A Then

                Console.WriteLine("You have entered a correct word using Master")
                Score += 1

            Else
                Console.WriteLine("Please Enter a Word With Char in Master")
            End If
            abc = Score
        End While

        Console.WriteLine("Score is :{0}", Score)

    End Sub
End Class
