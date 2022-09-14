using System;
using System.Collections.Generic;

namespace shared
{
    public partial class Veffectiveballot1
    {
        public int? ElectionId { get; set; }
        public int? OfficeId { get; set; }
        public int? COId { get; set; }
        public long? Numvotes { get; set; }
        public decimal? Pcteffectiveballots { get; set; }
        public long? OfficeTotalVotes { get; set; }
    }
}
