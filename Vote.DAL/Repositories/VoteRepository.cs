using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vote.DAL.Context;
using Vote.DAL.Repositories.Base;
using Vote.DAL.Repositories.Interfaces;

namespace Vote.DAL.Repositories
{
    public class VoteRepository : GenericRepository<Models.Enteties.Vote>, IVoteRepository
    {
        public VoteRepository(VoteDbContext dbContext) : base(dbContext)
        {
        }
    }
}
