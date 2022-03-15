using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NorthWIndDatabase;
using System;
using System.Linq;

namespace SQLraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Standard query and SQL injection

            //standard request
            //using (var db = new NorthwindDbContext())
            //{
            //    int id = 10;

            //    var products = db.Products.FromSqlRaw("SELECT * FROM dbo.Products").ToList();
            //    var prods= db.Products.FromSqlRaw($"SELECT * FROM dbo.Products WHERE ProductId>{id}").ToList();
            //}

            //ADO.NET queries
            //GEt no parameters
            //using (SqlConnection conn=new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True"))
            //{
            //    using (SqlCommand cmd=new SqlCommand("select * from Products",conn))
            //    {
            //        try
            //        {
            //            conn.Open();
            //            SqlDataReader reader = cmd.ExecuteReader();
            //            while (reader.Read())
            //            {
            //                Console.WriteLine(reader[1]);
            //            }
            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //        finally
            //        {

            //            conn.Close();
            //        }

            //    }
            //}
            //GET with parameters
            //string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            //string query = "select * from Products where ProductId = @id";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        try
            //        {
            //            conn.Open();
            //            cmd.Parameters.AddWithValue("@id", 1);
            //            SqlDataReader reader = cmd.ExecuteReader();
            //            while (reader.Read())
            //            {
            //                Console.WriteLine(reader[1]);
            //            }
            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }
            //        finally
            //        {

            //            conn.Close();
            //        }

            //    }
            //}

            //Delete slow
            //NorthwindDbContext context = new NorthwindDbContext();
            //var category = context.Categories.Find(46);
            //context.Categories.Remove(category);
            //////context.SaveChanges();
            //Delete fast
            NorthwindDbContext context = new NorthwindDbContext();
            context.Database.ExecuteSqlRaw(
              "DELETE FROM Categories WHERE CategoryID = {0}", 46);



            //sql injection
            //using (var db=new NorthwindDbContext())
            //{
            //    string parameters = "1=1";
            //    string secondParameters = "ProductName = 'Apple' or 1=1";
            //    var products = db.Products.FromSqlRaw($"SELECT * FROM dbo.Products WHERE {parameters}").ToList();

            //    var productsSecond = db.Products.FromSqlRaw($"SELECT * FROM dbo.Products WHERE {secondParameters}").ToList();
            //}


            //drop table qry
            //using (var db=new NorthwindDbContext())
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            //    string query =
            //    @"CREATE TABLE dbo.Test
            //    (
            //        ID int IDENTITY(1,1) NOT NULL,
            //        CONSTRAINT pk_id PRIMARY KEY (ID)
            //    );";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    try
            //    {
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //        Console.WriteLine("Table Created Successfully");
            //    }
            //    catch (SqlException e)
            //    {
            //        Console.WriteLine("Error Generated. Details: " + e.ToString());
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }
            //    var hQry = "'apple';DROP TABLE dbo.Test";

            //    var qry = $"select * from products where productname={hQry}";
            //    var prod = db.Database.ExecuteSqlRaw(qry);
            //}

        }
    }
}
