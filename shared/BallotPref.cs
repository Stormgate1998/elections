﻿using System;
using System.Collections.Generic;

namespace shared
{
    public partial class BallotPref
    {
        public int Id { get; set; }
        public int? BallotId { get; set; }
        public int? PreferenceNum { get; set; }
        public int? CandidateOieId { get; set; }

        public virtual Ballot1? Ballot { get; set; }
        public virtual CandidateOie? CandidateOie { get; set; }
    }
}
