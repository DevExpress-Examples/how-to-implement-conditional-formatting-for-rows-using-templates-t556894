using System.Collections.ObjectModel;
public class Product {
    public string ProductName { get; set; }
    public string Supplier { get; set; }
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }
}

public class ProductList : ObservableCollection<Product> {
    public ProductList()
        : base() {
        Add(new Product() {
            ProductName = "Chang",
            Supplier = "Exotic Liquids",
            UnitPrice = 19,
            Quantity = 10

        });
        Add(new Product() {
            ProductName = "Gravad lax",
            Supplier = "Svensk Sjöföda AB",
            UnitPrice = 8,
            Quantity = 16
        });
        Add(new Product() {
            ProductName = "Ravioli Angelo",
            Supplier = "Pasta Buttini s.r.l.",
            UnitPrice = 62,
            Quantity = 12
        });
        Add(new Product() {
            ProductName = "Tarte au sucre",
            Supplier = "Forêts d'érables",
            UnitPrice = 42,
            Quantity = 50
        });
        Add(new Product() {
            ProductName = "Steeleye Stout",
            Supplier = "Bigfoot Breweries",
            UnitPrice = 78,
            Quantity = 20
        });
        Add(new Product() {
            ProductName = "Pavlova",
            Supplier = "Pavlova, Ltd.",
            UnitPrice = 21,
            Quantity = 52
        });
        Add(new Product() {
            ProductName = "Longlife Tofu",
            Supplier = "Mayumi's",
            UnitPrice = 4,
            Quantity = 120
        });
        Add(new Product() {
            ProductName = "Alice Mutton",
            Supplier = "Pavlova, Ltd.",
            UnitPrice = 34,
            Quantity = 15
        });
        Add(new Product() {
            ProductName = "Aniseed Syrup",
            Supplier = "Exotic Liquids",
            UnitPrice = 6,
            Quantity = 49
        });
        Add(new Product() {
            ProductName = "Tunnbröd",
            Supplier = "PB Knäckebröd AB",
            UnitPrice = 91,
            Quantity = 38
        });
        Add(new Product() {
            ProductName = "Ipoh Coffee",
            Supplier = "Leka Trading",
            UnitPrice = 29,
            Quantity = 3
        });
        Add(new Product() {
            ProductName = "Filo Mix",
            Supplier = "G'day, Mate",
            UnitPrice = 117,
            Quantity = 14
        });
    }
}
