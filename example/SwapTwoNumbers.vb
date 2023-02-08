Public Class SwapTwoNumbers
    Public Sub SwapNum(num1 As Integer, num2 As Integer)
        Console.WriteLine($"Num1 = {num1}" + vbCrLf)
        Console.WriteLine($"Num2 = {num2}" + vbCrLf)
        Dim Temp As Integer = num1
        num1 = num2
        num2 = Temp
        Console.WriteLine($"After Swapping Num1 = {num1}")
        Console.WriteLine($"After Swapping Num2 = {num2}")


    End Sub
End Class
