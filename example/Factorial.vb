Public Class Factorial
    Public Sub CalculateFactorial()
        Dim num1
        Console.WriteLine("Factorial")
        Console.WriteLine("Enter the number to calculate Factorial: ")
        num1 = Convert.ToInt32(Console.ReadLine())

        Dim Fact As Integer = 1
        For i = 1 To num1
            Fact = Fact * i
        Next

        Console.WriteLine("Factorial of given number is: {0}", Fact)


    End Sub
End Class
