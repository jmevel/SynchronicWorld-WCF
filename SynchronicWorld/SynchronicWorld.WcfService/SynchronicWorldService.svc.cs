using SynchronicWorld.DAL;
using SynchronicWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SynchronicWorld.WcfService
{
    public class SynchronicWorldService : ISynchronicWorldService
    {
       private PersonProvider _personProvider;
       private EventProvider _eventProvider;
       private ContributionProvider _contributionProvider;
       private DatabaseManager _databaseManager;

       public SynchronicWorldService()
       {
            _personProvider = new PersonProvider();
            _eventProvider = new EventProvider();
            _contributionProvider = new ContributionProvider();
            _databaseManager = new DatabaseManager();
       }

        #region Person
       public List<Person> GetAllPersons()
       {
           return _personProvider.GetAllPersons();
       }

        public Person CreatePerson(Person person)
        {
            return _personProvider.CreatePerson(person);
        }

        public Person GetPersonByNickname(string nickname)
        {
            return _personProvider.GetPersonByNickname(nickname);
        }

        public Person UpdatePerson(Person updatedPerson)
        {
            return _personProvider.UpdatePerson(updatedPerson);
        }

        public bool DeletePerson(Person person)
        {
            return _personProvider.DeletePerson(person);
        }
        #endregion

        #region Event
        public List<Event> GetAllEvents()
        {
            return _eventProvider.GetAllEvents();
        }

        public Event CreateEvent(Event eventToCreate)
        {
            return _eventProvider.CreateEvent(eventToCreate);
        }

        public Event GetEventByName(string name)
        {
            return _eventProvider.GetEventByName(name);
        }

        public Event UpdateEvent(Event updatedEvent)
        {
            return _eventProvider.UpdateEvent(updatedEvent);
        }

        public bool DeleteEvent(Event eventToDelete)
        {
            return _eventProvider.DeleteEvent(eventToDelete);
        }
        #endregion

        #region Contribution
        public List<Contribution> GetAllContributions()
        {
            return _contributionProvider.GetAllContributions();
        }

        public Contribution CreateContribution(Contribution contribution)
        {
            return _contributionProvider.CreateContribution(contribution);
        }

        public Contribution GetContributionByName(string name)
        {
            return _contributionProvider.GetContributionByName(name);
        }

        public Event AddContribution(Contribution contribution, Event eventTarget)
        {
            return _eventProvider.AddContribution(contribution, eventTarget);
        }
        #endregion

        #region Database Management
        public List<Event> GetEventsByDate(DateTime date)
        {
            return _databaseManager.GetEventsByDate(date);
        }

        public List<Event> GetEventsBetweenTwoDates(DateTime startDate, DateTime endDate)
        {
            return _databaseManager.GetEventsBetweenTwoDates(startDate, endDate);
        }

        public List<Event> GetEventsByStatus(EventStatus status)
        {
            return _databaseManager.GetEventsByStatus(status);
        }

        public List<Event> GetEventsByType(EventType type)
        {
            return _databaseManager.GetEventsByType(type);
        }

        public bool DeleteClosedEvents()
        {
            return _databaseManager.DeleteClosedEvents();
        }

        public bool UpdatePendingEvents()
        {
            return _databaseManager.UpdatePendingEvents();
        }

        public bool AddPersonToOpenEvent(Event eventTarget, Person person)
        {
            return _databaseManager.AddPersonToOpenEvent(eventTarget, person);
        }

        public List<Person> GetAllPersonsFromOpenEvent(Event eventTarget)
        {
            return _databaseManager.GetAllPersonsFromOpenEvent(eventTarget);
        }

        public List<Contribution> GetAllContributionsFromEvent(Event eventTarget)
        {
            return _databaseManager.GetAllContributionsFromEvent(eventTarget);
        }

        public List<Contribution> GetAllContributionsFromPerson(Person person)
        {
            return _databaseManager.GetAllContributionsFromPerson(person);
        }

        public bool DeleteAllContributionsForAllOpenEventsFromPerson(Person person)
        {
            return _databaseManager.DeleteAllContributionsForAllOpenEventsFromPerson(person);
        }
        #endregion
    }
}
