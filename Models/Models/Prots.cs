using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class Prots
    {
        public int ProtsId { get; set; }
        public string Name {get;set;}
        public string Code { get; set; }

        public int TuId { get; set; }
        public virtual Tus Tu { get; set; }
    }
}
