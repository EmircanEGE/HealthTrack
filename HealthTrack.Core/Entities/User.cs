namespace HealthTrack.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Nutrition> NutritionRecords { get; set; }
        public List<HealthMeasurement> Measurements { get; set; }
    {
    }
}
