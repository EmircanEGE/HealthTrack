namespace HealthTrack.Core.Entities
{
    public class Exercise : BaseEntity
    {
        public string Type { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
