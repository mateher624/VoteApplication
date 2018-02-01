using OddawanieGlosow.Logic.Mappers;
using OddawanieGlosow.Logic.Queries;
using OddawanieGlosow.Models.Dto.User;

namespace OddawanieGlosow.Logic.Adapters.User
{
    public class GetPollOptionsAdapter
    {
        private readonly VoteQueries _voteQueries;
        private readonly PollOptionDtoMapper _optionDtoMapper;

        public GetPollOptionsAdapter()
        {
            _optionDtoMapper = new PollOptionDtoMapper();
            _voteQueries = new VoteQueries();
        }

        public GetPollOptionsResponseDto GetPollOptions(int pollId)
        {
            var polloptions = _voteQueries.GetPollOptions(pollId);

            var poll = _voteQueries.GetPollById(pollId);
            
            return new GetPollOptionsResponseDto
            {
                Description = poll.Description,
                Name = poll.Name,
                PollOptions = _optionDtoMapper.Map(polloptions)
            };
        }
    }
}