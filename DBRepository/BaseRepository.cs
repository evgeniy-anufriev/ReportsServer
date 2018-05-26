using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository
{
    public abstract class BaseRepository
    {
        protected string ConnectionStringData { get; }
        protected string ConnectionStringConfiguration { get; }
        public BaseRepository(string connectionStringData,string connectionStringConfiguration)
        {
            ConnectionStringData = connectionStringData;
            ConnectionStringConfiguration = connectionStringConfiguration;
        }

    }
}
