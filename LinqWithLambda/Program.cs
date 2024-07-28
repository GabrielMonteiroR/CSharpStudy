using System.Runtime.Serialization;
using LinqWithLambda.Entities;


static void print<T>(string message, IEnumerable<T> collection)
{
    System.Console.WriteLine(message);
    foreach (T obj in collection)
    {
        System.Console.WriteLine(obj);
    }
    System.Console.WriteLine();
}


Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

List<Product> products = new List<Product>() {
    new Product() { Id = 1, Category = c2, Price = 1100.0, Name = "Computer" },
    new Product() { Id = 2, Category = c1, Price = 150.0, Name = "Hammer" },
    new Product() { Id = 3, Category = c1, Price = 200.0, Name = "Saw" },
    new Product() { Id = 4, Category = c1, Price = 300.0, Name = "Drill" },
    new Product() { Id = 5, Category = c2, Price = 1300.0, Name = "Laptop" },
    new Product() { Id = 6, Category = c3, Price = 500.0, Name = "Smartphone" },
    new Product() { Id = 7, Category = c3, Price = 600.0, Name = "Tablet" },
    new Product() { Id = 8, Category = c3, Price = 250.0, Name = "Monitor" },
    new Product() { Id = 9, Category = c2, Price = 900.0, Name = "Printer" },
    new Product() { Id = 10, Category = c3, Price = 700.0, Name = "Headphones" }

};

var firstResult = products.Where(product => product.Category.Tier == 1 && product.Price < 900.0);
print("TIER 1 AND PRICE < 900: ", firstResult);

var firstResultTwo = 
    from product in products
    where product.Category.Tier == 1 && product.Price < 900.0
    select product;


print("NAMES OF PRODUCTS FROM TOOLS", products.Where(product => product.Category.Tier == 2).Select(product => product.Name));

print("PRODUCTS THAT START WITH C", products.Where(product => product.Name[0] == 'C').Select(product => new { product.Price, product.Name, CategoryName = product.Category.Name }));
//THEN BY PARA EMPATES ELE CONSIDERAR PELO NOME
print("PRODUCTS IN ORDER", products.Where(product => product.Category.Tier == 1).OrderBy(product => product.Price).ThenBy(product => product.Name));

print("SKIP 2 TAKE 4", products.Skip(2).Take(4));

System.Console.WriteLine("FIRST PRODUCT " + products.FirstOrDefault());

//JUST ONE RESULT
System.Console.WriteLine("SINGLE OF DEFAULT " + products.Where(p => p.Id == 3).SingleOrDefault());

System.Console.WriteLine(products.Max(product => product.Price));
System.Console.WriteLine(products.Min(product => product.Price));

//SUM
System.Console.WriteLine(products.Where(product => product.Category.Tier == 1).Sum(product => product.Price));

System.Console.WriteLine(products.Where(product => product.Category.Tier == 1).DefaultIfEmpty().Average(product => product.Price));

//AGREGATE (OUTRAS LINGAUGENS CHAMAM DE REDUCE))

System.Console.WriteLine(products.Where(product => product.Category.Tier == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y));

//GROUP BY

foreach (IGrouping<Category, Product> group in products.GroupBy(p => p.Category))
{
    System.Console.WriteLine("CATEGORY" + group.Key.Name + ": ");
    foreach (Product product in group)
    {
        System.Console.WriteLine(product);
    }
    System.Console.WriteLine();
}