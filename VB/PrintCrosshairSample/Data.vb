Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace PrintCrosshairSample

    Public Class SaleItemRepository

        Private ReadOnly Shared companies As System.Collections.Generic.List(Of System.[String]) = New System.Collections.Generic.List(Of System.[String]) From {"DevAV North", "DevAV South", "DevAV West", "DevAV East", "DevAV Central"}

        Private ReadOnly Shared categorizedProducts As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String)) = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String)) From {{"Cameras", New System.Collections.Generic.List(Of String)() From {"Camera", "Camcorder", "Binoculars", "Flash", "Tripod"}}, {"Cell Phones", New System.Collections.Generic.List(Of String)() From {"Smartphone", "Mobile Phone", "Smart Watch", "Sim Card"}}, {"Computers", New System.Collections.Generic.List(Of String)() From {"Desktop", "Laptop", "Tablet", "Printer"}}, {"TV, Audio", New System.Collections.Generic.List(Of String)() From {"Television", "Home Audio", "Headphone", "DVD Player"}}, {"Vehicle Electronics", New System.Collections.Generic.List(Of String)() From {"GPS Unit", "Radar", "Car Alarm", "Car Accessories"}}}

        Public Function GetProductsByMonths() As List(Of PrintCrosshairSample.SaleItem)
            Dim rnd As System.Random = New System.Random()
            Dim items As System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem) = New System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem)()
            For Each company As String In PrintCrosshairSample.SaleItemRepository.companies
                For Each product As String In PrintCrosshairSample.SaleItemRepository.categorizedProducts("Cameras")
                    Dim dateTime As System.DateTime = New System.DateTime(2017, 12, 01)
                    For i As Integer = 0 To 12 - 1
                        Dim income As Integer = rnd.[Next](20, 100)
                        Dim revenue As Integer = income + rnd.[Next](20, 50)
                        items.Add(New PrintCrosshairSample.SaleItem() With {.Company = company, .Product = product, .Month = dateTime.AddMonths(CInt((1))).ToString("MMMM", System.Globalization.CultureInfo.InvariantCulture), .Income = income, .Revenue = revenue})
                        dateTime = dateTime.AddMonths(1)
                    Next
                Next
            Next

            Return items
        End Function

        Public Function GetProductsByCompany(ByVal companyIndex As Integer) As List(Of PrintCrosshairSample.SaleItem)
            Dim rnd As System.Random = New System.Random(System.DateTime.Now.Millisecond)
            Dim items As System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem) = New System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem)()
            For Each category As String In PrintCrosshairSample.SaleItemRepository.categorizedProducts.Keys
                For Each product As String In PrintCrosshairSample.SaleItemRepository.categorizedProducts(category)
                    Dim income As Integer = rnd.[Next](20, 100)
                    Dim revenue As Integer = income + rnd.[Next](20, 50)
                    items.Add(New PrintCrosshairSample.SaleItem() With {.Company = PrintCrosshairSample.SaleItemRepository.companies(companyIndex), .Product = product, .Income = income, .Revenue = revenue, .Category = category})
                Next
            Next

            Return items
        End Function

        Public Function GetProductsIncome() As List(Of PrintCrosshairSample.SaleItem)
            Dim rnd As System.Random = New System.Random(System.DateTime.Now.Millisecond)
            Dim items As System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem) = New System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem)()
            For i As Integer = 0 To 50 - 1
                For Each product As String In PrintCrosshairSample.SaleItemRepository.categorizedProducts("Cameras")
                    items.Add(New PrintCrosshairSample.SaleItem() With {.Product = product, .Income = rnd.[Next](20, 100)})
                Next
            Next

            Return items
        End Function

        Public Function GetTotalIncome() As List(Of PrintCrosshairSample.SaleItem)
            Dim rnd As System.Random = New System.Random(System.DateTime.Now.Millisecond)
            Dim now As System.DateTime = System.DateTime.Now
            Dim endDate As System.DateTime = New System.DateTime(now.Year, now.Month, 1)
            Dim items As System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem) = New System.Collections.Generic.List(Of PrintCrosshairSample.SaleItem)()
            For Each company As String In PrintCrosshairSample.SaleItemRepository.companies
                Dim companyFactor As Double = rnd.NextDouble() * 0.6 + 1
                For Each category As String In PrintCrosshairSample.SaleItemRepository.categorizedProducts.Keys
                    Dim categoryFactor As Double = rnd.NextDouble() * 0.6 + 1
                    For Each product As String In PrintCrosshairSample.SaleItemRepository.categorizedProducts(category)
                        Dim maxIncome As Integer = rnd.[Next](60, 140)
                        For i As Integer = 0 To 1000 - 1
                            If i Mod 100 = 0 Then maxIncome = System.Math.Max(40, rnd.[Next](maxIncome - 20, maxIncome + 20))
                            Dim [date] As System.DateTime = endDate.AddDays(-i - 1)
                            Dim income As Double = rnd.[Next](20, maxIncome) * companyFactor * categoryFactor
                            items.Add(New PrintCrosshairSample.SaleItem() With {.Category = category, .Company = company, .Product = product, .OrderDate = [date], .Income = income})
                        Next
                    Next
                Next
            Next

            Return items
        End Function
    End Class

    Public Class SaleItem

        Public Property Product As String

        Public Property Company As String

        Public Property OrderDate As DateTime

        Public Property Month As String

        Public Property Income As Double

        Public Property Revenue As Double

        Public Property Category As String
    End Class
End Namespace
