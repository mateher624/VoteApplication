namespace OddawanieGlosow.Models.Dto.User
{
    public class VoteRequestDto
    {
        public string Pesel { get; set; }
        public int PollOptionNumber { get; set; }
        public int PollId { get; set; }
    }
}