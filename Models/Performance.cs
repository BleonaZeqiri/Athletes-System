namespace AthleteSystem.Models
{
    public class Performance
    {
        public int Id { get; set; }
        public int AthleteId { get; set; }
        public DateTime Date { get; set; }
        public double Score { get; set; }
        public string Notes { get; set; }

        public Athlete Athlete { get; set; }
    }
}
