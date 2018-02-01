using OddawanieGlosow.Logic.Queries;

namespace OddawanieGlosow.Logic.Modules
{
    public class VoteModule
    {
        private readonly VoteQueries _voteQueries;

        public VoteModule()
        {
            _voteQueries = new VoteQueries();
        }

        public void Vote(int optionNumber, int pollId)
        {
            var pollOption = _voteQueries.GetPollOptionByNumberAndPollId(optionNumber, pollId);
            _voteQueries.CreateVote(pollOption.Id);
        }
    }
}