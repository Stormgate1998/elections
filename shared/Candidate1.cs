using System;
using System.Collections.Generic;

namespace shared
{
    public partial class Candidate1
    {
        public Candidate1()
        {
            CandidateOffices = new HashSet<CandidateOffice>();
        }

        public int Id { get; set; }
        public string CandidateName { get; set; } = null!;
        public string? CandidateEmail { get; set; }
        public string? CandidatePhone { get; set; }
        public byte[]? CandidatePhoto { get; set; }

        public virtual ICollection<CandidateOffice> CandidateOffices { get; set; }
    }
}
