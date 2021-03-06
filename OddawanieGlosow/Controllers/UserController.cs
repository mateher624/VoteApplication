﻿using System.Web.Http;
using OddawanieGlosow.Logic.Adapters.User;
using OddawanieGlosow.Models.Dto.User;

namespace OddawanieGlosow.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly GetPollOptionsAdapter _getPollOptionsAdapter;
        private readonly VoteAdapter _voteAdapter;

        public UserController()
        {
            _getPollOptionsAdapter = new GetPollOptionsAdapter();
            _voteAdapter = new VoteAdapter();
        }


        [HttpGet]
        //[Route("get-poll-options")]
        public GetPollOptionsResponseDto GetPollOptions(int pollId)
        {
            return _getPollOptionsAdapter.GetPollOptions(pollId);
        }

        [HttpPost]
        [Route("vote")]
        public VoteResponseDto Vote(VoteRequestDto request)
        {
            return _voteAdapter.Vote(request);
        }
    }
}
