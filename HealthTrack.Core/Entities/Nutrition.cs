namespace HealthTrack.Core.Entities
{
    public class Nutrition : BaseEntity
    {
        public string MealType { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
