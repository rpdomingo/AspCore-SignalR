using System;
using System.Collections.Generic;
using System.Text;

namespace Vote.Models.DTO
{
    public class CandidateVote
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Anime { get; set; }
        public string ProfilePhoto { get; set; }
        public int Votes { get; set; }
    }
}
