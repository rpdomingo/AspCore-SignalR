using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vote.DAL.Context;
using Vote.DAL.Repositories.Base;
using Vote.DAL.Repositories.Interfaces;
using Vote.Models.DTO;
using Vote.Models.Enteties;

namespace Vote.DAL.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(VoteDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<CandidateVote> GetCandidateVotes()
        {
            return _dbContext.Set<CandidateVote>();
        }
    }
}
