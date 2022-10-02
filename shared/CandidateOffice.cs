using System;
using System.Collections.Generic;

namespace shared
{
    public partial class CandidateOffice
    {
        public CandidateOffice()
        {
            BallotPrefs = new HashSet<BallotPref>();
            Tabulationresults = new HashSet<Tabulationresult>();
        }

        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? OfficeId { get; set; }
        public bool EliminatedTf { get; set; }
        public DateOnly FiledDate { get; set; }
        public int? ElectionId { get; set; }

        public virtual Candidate? Candidate { get; set; }
        public virtual Election? Election { get; set; }
        public virtual Office? Office { get; set; }
        public virtual ICollection<BallotPref> BallotPrefs { get; set; }
        public virtual ICollection<Tabulationresult> Tabulationresults { get; set; }
    }
}
