using System;
using OddawanieGlosow.Logic.Modules;
using OddawanieGlosow.Logic.Queries;
using OddawanieGlosow.Models.Dto.User;

namespace OddawanieGlosow.Logic.Adapters.User
{
    public class VoteAdapter
    {
        private readonly UsersPresenceQueries _usersPresenceQueries;
        private readonly VoteModule _voteModule;

        public VoteAdapter()
        {
            _voteModule = new VoteModule();
            _usersPresenceQueries = new UsersPresenceQueries();
        }

        public void Vote(VoteRequestDto request)
        {
            var hasAlreadyParticipated = _usersPresenceQueries.HasUserAlreadyParticipated(request.Pesel, request.PollId);

            if (hasAlreadyParticipated)
                throw new InvalidOperationException();

            _voteModule.Vote(request.PollOptionNumber, request.PollId);
        }
    }
}