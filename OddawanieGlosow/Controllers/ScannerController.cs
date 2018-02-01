using System.Web.Http;
using OddawanieGlosow.Logic.Adapters.Scanner;
using OddawanieGlosow.Models.Dto.Scanner;

namespace OddawanieGlosow.Controllers
{
    [RoutePrefix("api/scanner")]
    public class ScannerController : ApiController
    {
        private readonly CreateVoteFromScanAdapter _createVoteFromScanAdapter;

        public ScannerController()
        {
            _createVoteFromScanAdapter = new CreateVoteFromScanAdapter();
        }

        [HttpPost]
        [Route("scan-and-vote")]
        public void CreateVoteFromScan(CreateVoteFromScanRequestDto request)
        {
            _createVoteFromScanAdapter.CreateVoteFromScan(request);
        }
    }
}
