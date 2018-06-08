using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public class AeEventRepository : BaseRepository
    {
        public AeEventRepository(string connectionString) : base(connectionString) { }

        public async Task<List<EventHistory>> GetDates(DateTime dateFrom, DateTime dateTo)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AlphaAELogContext>();
            optionsBuilder.UseSqlServer(ConnectionString);

            var result = new List<EventHistory>();
            using (var context = new AlphaAELogContext(optionsBuilder.Options))
            {

                var query = context.EventHistory.AsQueryable();
                query = query.Where(p => p.ActiveTime >= dateFrom && p.ActiveTime <= dateTo);
                result = await query.ToListAsync();
            }

            return result;
        }
    }


}
