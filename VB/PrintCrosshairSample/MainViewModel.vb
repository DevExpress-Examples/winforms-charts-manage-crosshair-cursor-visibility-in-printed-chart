Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace PrintCrosshairSample

    Public Class MainViewModel

        Private repository As SaleItemRepository

        Public ReadOnly Property TotalIncome As IReadOnlyList(Of SaleItemAggregate)
            Get
                Return repository.GetTotalIncome().GroupBy(Function(i) New With {i.Category, i.Company}).[Select](Function(g) New SaleItemAggregate With {g.Key.Category, g.Key.Company, .Value = g.Sum(Function(i) i.Income)}).ToList()
            End Get
        End Property

        Public Sub New()
            repository = New SaleItemRepository()
        End Sub
    End Class

    Public Class SaleItemAggregate

        Public Property Company As String

        Public Property Category As String

        Public Property Value As Double
    End Class
End Namespace
