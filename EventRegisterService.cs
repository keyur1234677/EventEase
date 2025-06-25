using EventEase.Models;
using System.Collections.Generic;

namespace EventEase.Services
{
    public class EventRegisterService
    {
        private List<Event> eventList;

        public void AddEvent(Event evt)
        {
            if (eventList == null)
            {
                eventList = new List<Event>();
            }
            eventList.Add(evt);
        }

        public IEnumerable<Event> GetEvents() => eventList;
    }
}