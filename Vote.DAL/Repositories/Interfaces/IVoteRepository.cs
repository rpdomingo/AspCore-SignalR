using System;
using System.Collections.Generic;
using System.Text;
using Vote.DAL.Repositories.Base.Interfaces;

namespace Vote.DAL.Repositories.Interfaces
{
    public interface IVoteRepository: IGenericRepository<Vote.Models.Enteties.Vote>
    {
    }
}
