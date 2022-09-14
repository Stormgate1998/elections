using System;
using System.Collections.Generic;

namespace shared
{
    public partial class Ballot1
    {
        public Ballot1()
        {
            BallotPrefs = new HashSet<BallotPref>();
        }

        public int Id { get; set; }
        public int? VoterId { get; set; }
        public string? Precinctinfo { get; set; }
        public DateTime? CastTimestamp { get; set; }

        public virtual ICollection<BallotPref> BallotPrefs { get; set; }
    }
}
