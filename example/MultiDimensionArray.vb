Public Class MultiDimensionArray
    Public Sub ExOfMMultiDimensionArray()
        Dim sum As Integer = 0
        Dim rowsum As Integer = 0
        Dim Array1 As Integer(,) = New Integer(2, 3) {{5, 5, 5, 5}, {2, 2, 2, 2}, {6, 6, 6, 6}}
        For row As Integer = 0 To 2
            rowsum = 0
            For col As Integer = 0 To 3
                Console.Write("{0}" + vbTab, Array1(row, col))
                rowsum = rowsum + Array1(row, col)
            Next
            sum = sum + rowsum
            Console.Write(" = {0}", rowsum)
            Console.WriteLine("")
        Next

        Console.WriteLine("The sum of the array is : {0}", sum)
    End Sub
End Class
