Public Class Employee
    Dim Id As Int32
    Dim Name As String
    Dim Age As Int32
    Dim DOB As Date
    Dim BasicHRA As Int32

    Public Sub EmployeeDetails()
        Console.WriteLine("Enter the id: ")
        Id = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter the Name: ")
        Name = Console.ReadLine()

        Console.WriteLine("Enter the Age: ")
        Age = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter the DOB: ")
        DOB = Console.ReadLine()

        Console.WriteLine("Enter the Basic HRA: ")
        BasicHRA = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Employee's id is : {0} ", Id)
        Console.WriteLine("Employee's Name is : {0} ", Name)
        Console.WriteLine("Employee's Age is : {0} ", Age)
        Console.WriteLine("Employee's DOB is : {0} ", DOB)
        Console.WriteLine("Employee's Basic HRA is : {0} ", BasicHRA)
    End Sub
End Class
