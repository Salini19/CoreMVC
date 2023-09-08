using System.ComponentModel.DataAnnotations;

namespace CoreMVC.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Iata { get; set; }

        public int SeatCount { get; set; }
    }

}
