using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    //public class ContextFactory :IContextFactory
    //   {
    //    string _connectionString;
    //    public ContextFactory(string connectionString)
    //    {
    //        _connectionString = connectionString;
    //    }


    //    public object CreateDbContext(object dbContext)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
    //        optionsBuilder.UseSqlServer(_connectionString);

    //        using (var context = new dp(optionsBuilder.Options))
    //        {   
    //            context.Database.Migrate();
    //            return context;
    //        }

    //    }
    //}

 



    //public TContext Create<TContext>()
    //{
    //    var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
    //    optionsBuilder.UseSqlServer(_connectionString);
    //    using (var context = new DbContext(optionsBuilder.Options))
    //    {   

    //        context.Database.Migrate();
    //        return context;

    //    }
    //}


    public interface IContextFactory
    {
        object CreateDbContext( object dbContext);
    }

 
}
 
