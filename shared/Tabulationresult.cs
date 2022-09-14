using System;
using System.Collections.Generic;

namespace shared
{
    public partial class Tabulationresult
    {
        public int Id { get; set; }
        public int? COId { get; set; }
        public string? VotingRound { get; set; }
        public int? Votesreceived { get; set; }
        public decimal? Pctvotesforoffice { get; set; }

        public virtual CandidateOffice? CO { get; set; }
    }
}
