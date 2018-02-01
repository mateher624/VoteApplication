using System.Collections.Generic;
using System.Linq;
using OddawanieGlosow.Models.Dto.User;
using OddawanieGlosow.Models.Entities;

namespace OddawanieGlosow.Logic.Mappers
{
    public class PollOptionDtoMapper
    {
        public List<PollOptionDto> Map(List<PollOption> source)
        {
            return source.Select(MapPollOption).ToList();
        }

        private static PollOptionDto MapPollOption(PollOption source)
        {
            return new PollOptionDto
            {
                Name = source.Name,
                PollOptionNumber = source.OptionNumber
            };
        }
    }
}