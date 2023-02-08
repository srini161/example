Imports System.Formats.Asn1.AsnWriter

Public Class Game
    Dim Enter As String
    Dim abc As Double
    Public Score As Integer = 0
    Public Array1() As String = {"armets", "maters", "matres", "ramets", "stream", "tamers", "armet", "aster", "mares", "marse", "marts", "maser", "mater", "mates", "meats", "ramet", "rates", "reams", "resat", "satem", "smart", "smear", "stare", "steam", "tamer", "tames", "tares", "teams", "tears", "terms", "trams",
 "ares", "arms", "arts", "ates", "ears", "east", "eats", "eras", "erst", "etas", "maes", "mare", "mars", "mart", "mast", "mate", "mats", "meat", "mesa", "meta", "rams", "rase", "rate", "rats", "ream", "rems", "rest", "rets", "same", "sate",
 "seam", "sear", "seat", "sera", "seta", "star", "stem", "tame", "tams", "tare", "tars", "team", "tear", "teas", "term", "tram", "tres", "tsar", "are", "arm", "ars", "art", "ate",
 "ear", "eat", "ems", "era", "ers", "eta", "mae", "mar", "mas", "mat", "met", "ram", "ras", "rat", "rem", "res", "ret", "sae", "sat", "sea", "ser", "set", "tae", "tam", "tar", "tas", "tea", "ae", "am", "ar", "as", "at", "em", "er",
 "es", "et", "ma", "me", "re", "ta"}
    Public Sub WordGame()
        Console.WriteLine("GAME" + vbCrLf)
        Console.WriteLine("MASTER" + vbCrLf)
        Console.WriteLine("Basic instructions of game:")
        Console.WriteLine("1. You should create a new word only within these letter MASTER or else it will not considered as a word." + vbCrLf + "2. Only once a word should repeat " + vbCrLf + "3.Your Score will Be increased by 1, if it is correct" + vbCrLf)
        Console.WriteLine("Use Multiple words using MASTER: " + vbCrLf)

        Dim list As New List(Of Char)
        While abc <= 3

            Enter = Console.ReadLine()



            Dim A As Integer = Enter.Length
            Console.WriteLine(A)


            Dim c As Int32
            c = 0

            Dim k As Char
            Dim z As Integer = 0

            For Each k In Enter

                If Array1.Contains(Enter) Then
                    c += 1

                Else
                    c -= 1
                End If
            Next

            If c = A Then

                Console.WriteLine("Correct")
                list.Add(Enter)


                Score += 1


            Else
                Console.WriteLine("Incorrect")


            End If
            abc = Score
        End While
        Console.WriteLine("Your Score is: {0}", Score)

    End Sub


End Class
