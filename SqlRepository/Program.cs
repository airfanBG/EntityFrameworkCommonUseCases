using NorthWIndDatabase;
using SqlRepository.Implementations;
using System;

namespace SqlRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (UnitOfWork uow=new UnitOfWork(new NorthwindDbContext()))
            {
               var all= uow.Products.GetAll();
            }
        }
    }
}
