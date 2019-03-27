using System;
using System.Collections.Generic;
using System.Text;
using Vote.BAL.Services.Interfaces;
using Vote.DAL.Repositories.Interfaces;

namespace Vote.BAL.Services
{
    public class VoteService : IVoteService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly IVoteRepository _voteRepository;

        public VoteService(ICandidateRepository candidateRepository, IVoteRepository voteRepository)
        {
            _candidateRepository = candidateRepository;
            _voteRepository = voteRepository;
        }

        public bool Vote(Guid candidateid)
        {
            if (candidateid == Guid.Empty)
                return false;

            var candidate = _candidateRepository.Find(candidateid);

            if (candidate == null)
                return false;

            _voteRepository.Create(new Models.Enteties.Vote
            {
                CandidateId = candidateid
            });

            _voteRepository.Complete();

            return true;
        }
    }
}
