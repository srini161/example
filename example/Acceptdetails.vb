Imports System.Security.Cryptography.X509Certificates

Public Class Acceptdetails
    Dim engine As String
    Dim NoOfWheels As Int32
    Public Sub AcceptDetails1()
        Console.WriteLine("Enter the Engine Model")
        engine = Console.ReadLine()
        Console.WriteLine("Enter the no of Wheels")
        NoOfWheels = Convert.ToInt32(Console.ReadLine())
    End Sub
    Public Sub DisplayDetails()
        Console.WriteLine("The Engine model: {0}", engine)
        Console.WriteLine("The number of Wheels are: {0}", NoOfWheels)

    End Sub
End Class
