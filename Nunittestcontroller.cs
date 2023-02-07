using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Nunit_TestAPI.Models;
using NUnitt_Test_Crud.Data;

namespace Nunit_TestAPI
{
    public class Nunittestcontroller
    {
        public readonly DBContextClass _context;

        public Nunittestcontroller(DBContextClass context)
        {
            _context = context;
        }
           private DbContext repository;
           public static DbContextOptions<DBContextClass> dbContextOptions { get; }
           public static string connectionString = "Data Source=DESKTOP-QEIH22N;Initial Catalog=NunitTest;Integrated Security=True;Trust Server Certificate=true;";

        //    static Nunittestcontroller()
        //    {
        //        dbContextOptions = new DbContextOptionsBuilder<DbContext>()
        //            .UseSqlServer(connectionString)
        //            .Options;
        //    }
        //    public Nunittestcontroller()
        //    {
        //        var context = new DbContext(dbContextOptions);
        //        DummyDataDBInitializer db = new DummyDataDBInitializer();
        //        db.Seed(context);

        //        //repository = new DbContext(context);

        //    }
        //}
    }
}
