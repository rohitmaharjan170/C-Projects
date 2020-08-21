using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             SqliteDataAccess das = new SqliteDataAccess();
            //  das.

            // DataAccess da = new DataAccess();  // abstrct calass  acnnot be instantcious





            List<DataAccess> databases = new List<DataAccess>()
            {
                 // DataAccess databases = new SqlDataAccess();
                 // DataAccess databases = new SqliteDataAccess();

                // tei bhayera list DataAccess declaration 

                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
                /*db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");*/
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
