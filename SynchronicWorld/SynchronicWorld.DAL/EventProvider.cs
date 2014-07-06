using SynchronicWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SynchronicWorld.DAL
{
    public class EventProvider
    {
        public List<Event> GetAllEvents()
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Events.ToList();
            }
        }

        public Event CreateEvent(Event eventToCreate)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                // if address or name are null or name is already taken
                if(context.Events.Where(e=>e.Name.Equals(eventToCreate.Name)).Count()!=0
                    || eventToCreate.Name.Equals("")
                    || eventToCreate.Address.Equals("")
                    || eventToCreate.Description.Equals(""))
                {
                    return null;
                }
                Event newEvent = context.Events.Add(eventToCreate);
                context.SaveChanges();
                return newEvent;
            }
        }

        public Event UpdateEvent(Event updatedEvent)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                // if address or name are null or name is already taken
                if (context.Events.Where(e => e.Name.Equals(updatedEvent.Name) && !e.Id.Equals(updatedEvent.Id)).Count() != 0
                    || updatedEvent.Name.Equals("")
                    || updatedEvent.Address.Equals("")
                    || updatedEvent.Description.Equals(""))
                {
                    return null;
                }
                Event eventInDb = context.Events.Where(e => e.Id.Equals(updatedEvent.Id)).FirstOrDefault();
                if (eventInDb == null)
                {
                    return null;
                }
                eventInDb.Address = updatedEvent.Address;
                eventInDb.Date = updatedEvent.Date;
                eventInDb.Description = updatedEvent.Description;
                eventInDb.Name = updatedEvent.Name;
                eventInDb.Status = updatedEvent.Status;
                eventInDb.Type = updatedEvent.Type;
                context.SaveChanges();
                return eventInDb;
            }
        }

        public bool DeleteEvent(Event eventToDelete)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                Event EventInDb = context.Events.Include(e => e.Persons).Include(e=>e.Contributions).Where(e => e.Id.Equals(eventToDelete.Id)).FirstOrDefault();
                if (EventInDb == null)
                {
                    return false;
                }
                EventInDb.Persons.Clear();
                EventInDb.Contributions.Clear();
                context.Events.Remove(EventInDb);
                context.SaveChanges();
                return true;
            }
        }

        public Event GetEventByName(string name)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Events.Where(e => e.Name.ToLower().Equals(name.ToLower())).FirstOrDefault();
            }
        }        

        public Event AddContribution(Contribution contribution, Event eventTarget)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                var contributionInDb = context.Contributions.Where(c => c.Name.ToLower().Equals(contribution.Name.ToLower())).FirstOrDefault();
                var eventInDb = context.Events.Include(e => e.Contributions).Where(e => e.Name.ToLower().Equals(eventTarget.Name.ToLower())).FirstOrDefault();
                if (contributionInDb == null || eventInDb == null)
                {
                    return null;
                }
                eventInDb.Contributions.Add(contributionInDb);
                context.SaveChanges();
                return eventInDb;
            }
        }
    }
}
