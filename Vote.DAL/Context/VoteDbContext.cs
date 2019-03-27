using Microsoft.EntityFrameworkCore;
using Vote.Models.DTO;
using Vote.Models.Enteties;

namespace Vote.DAL.Context
{
    public class VoteDbContext : DbContext
    {
        public VoteDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Vote.Models.Enteties.Vote> Votes { get; set; }
        public virtual DbSet<CandidateVote> CandidateVotes { get; set; }
        public virtual DbSet<CandidateVote> sp_Test { get; set; }
    }
}
