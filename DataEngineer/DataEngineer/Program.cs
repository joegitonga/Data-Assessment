using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Reflection;
using System.Data;

namespace DataEngineer
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream mem = new MemoryStream();

            StreamWriter writer = new StreamWriter(mem);
            StreamReader reader = new StreamReader(mem);

            CsvWriter cw = new CsvWriter(writer);
            CsvReader cr = new CsvReader(reader);

            var loans = new[]
                {
                    new Loan { MSISDN = "27729554427", Network = "'Network 1'", Date = DateTime.Parse("Mar 12, 2016"), Product = "Loan Product 1", Amount = 1000 },
                    new Loan { MSISDN = "27722342551", Network = "'Network 2'", Date = DateTime.Parse("Mar 16, 2016"), Product = "Loan Product 1", Amount = 1122 },
                    new Loan { MSISDN = "27725544272", Network = "'Network 3'", Date = DateTime.Parse("Mar 17, 2016"), Product = "Loan Product 2", Amount = 2084 },
                    new Loan { MSISDN = "27725326345", Network = "'Network 1'", Date = DateTime.Parse("Mar 18, 2016"), Product = "Loan Product 2", Amount = 3098 },
                    new Loan { MSISDN = "27729234533", Network = "'Network 2'", Date = DateTime.Parse("Apr 1, 2016"), Product = "Loan Product 1", Amount = 5671 },
                    new Loan { MSISDN = "27723453455", Network = "'Network 3'", Date = DateTime.Parse("Apr 12, 2016"), Product = "Loan Product 3", Amount = 1928 },
                    new Loan { MSISDN = "27725678534", Network = "'Network 2'", Date = DateTime.Parse("Apr 15, 2016"), Product = "Loan Product 3", Amount = 1747 },
                    new Loan { MSISDN = "27729554427", Network = "'Network 1'", Date = DateTime.Parse("Apr 16, 2016"), Product = "Loan Product 1", Amount = 1801 },
                };
         
                cw.WriteRecords(loans);
                writer.Flush();
                var result = Encoding.UTF8.GetString(mem.ToArray());

                System.IO.File.WriteAllText(AccessLayer.CsvPath(), result);          
        }
    }
}
