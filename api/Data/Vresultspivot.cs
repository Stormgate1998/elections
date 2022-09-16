using System;
using System.Collections.Generic;

namespace elections.Data
{
    public partial class Vresultspivot
    {
        public int? ElectionId { get; set; }
        public string? OfficeName { get; set; }
        public int? OfficeId { get; set; }
        public string? Locality { get; set; }
        public string? CandidateName { get; set; }
        public int? CandidateId { get; set; }
        public int? Initialroundvotes { get; set; }
        public decimal? Initialroundpct { get; set; }
        public int? Round1votes { get; set; }
        public decimal? Round1pct { get; set; }
        public int? Round2votes { get; set; }
        public decimal? Round2pct { get; set; }
        public int? Round3votes { get; set; }
        public decimal? Round3pct { get; set; }
        public int? Round4votes { get; set; }
        public decimal? Round4pct { get; set; }
        public int? Round5votes { get; set; }
        public decimal? Round5pct { get; set; }
        public int? Round6votes { get; set; }
        public decimal? Round6pct { get; set; }
        public int? Round7votes { get; set; }
        public decimal? Round7pct { get; set; }
        public int? Round8votes { get; set; }
        public decimal? Round8pct { get; set; }
        public int? Round9votes { get; set; }
        public decimal? Round9pct { get; set; }
    }
}
