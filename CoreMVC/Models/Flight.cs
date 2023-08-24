using System.ComponentModel.DataAnnotations;

namespace CoreMVC.Models
{
    public class Flight
    {
        [Key]
        public int FId { get; set; }
        public string FName { get; set; }

        public string IATA { get; set; }

        public int SeatCount { get; set; }
    }

}
