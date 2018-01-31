namespace OddawanieGlosow.Models.Entities
{
    public class PollOption : GlobalEntity
    {
        public string Name { get; set; }
        public Poll Poll { get; set; }
        public int OptionNumber { get; set; }
    }
}