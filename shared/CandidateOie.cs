using System;
using System.Collections.Generic;

namespace shared
{
    public partial class CandidateOie
    {
        public CandidateOie()
        {
            BallotPrefs = new HashSet<BallotPref>();
            Tabulationresult1s = new HashSet<Tabulationresult1>();
        }

        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? OieId { get; set; }
        public bool EliminatedTf { get; set; }
        public DateOnly FiledDate { get; set; }
        public int? PartyId { get; set; }
        public string? CandidateType { get; set; }

        public virtual Candidate? Candidate { get; set; }
        public virtual OfficeInElection? Oie { get; set; }
        public virtual Party? Party { get; set; }
        public virtual ICollection<BallotPref> BallotPrefs { get; set; }
        public virtual ICollection<Tabulationresult1> Tabulationresult1s { get; set; }
    }
}
