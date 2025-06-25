using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventRegistration
    {
        [Required(ErrorMessage = "Name is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Event is required")]
        public string EventName { get; set; }

        public bool Attended { get; set; } = false;

    }
}