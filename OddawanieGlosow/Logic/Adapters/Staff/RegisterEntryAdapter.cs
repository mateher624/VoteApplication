using System;
using OddawanieGlosow.Logic.Queries;
using OddawanieGlosow.Models.Dto.Staff;

namespace OddawanieGlosow.Logic.Adapters.Staff
{
    public class RegisterEntryAdapter
    {
        private readonly UsersPresenceQueries _usersPresenceQueries;

        public RegisterEntryAdapter()
        {
            _usersPresenceQueries = new UsersPresenceQueries();
        }

        public void RegisterEntry(RegisterEntryRequestDto request)
        {
            var hasAlreadyParticipated = _usersPresenceQueries.HasUserAlreadyParticipated(request.Pesel, request.PollId);

            //todo mozna tutaj rzucac customowy exception i jego chyba jakos latwo sie potem ogarnia na froncie
            if (hasAlreadyParticipated)
                throw new InvalidOperationException();

            _usersPresenceQueries.RegisterPresence(request.Pesel, request.PollId);
        }
    }
}