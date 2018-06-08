using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ConfigurationDB
{
    public class Protection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }

        public int TuId { get; set; }
        public Tu Tu { get; set; }
    }
}
