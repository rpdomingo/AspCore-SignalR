using System;
using System.Collections.Generic;
using System.Text;
using Vote.Models.DTO;

namespace Vote.BAL.Services.Interfaces
{
    public interface ICandidateServices
    {
        IEnumerable<CandidateVote> GetCandidateVotes();
    }
}
