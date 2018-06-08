using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ConfigurationDB
{
    public class Tu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }

        public List<Protection> Protections { get; set; }
    }
}
