using System;
using System.Collections.Generic;
using System.Text;
using Vote.BAL.Services.Interfaces;
using Vote.DAL.Repositories.Interfaces;
using Vote.Models.DTO;

namespace Vote.BAL.Services
{
    public class CandidateServices : ICandidateServices
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateServices(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public IEnumerable<CandidateVote> GetCandidateVotes()
        {
            return _candidateRepository.GetCandidateVotes();
        }
    }
}
