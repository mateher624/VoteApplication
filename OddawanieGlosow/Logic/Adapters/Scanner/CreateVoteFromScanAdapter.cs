using OddawanieGlosow.Logic.Modules;
using OddawanieGlosow.Models.Dto.Scanner;

namespace OddawanieGlosow.Logic.Adapters.Scanner
{
    public class CreateVoteFromScanAdapter
    {
        private readonly VoteModule _voteModule;

        public CreateVoteFromScanAdapter()
        {
            _voteModule = new VoteModule();
        }

        public void CreateVoteFromScan(CreateVoteFromScanRequestDto request)
        {
            _voteModule.Vote(request.PollOptionNumber, request.PollId);
        }
    }
}