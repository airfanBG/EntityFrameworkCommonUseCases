using NorthWIndDatabase;
using NorthWIndDatabase.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CommonUseCases
{
    internal class Program
    {
        private const int limit = 100;
        static void Main(string[] args)
        {
            string[] arr = { "A", "B" };

            Test();
        }
        public static void PlayWithChangeTracker()
        {
            using (var db = new NorthwindDbContext())
            {
                db.ChangeTracker.AutoDetectChangesEnabled = false;
                //Call detect changes if AutoDetectChangesEnabled is set to false
                db.ChangeTracker.DetectChanges();
                db.ChangeTracker.Clear();
                var check = db.ChangeTracker.HasChanges();
                var entries = db.ChangeTracker.Entries().ToList();
                foreach (var item in entries)
                {
                    //do some logic
                }

                db.ChangeTracker.Context.Dispose();
                db.ChangeTracker.Context.Attach(new Product());
                db.ChangeTracker.Tracked += ChangeTracker_Tracked;
            }
        }
        
        private static void ChangeTracker_Tracked(object sender, Microsoft.EntityFrameworkCore.ChangeTracking.EntityTrackedEventArgs e)
        {

            e.Entry.Reload();
        }

        static void Test()
        {


            using (var db = new NorthwindDbContext())
            {
                var res = db.Products.Where(GetAboveQty).ToList();
            }
        }
        public static bool GetAboveQty(Product prod)
        {
            if (prod.UnitsInStock > limit)
            {
                return true;
            }
            return false;
        }
    }
}
