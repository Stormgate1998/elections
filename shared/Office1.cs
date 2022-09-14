using System;
using System.Collections.Generic;

namespace shared
{
    public partial class Office1
    {
        public Office1()
        {
            BallotPref1s = new HashSet<BallotPref1>();
            CandidateOffices = new HashSet<CandidateOffice>();
        }

        public int Id { get; set; }
        public string? OfficeName { get; set; }
        public int? CountyId { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? PositionsNum { get; set; }

        public virtual City1? City { get; set; }
        public virtual County? County { get; set; }
        public virtual State? State { get; set; }
        public virtual ICollection<BallotPref1> BallotPref1s { get; set; }
        public virtual ICollection<CandidateOffice> CandidateOffices { get; set; }
    }
}
