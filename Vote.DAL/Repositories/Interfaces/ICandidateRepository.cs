using System;
using System.Collections.Generic;
using System.Text;
using Vote.DAL.Repositories.Base.Interfaces;
using Vote.Models.DTO;
using Vote.Models.Enteties;

namespace Vote.DAL.Repositories.Interfaces
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        IEnumerable<CandidateVote> GetCandidateVotes();
    }
}
