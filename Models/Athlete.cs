using System.ComponentModel.DataAnnotations;

namespace AthleteSystem.Models
{
    public class Athlete
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string SportCategory { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
