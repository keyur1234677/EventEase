using EventEase.Models;

namespace EventEase.Services
{
    public class UserSessionTracker
    {
        public List<EventRegistration> AllRegistrations { get; set; } = new();
        public EventRegistration? CurrentRegistration { get; set; }

        public void AddRegistration(EventRegistration registration)
        {
            AllRegistrations.Add(registration);
            CurrentRegistration = registration;
        }


        public void MarkAttendance(string email, string eventName)
        {
            var entry = AllRegistrations.FirstOrDefault(r =>
                r.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                && r.EventName.Equals(eventName, StringComparison.OrdinalIgnoreCase));

            if (entry is not null)
            {
                entry.Attended = true;
            }
        }
    }
}