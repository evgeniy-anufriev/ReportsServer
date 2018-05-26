using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Condition
    {
        public Condition()
        {
            SubCondition = new HashSet<SubCondition>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<SubCondition> SubCondition { get; set; }
    }
}
