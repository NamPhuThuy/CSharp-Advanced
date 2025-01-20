using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sample data to demonstrate LINQ queries
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200, Category = "Electronics" },
            new Product { Id = 2, Name = "Mouse", Price = 25, Category = "Electronics" },
            new Product { Id = 3, Name = "Desk", Price = 300, Category = "Furniture" },
            new Product { Id = 4, Name = "Chair", Price = 150, Category = "Furniture" },
            new Product { Id = 5, Name = "Phone", Price = 800, Category = "Electronics" }
        };

        var orders = new List<Order>
        {
            new Order { Id = 1, ProductId = 1, Quantity = 2 },
            new Order { Id = 2, ProductId = 2, Quantity = 3 },
            new Order { Id = 3, ProductId = 1, Quantity = 1 }
        };

        // 1. from - Specifies the data source and range variable
        // Basic query syntax
        IEnumerable<Product> basicQuery = from p in products select p;
        foreach (Product product in basicQuery)
        {
            //print the product information in a single line
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
        }
        
        // 2. where - Filters elements based on a condition
        var expensiveProducts = from p in products
                               where p.Price > 500
                               select p;

        // 3. select - Projects each element into a new form
        var productNames = from p in products
                          select p.Name;

        // 4. orderby - Sorts elements (ascending by default)
        var orderedProducts = from p in products
                             orderby p.Price
                             select p;

        // 5. descending - Sorts elements in descending order
        var descendingProducts = from p in products
                                orderby p.Price descending
                                select p;

        // 6. group by - Groups elements by a specified key
        var groupedProducts = from p in products
                             group p by p.Category;

        // 7. join - Combines two data sources based on a key
        var joinQuery = from p in products
                       join o in orders
                       on p.Id equals o.ProductId
                       select new { p.Name, o.Quantity };

        // 8. into - Continues a query after a group or join operation
        var groupedInto = from p in products
                         group p by p.Category into categoryGroup
                         select new { 
                             Category = categoryGroup.Key, 
                             Count = categoryGroup.Count() 
                         };

        // 9. let - Introduces a new variable within a query
        var letExample = from p in products
                        let tax = p.Price * 0.1
                        select new { p.Name, p.Price, Tax = tax, Total = p.Price + tax };

        // 10. Multiple from clauses (cross join)
        var crossJoin = from p1 in products
                       from p2 in products
                       where p1.Id != p2.Id && p1.Category == p2.Category
                       select new { Product1 = p1.Name, Product2 = p2.Name };

        // Method Syntax Examples

        // 11. Select() - Method syntax equivalent of select
        var methodSelect = products.Select(p => p.Name);

        // 12. Where() - Method syntax equivalent of where
        var methodWhere = products.Where(p => p.Price > 500);

        // 13. OrderBy() and ThenBy() - Method syntax for sorting
        var methodOrderBy = products
            .OrderBy(p => p.Category)
            .ThenBy(p => p.Price);

        // 14. GroupBy() - Method syntax for grouping
        var methodGroupBy = products.GroupBy(p => p.Category);

        // 15. Join() - Method syntax for joins
        var methodJoin = products.Join(
            orders,
            p => p.Id,
            o => o.ProductId,
            (p, o) => new { p.Name, o.Quantity }
        );

        // 16. Aggregate Functions
        var count = products.Count();
        var sum = products.Sum(p => p.Price);
        var average = products.Average(p => p.Price);
        var min = products.Min(p => p.Price);
        var max = products.Max(p => p.Price);

        // 17. Element Operators
        var first = products.First();  // Throws exception if no elements
        var firstOrDefault = products.FirstOrDefault();  // Returns default if no elements
        var single = products.Single(p => p.Id == 1);  // Throws if not exactly one element
        var singleOrDefault = products.SingleOrDefault(p => p.Id == 1);

        // 18. Set Operations
        var distinct = products.Select(p => p.Category).Distinct();
        var union = products.Union(products);
        var intersect = products.Intersect(products);
        var except = products.Except(products);

        // 19. Quantifiers
        var any = products.Any(p => p.Price > 1000);  // Returns true if any match
        var all = products.All(p => p.Price > 0);     // Returns true if all match
    }
}

// Sample classes for the examples
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}