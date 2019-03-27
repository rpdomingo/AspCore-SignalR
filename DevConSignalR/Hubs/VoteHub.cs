using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.BAL.Services.Interfaces;

namespace DevConSignalR.Hubs
{
    public class VoteHub : Hub
    {
        private readonly IVoteService _voteService;

        public VoteHub(IVoteService voteService)
        {
            _voteService = voteService;
        }

        public async Task Vote(Guid candidateid, string messsage)
        {
            var result = _voteService.Vote(candidateid);

            if (result)
            {
                await Clients.All.SendAsync("NewVote", candidateid);
                await NotifyVoters(messsage);
            }
        }

        public async Task NotifyVoters(string message = null)
        {
            await Clients.Others.SendAsync(message);
        }
    }
}
