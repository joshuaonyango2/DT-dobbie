Imports System

Module Program
    ' Define the Vehicle class
    Class Vehicle
        Public Property Make As String
        Public Property Model As String
        Public Property EngineNumber As String
        Public Property SalePrice As Double

        ' Function to capture vehicle details
        Public Sub SetVehicle(make As String, model As String, engineNumber As String, salePrice As Double)
            Me.Make = make
            Me.Model = model
            Me.EngineNumber = engineNumber
            Me.SalePrice = salePrice
        End Sub

        ' Function to calculate and return profit (15% of Sale Price)
        Public Function GetProfit() As Double
            Return SalePrice * 0.15
        End Function

        ' Function to display vehicle details and profit
        Public Sub DisplayDetails()
            Console.WriteLine(vbCrLf & "Vehicle Details:")
            Console.WriteLine($"Make: {Make}, Model: {Model}, Engine Number: {EngineNumber}, Sale Price: {SalePrice:C}")
            Console.WriteLine($"Profit Earned: {GetProfit():C}")
        End Sub
    End Class

    ' Main function
    Sub Main(args As String())
        Console.WriteLine("Welcome to DT Dobie (K) Ltd Vehicle Sales System!")

        ' Create a Vehicle object
        Dim vehicle As New Vehicle()

        ' Capture vehicle details from user
        Console.Write("Enter Vehicle Make (e.g., Nissan, Mercedes): ")
        Dim make As String = Console.ReadLine()

        Console.Write("Enter Vehicle Model (e.g., Sunny, C-Class): ")
        Dim model As String = Console.ReadLine()

        Console.Write("Enter Engine Number: ")
        Dim engineNumber As String = Console.ReadLine()

        Dim salePrice As Double
        Console.Write("Enter Sale Price: ")
        While Not Double.TryParse(Console.ReadLine(), salePrice)
            Console.Write("Invalid input! Enter a valid sale price: ")
        End While

        ' Set vehicle details
        vehicle.SetVehicle(make, model, engineNumber, salePrice)

        ' Display details and profit
        vehicle.DisplayDetails()

        ' Prevent console from closing immediately
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
