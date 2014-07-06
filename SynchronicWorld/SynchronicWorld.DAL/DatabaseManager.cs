using SynchronicWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Objects;

namespace SynchronicWorld.DAL
{
    public class DatabaseManager
    {
        public List<Event> GetEventsByDate(DateTime date)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Events.Where(e => e.Date.Year.Equals(date.Year) && e.Date.Month.Equals(date.Month) && e.Date.Day.Equals(date.Day)).ToList();
            }
        }

        public List<Event> GetEventsBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Events.Where(e => e.Date >= startDate && e.Date <= endDate).ToList();
            }
        }

        public List<Event> GetEventsByStatus(EventStatus status)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Events.Where(e => e.Status.ToString().Equals(status.ToString())).ToList();
            }
        }

        public List<Event> GetEventsByType(EventType type)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Events.Where(e => e.Type.ToString().Equals(type.ToString())).ToList();
            }
        }

        public bool DeleteClosedEvents()
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                var closedEvents = context.Events.Where(e => e.Status.ToString().Equals(EventStatus.Closed.ToString())).ToList();
                if (closedEvents == null)
                {
                    return false;
                }
                foreach (var closedEvent in closedEvents)
                {
                    context.Events.Remove(closedEvent);
                }
                context.SaveChanges();
                return true;
            }
        }

        public bool UpdatePendingEvents()
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                var pendingEvents = context.Events.Where(e => e.Status.ToString().Equals(EventStatus.Pending.ToString())).ToList();
                if (pendingEvents == null)
                {
                    return false;
                }
                foreach (var pendingEvent in pendingEvents)
                {
                    pendingEvent.Status = EventStatus.Open;
                }
                context.SaveChanges();
                return true;
            }
        }

        public bool AddPersonToOpenEvent(Event eventTarget, Person person)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                Person PersonInDb = context.Persons.Where(p => p.Nickname.ToLower().Equals(person.Nickname.ToLower())).FirstOrDefault();
                if (PersonInDb == null)
                {
                    return false;
                }
                if (context.Events.Include(e=>e.Persons).Where(e => e.Name.ToLower().Equals(eventTarget.Name.ToLower())).FirstOrDefault().Persons.Contains(PersonInDb)
                    || !context.Events.Where(e=>e.Name.ToLower().Equals(eventTarget.Name.ToLower())).FirstOrDefault().Status.ToString().Equals(EventStatus.Open.ToString()))
                {
                    return false;
                }
                context.Events.Where(e => e.Name.Equals(eventTarget.Name)).FirstOrDefault().Persons.Add(PersonInDb);
                context.SaveChanges();
                return true;
            }
        }

        public List<Person> GetAllPersonsFromOpenEvent(Event eventTarget)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                if (!context.Events.Where(e => e.Name.ToLower().Equals(eventTarget.Name.ToLower())).FirstOrDefault().Status.ToString().Equals(EventStatus.Open.ToString()))
                {
                    return null;
                }
                return context.Events.Include(e => e.Persons).Where(e => e.Name.Equals(eventTarget.Name)).FirstOrDefault().Persons;
            }
        }

        public List<Contribution> GetAllContributionsFromEvent(Event eventTarget)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Events.Include(e => e.Contributions.Select(c=>c.Person)).Where(e => e.Name.Equals(eventTarget.Name)).FirstOrDefault().Contributions.ToList();
            }
        }

        public List<Contribution> GetAllContributionsFromPerson(Person person)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                if (context.Persons.Where(c => c.Nickname.ToLower().Equals(person.Nickname.ToLower().FirstOrDefault())) == null)
                {
                    return null;
                }
                return context.Contributions.Include(c => c.Person).Where(c => c.Person.Nickname.ToLower().ToString().Equals(person.Nickname.ToLower().ToString())).ToList();
            }
        }

        public bool DeleteAllContributionsForAllOpenEventsFromPerson(Person person)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                var PersonInDb = context.Persons.Where(p=>p.Nickname.Equals(person.Nickname)).FirstOrDefault();
                if(PersonInDb==null)
                {
                    return false;
                }
                List<Event> openEvents = context.Events.Include(e=>e.Contributions.Select(c=>c.Person)).Where(e=>e.Status.ToString().Equals(EventStatus.Open.ToString())).ToList();
                var contr = context.Contributions.Include(c => c.Person).Where(c => c.Person.Nickname.Equals(PersonInDb.Nickname));
                foreach (var openEvent in openEvents)
                {
                    foreach (var cont in contr)
                    {
                        if (openEvent.Contributions.Contains(cont))
                        {
                            context.Contributions.Remove(cont);
                        }
                    }
                }
                context.SaveChanges();
                return true;
            }
        }
    }
}
