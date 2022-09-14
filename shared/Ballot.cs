using System;
using System.Collections.Generic;

namespace shared
{
    public partial class Ballot
    {
        public Ballot()
        {
            BallotPref1s = new HashSet<BallotPref1>();
        }

        public int Id { get; set; }
        public int? VoterId { get; set; }
        public string? Precinctinfo { get; set; }
        public DateTime? CastTimestamp { get; set; }

        public virtual ICollection<BallotPref1> BallotPref1s { get; set; }
    }
}
