using System;
using System.Collections.Generic;

namespace shared
{
    public partial class City1
    {
        public City1()
        {
            Office1s = new HashSet<Office1>();
        }

        public int Id { get; set; }
        public string? CityName { get; set; }
        public string? CityDescription { get; set; }
        public string? ContactTitle { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }

        public virtual ICollection<Office1> Office1s { get; set; }
    }
}
