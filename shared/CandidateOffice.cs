using System;
using System.Collections.Generic;

namespace shared
{
    public partial class CandidateOffice
    {
        public CandidateOffice()
        {
            BallotPref1s = new HashSet<BallotPref1>();
            Tabulationresults = new HashSet<Tabulationresult>();
        }

        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? OfficeId { get; set; }
        public bool EliminatedTf { get; set; }
        public DateOnly FiledDate { get; set; }
        public int? ElectionId { get; set; }

        public virtual Candidate1? Candidate { get; set; }
        public virtual Election1? Election { get; set; }
        public virtual Office1? Office { get; set; }
        public virtual ICollection<BallotPref1> BallotPref1s { get; set; }
        public virtual ICollection<Tabulationresult> Tabulationresults { get; set; }
    }
}
