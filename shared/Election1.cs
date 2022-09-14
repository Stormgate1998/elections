using System;
using System.Collections.Generic;

namespace shared
{
    public partial class Election1
    {
        public Election1()
        {
            CandidateOffices = new HashSet<CandidateOffice>();
        }

        public int Id { get; set; }
        public DateOnly? Earlyvotingbegin { get; set; }
        public DateOnly? Earlyvotingend { get; set; }
        public DateOnly? PollDate { get; set; }
        public bool Ballotingclosed { get; set; }

        public virtual ICollection<CandidateOffice> CandidateOffices { get; set; }
    }
}
