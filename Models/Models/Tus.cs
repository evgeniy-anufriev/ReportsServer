using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class Tus
    {
        public int TusId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual List<Prots> Prots { get; set; }

    }
}
