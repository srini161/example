Public Class Array
    Dim EmployeeNamee(5) As String
    Public Sub EmpName()
        Dim localEmployeeName(5)
        Console.WriteLine("Enter the Employee's Name:")
        EmployeeNamee(0) = Console.ReadLine()
        Console.WriteLine("Enter the Employee's Name:")
        EmployeeNamee(1) = Console.ReadLine()
        Console.WriteLine("Enter the Employee's Name:")
        EmployeeNamee(2) = Console.ReadLine()
        Console.WriteLine("Enter the Employee's Name:")
        EmployeeNamee(3) = Console.ReadLine()
        Console.WriteLine("Enter the Employee's Name:")
        EmployeeNamee(4) = Console.ReadLine()
    End Sub

    Public Sub DisplayEmpName()
        Console.WriteLine("Employee's Name are: " + vbCrLf + EmployeeNamee(0))
        Console.WriteLine(EmployeeNamee(1))
        Console.WriteLine(EmployeeNamee(2))
        Console.WriteLine(EmployeeNamee(3))
        Console.WriteLine(EmployeeNamee(4))
    End Sub
End Class
