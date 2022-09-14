﻿using System;
using System.Collections.Generic;

namespace shared
{
    public partial class State
    {
        public State()
        {
            Office1s = new HashSet<Office1>();
        }

        public int Id { get; set; }
        public string? StateName { get; set; }
        public string? StateDescription { get; set; }
        public string? ContactTitle { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }

        public virtual ICollection<Office1> Office1s { get; set; }
    }
}
