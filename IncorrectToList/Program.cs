using Microsoft.EntityFrameworkCore;
using NorthWIndDatabase;
using NorthWIndDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IncorrectToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindDbContext())
            {

                List<Category> cats = db.Categories.ToList().Select(x=>new Category() { CategoryName=x.CategoryName,CategoryId=x.CategoryId}).ToList().Where(x=>x.CategoryId==1).ToList();

               
                foreach (Category c in cats)
                {
                    Console.WriteLine($"{c.CategoryName} with Id {c.CategoryId} ");
                }
            }
        }
    }
}
