Public Class Data
    Public Class Product
        Public Property ProductName() As String
            Get
                Return m_ProductName
            End Get
            Set(value As String)
                m_ProductName = value
            End Set
        End Property
        Private m_ProductName As String
        Public Property Supplier() As String
            Get
                Return m_Supplier
            End Get
            Set(value As String)
                m_Supplier = value
            End Set
        End Property
        Private m_Supplier As String
        Public Property UnitPrice() As Integer
            Get
                Return m_UnitPrice
            End Get
            Set(value As Integer)
                m_UnitPrice = value
            End Set
        End Property
        Private m_UnitPrice As Integer
        Public Property Quantity() As Integer
            Get
                Return m_Quantity
            End Get
            Set(value As Integer)
                m_Quantity = value
            End Set
        End Property
        Private m_Quantity As Integer
    End Class

    Public Class ProductList
        Inherits ObservableCollection(Of Product)
        Public Sub New()
            MyBase.New()

            Add(New Product() With {
                .ProductName = "Chang",
                .Supplier = "Exotic Liquids",
                .UnitPrice = 19,
                .Quantity = 10
            })
            Add(New Product() With {
                .ProductName = "Gravad lax",
                .Supplier = "Svensk Sjöföda AB",
                .UnitPrice = 8,
                .Quantity = 16
            })
            Add(New Product() With {
                .ProductName = "Ravioli Angelo",
                .Supplier = "Pasta Buttini s.r.l.",
                .UnitPrice = 62,
                .Quantity = 12
            })
            Add(New Product() With {
                .ProductName = "Tarte au sucre",
                .Supplier = "Forêts d'érables",
                .UnitPrice = 42,
                .Quantity = 50
            })
            Add(New Product() With {
                .ProductName = "Steeleye Stout",
                .Supplier = "Bigfoot Breweries",
                .UnitPrice = 78,
                .Quantity = 20
            })
            Add(New Product() With {
                .ProductName = "Pavlova",
                .Supplier = "Pavlova, Ltd.",
                .UnitPrice = 21,
                .Quantity = 52
            })
            Add(New Product() With {
                .ProductName = "Longlife Tofu",
                .Supplier = "Mayumi's",
                .UnitPrice = 4,
                .Quantity = 120
            })
            Add(New Product() With {
                .ProductName = "Alice Mutton",
                .Supplier = "Pavlova, Ltd.",
                .UnitPrice = 34,
                .Quantity = 15
            })
            Add(New Product() With {
                .ProductName = "Aniseed Syrup",
                .Supplier = "Exotic Liquids",
                .UnitPrice = 6,
                .Quantity = 49
            })
            Add(New Product() With {
                .ProductName = "Tunnbröd",
                .Supplier = "PB Knäckebröd AB",
                .UnitPrice = 91,
                .Quantity = 38
            })
            Add(New Product() With {
                .ProductName = "Ipoh Coffee",
                .Supplier = "Leka Trading",
                .UnitPrice = 29,
                .Quantity = 3
            })
            Add(New Product() With {
                .ProductName = "Filo Mix",
                .Supplier = "G'day, Mate",
                .UnitPrice = 117,
                .Quantity = 14
            })
        End Sub
    End Class
End Class
