using System.Collections.Generic;

namespace OddawanieGlosow.Models.Dto.User
{
    public class GetPollOptionsResponseDto
    {
        public List<PollOptionDto> PollOptions { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}