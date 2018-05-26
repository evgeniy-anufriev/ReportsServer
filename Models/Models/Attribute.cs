using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
