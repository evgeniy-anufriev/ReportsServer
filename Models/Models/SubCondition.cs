using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SubCondition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ConditionId { get; set; }

        public Condition Condition { get; set; }
    }
}
