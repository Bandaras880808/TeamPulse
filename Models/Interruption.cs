namespace TeamPulse.Models
{
    public class Interruption
    {
        public long Id { get; set; }

        public int TeamId { get; set; }

        public int CategoryId { get; set; }

        public string Severity { get; set; }

        public int MinutesLost { get; set; }

        public DateTime LoggedAt { get; set; }

        public Team Team { get; set; }

        public Category Category { get; set; }
    }
}
