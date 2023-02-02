Public Class operators
    Dim a As Int32
    Dim b As Int32
    Dim c As Int32

    Public Sub ArthemeticOperations()
        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())

        c = a + b
        Console.WriteLine("After add the result is: {0}", c)

        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())

        c = a - b
        Console.WriteLine("After sub the result is: {0}", c)

        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())

        c = a * b
        Console.WriteLine("After multiply the result is: {0}", c)

        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())

        c = a / b
        Console.WriteLine("After Divide the result is: {0}", c)

        Console.WriteLine("Enter the num1: ")
        a = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the num2: ")
        b = Convert.ToInt32(Console.ReadLine())

        c = a Mod b
        Console.WriteLine("After Mod the result is: {0}", c)

    End Sub
End Class
