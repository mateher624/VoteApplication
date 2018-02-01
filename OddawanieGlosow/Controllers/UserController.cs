using System.Web.Http;
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
        [Route("get-poll-options")]
        public GetPollOptionsResponseDto GetPollOptions(GetPollOptionsRequestDto request)
        {
            return _getPollOptionsAdapter.GetPollOptions(request);
        }

        [HttpPost]
        [Route("vote")]
        public void Vote(VoteRequestDto request)
        {
            _voteAdapter.Vote(request);
        }
    }
}
