using System;
using System.Collections.Generic;

namespace shared
{
    public partial class County1
    {
        public County1()
        {
            Offices = new HashSet<Office>();
        }

        public int Id { get; set; }
        public string? CountyName { get; set; }
        public string? CountyDescription { get; set; }
        public string? ContactTitle { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }

        public virtual ICollection<Office> Offices { get; set; }
    }
}
