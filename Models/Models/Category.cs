using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Category
    {
        public Category()
        {
            Attribute = new HashSet<Attribute>();
            Condition = new HashSet<Condition>();
        }

        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string DataSourceAlias { get; set; }

        public ICollection<Attribute> Attribute { get; set; }
        public ICollection<Condition> Condition { get; set; }
    }
}
