using System.Web.Http;
using OddawanieGlosow.Models.Dto.User;

namespace OddawanieGlosow.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public GetPollOptionsResponseDto GetPollOptions(GetPollOptionsRequestDto request)
        {
            return new GetPollOptionsResponseDto();
        }

        [HttpPost]
        public void Vote(VoteRequestDto request)
        {
            
        }
    }
}
