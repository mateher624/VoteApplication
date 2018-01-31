namespace OddawanieGlosow.Models.Entities
{
    public class Vote : GlobalEntity
    {
        public PollOption Choice { get; set; }
    }
}