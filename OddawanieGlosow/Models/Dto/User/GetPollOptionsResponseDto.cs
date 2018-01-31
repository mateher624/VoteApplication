using System.Collections.Generic;

namespace OddawanieGlosow.Models.Dto.User
{
    public class GetPollOptionsResponseDto
    {
        public List<PollOptionDto> PollOptions { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        //public GetPollOptionsResponseDto()
        //{
        //    Description = "Test Description lorem ipsum.";
        //    Name = "Test name";
        //    PollOptions = new List<PollOptionDto>
        //    {
        //        new PollOptionDto
        //        {
        //            Name = "Korwin",
        //            PollOptionNumber = 1
        //        },
        //        new PollOptionDto
        //        {
        //            Name = "Kaczyński",
        //            PollOptionNumber = 2
        //        },
        //        new PollOptionDto
        //        {
        //            Name = "Zandberg",
        //            PollOptionNumber = 3
        //        },
        //        new PollOptionDto
        //        {
        //            Name = "Tusk",
        //            PollOptionNumber = 4
        //        }
        //    };
        //}
    }
}