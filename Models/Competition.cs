namespace AthleteSystem.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
    }
}
