using System;
using Microsoft.EntityFrameworkCore;

namespace CSVtoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolFactory sf = new SchoolFactory("Dataset.csv");
            var mySchools = sf.AllSchools;
            int length = mySchools.Length;
            var x = new SchoolDbContextFactory();

            using (var db = x.CreateDbContext(args))
            {
                for (int i = 0; i < length; i++)
                {
                    db.Schools.Add(mySchools[i]);
                    var count = db.SaveChanges();
                }
                foreach (var item in db.Schools)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }

        }
    }
}
