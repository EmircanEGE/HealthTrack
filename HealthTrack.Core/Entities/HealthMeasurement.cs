namespace HealthTrack.Core.Entities
{
    public class HealthMeasurement : BaseEntity
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
