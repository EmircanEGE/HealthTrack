namespace HealthTrack.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public virtual List<Exercise> Exercises { get; set; }
        public virtual List<Nutrition> NutritionRecords { get; set; }
        public virtual List<HealthMeasurement> Measurements { get; set; }
    }
}
