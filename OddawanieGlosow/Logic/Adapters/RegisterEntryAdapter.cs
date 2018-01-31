using System;
using OddawanieGlosow.Logic.Queries;
using OddawanieGlosow.Models.Dto.Staff;

namespace OddawanieGlosow.Logic.Adapters
{
    public class RegisterEntryAdapter
    {
        private readonly StaffQueries _staffQueries;

        public RegisterEntryAdapter()
        {
            _staffQueries = new StaffQueries();
        }

        public void RegisterEntry(RegisterEntryRequestDto request)
        {
            var hasAlreadyParticipated = _staffQueries.HasUserAlreadyParticipated(request.Pesel, request.PollId);

            if (hasAlreadyParticipated)
                throw new InvalidOperationException();

            _staffQueries.RegisterPresence(request.Pesel, request.PollId);
        }
    }
}