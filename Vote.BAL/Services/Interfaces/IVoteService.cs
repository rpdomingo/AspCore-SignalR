using System;
using System.Collections.Generic;
using System.Text;

namespace Vote.BAL.Services.Interfaces
{
    public interface IVoteService
    {
        bool Vote(Guid candidateid);
    }
}
