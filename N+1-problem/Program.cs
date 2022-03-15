using Microsoft.EntityFrameworkCore;
using NorthWIndDatabase;
using NorthWIndDatabase.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace N_1_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bad code
            //using (NorthwindDbContext northwindDbContext = new NorthwindDbContext())
            //{
            //    var start = Stopwatch.StartNew();

            //    var products = northwindDbContext.Products.ToList();

            //    foreach (var item in products)
            //    {
            //        northwindDbContext.Entry(item).Collection(x => x.OrderDetails).Load();
            //        foreach (var order in item.OrderDetails)
            //        {
            //            // Console.WriteLine("Product " + item.ProductName + "  " + "Order " + order.Quantity);

            //        }

            //    }
            //    Console.WriteLine("Bad code");
            //    Console.WriteLine(start.Elapsed);
            //    start.Stop();
            //    Console.WriteLine("-----------------");
            //}
            ////Good code
            //using (NorthwindDbContext northwindDbContext = new NorthwindDbContext())
            //{
            //    var start = Stopwatch.StartNew();

            //    IQueryable<Product> products = northwindDbContext.Products.Include(x => x.OrderDetails);
            //    Console.WriteLine($"ToQueryString: {products.ToQueryString()}");
            //    foreach (var item in products)
            //    {
            //        //Good code
            //        foreach (var order in item.OrderDetails)
            //        {

            //            //  Console.WriteLine("Product " + item.ProductName + "  " + "Order " + order.Quantity);

            //        }

            //    }
            //    Console.WriteLine("Good code");
            //    Console.WriteLine(start.Elapsed);
            //    Console.WriteLine("-----------------");
            //}
            //using (NorthwindDbContext northwindDbContext = new NorthwindDbContext())
            //{
            //    var start = Stopwatch.StartNew();


            //    var second = northwindDbContext.Products.Include(x => x.OrderDetails).Select(x => new Product()
            //    {
            //        ProductName = x.ProductName,
            //        OrderDetails = x.OrderDetails.Where(z => z.Quantity > 10).ToList(),
            //    }).ToList();
            //    foreach (var item in second)
            //    {
            //        //Good code
            //        foreach (var order in item.OrderDetails)
            //        {

            //            //  Console.WriteLine("Product " + item.ProductName + "  " + "Order " + order.Quantity);

            //        }

            //    }
            //    Console.WriteLine("Good code");
            //    Console.WriteLine(start.Elapsed);
            //    //start.Stop();
            //    Console.WriteLine("-----------------");
            //}
            //using select
            //using (NorthwindDbContext northwindDbContext = new NorthwindDbContext())
            //{
            //    var start = Stopwatch.StartNew();


            //    var second = northwindDbContext.Products.Include(x => x.OrderDetails).Select(x => new Product()
            //    {
            //        ProductName = x.ProductName,
            //        OrderDetails = x.OrderDetails.Select(x => x).ToList(),
            //    }).ToList();
            //    foreach (var item in second)
            //    {
            //        //Good code
            //        foreach (var order in item.OrderDetails)
            //        {

            //            //  Console.WriteLine("Product " + item.ProductName + "  " + "Order " + order.Quantity);

            //        }

            //    }
            //    Console.WriteLine("Good code");
            //    Console.WriteLine(start.Elapsed);
            //    // start.Stop();
            //    Console.WriteLine("-----------------");
            //}
            //using (var db = new NorthwindDbContext())
            //{
            //    Console.WriteLine("Enter a minimum for units in stock: ");
            //    string unitsInStock = Console.ReadLine();
            //    int stock = int.Parse(unitsInStock);

            //    IQueryable<Category> cats = db.Categories
            //      .Include(c => c.Products.Where(p => p.UnitsInStock >= stock));

            //    Console.WriteLine($"ToQueryString: {cats.ToQueryString()}");

            //    foreach (Category c in cats)
            //    {
            //        Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products with a minimum of {stock} units in stock.");

            //        foreach (Product p in c.Products)
            //        {
            //            Console.WriteLine($"  {p.ProductName} has {p.UnitsInStock} units in stock.");
            //        }
            //    }
            //}

        }
    }
}
