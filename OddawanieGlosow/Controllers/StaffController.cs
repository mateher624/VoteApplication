using System.Web.Http;
using OddawanieGlosow.Logic.Adapters;
using OddawanieGlosow.Models.Dto.Staff;

namespace OddawanieGlosow.Controllers
{
    public class StaffController : ApiController
    {
        private readonly RegisterEntryAdapter _registerEntryAdapter;

        public StaffController()
        {
            _registerEntryAdapter = new RegisterEntryAdapter();
        }

        [HttpPost]
        [Route("register-entry")]
        public void RegisterEntry(RegisterEntryRequestDto request)
        {
            _registerEntryAdapter.RegisterEntry(request);
        }
    }
}
