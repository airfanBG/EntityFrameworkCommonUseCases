using NorthWIndDatabase;
using NorthWIndDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonMistakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new NorthwindDbContext())
            //{
            //    //Different Entities update
            //    Category category = db.Categories.Single(x => x.CategoryId == 1);
            //    Category newCat = new Category() { CategoryId = 1, CategoryName = "Test" };
            //    try
            //    {
            //        db.Update(newCat);
            //        db.SaveChanges();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"{e.GetType().FullName}: {e.Message}");
            //    }
               
            //}


            //Single, First, SingleOrDefault, FirstOrDefault difference

            using (var db=new NorthwindDbContext())
            {
                try
                {
                    Product single = db.Products.Single(x => x.ProductId == 1);
                    Product singleInvalid = db.Products.Single(x => x.ProductId == 0);

                    Product first=db.Products.First(x=>x.ProductId== 1);
                    Product firstInvalid=db.Products.First(x=>x.ProductId== 0);

                    Product firstOrDefault=db.Products.FirstOrDefault(x=>x.ProductId== 1);
                    Product firstOrDefaultInvalid=db.Products.FirstOrDefault(x=>x.ProductId== 0);

                    Product singleOrDefault = db.Products.SingleOrDefault(x => x.ProductId == 1);
                    Product singleOrDefaultInvalid = db.Products.SingleOrDefault(x => x.ProductId == 0);


                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
