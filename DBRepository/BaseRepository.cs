using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository
{
    public class BaseRepository 
    {
        public string ConnectionString;
        public BaseRepository(string connectionString)
        {
            ConnectionString = connectionString;        
        }
    }
}
