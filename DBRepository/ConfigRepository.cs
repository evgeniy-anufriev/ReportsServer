using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public class ConfigRepository : BaseRepository
    {
        public ConfigRepository(string connectionString) : base(connectionString)
        {
           
        }

        public async Task<IList> GetItems(string tableName)  
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(ConnectionString);

            using (var context = new ConfigurationContext(optionsBuilder.Options))
            {
                switch (tableName)
                {
                    case "reports":
                        {
                            return await context.Reports.AsQueryable().ToListAsync();
                        }
                    case "tus":
                        {
                            return await context.Tus.AsQueryable().ToListAsync();
                        }
                    case "protections":
                        {
                            return await context.Tus.AsQueryable().ToListAsync();
                        }
                }
            }

            return null;
        }

    }
}
