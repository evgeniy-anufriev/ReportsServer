using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public class AeEventRepository : BaseRepository, IAeEventRepository
    {
        public AeEventRepository(string connectionStringData, string connectionStringConfiguration) : base(connectionStringData, connectionStringConfiguration) { }

        public async Task<List<EventHistory>> GetItems(DateTime dateFrom, DateTime dateTo)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AeEventContext>();
            optionsBuilder.UseSqlServer(ConnectionStringData);

            var result = new List<EventHistory>();
            using (var context = new AeEventContext(optionsBuilder.Options))
            {
                var query = context.EventHistory.AsQueryable();
                query = query.Where(p => p.ActiveTime >= dateFrom && p.ActiveTime <= dateTo);
                result = await query.ToListAsync();
            }

            return result;
        }
    }

    public interface IAeEventRepository
    {
        Task<List<EventHistory>> GetItems(DateTime DateFrom, DateTime DateTo);
    }
}
