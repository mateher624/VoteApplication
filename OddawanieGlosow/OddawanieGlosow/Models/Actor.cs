using OddawanieGlosow.Models.Entities;

namespace OddawanieGlosow.Models
{
    public interface IActor
    {
        void Vote();
    }

    public abstract class Actor : GlobalEntity, IActor
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public abstract void Vote();

        public void DemandPollChoices()
        {
            
        }
    }
}