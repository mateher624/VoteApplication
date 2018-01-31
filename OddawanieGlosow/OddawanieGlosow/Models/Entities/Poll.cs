using System;

namespace OddawanieGlosow.Models.Entities
{
    public class Poll : GlobalEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public PollRange Range { get; set; }
    }

    public enum PollRange
    {
        Local,
        Global
    }
}