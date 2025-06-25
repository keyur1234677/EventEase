using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        [Required(ErrorMessage = "Event name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
    }
}