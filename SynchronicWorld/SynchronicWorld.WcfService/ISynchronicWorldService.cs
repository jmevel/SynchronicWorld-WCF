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
    [ServiceContract]
    public interface ISynchronicWorldService
    {
        #region Person
        [OperationContract]
        List<Person> GetAllPersons();

        [OperationContract]
        Person CreatePerson(Person person);

        [OperationContract]
        Person GetPersonByNickname(string nickname);

        [OperationContract]
        Person UpdatePerson(Person updatedPerson);

        [OperationContract]
        bool DeletePerson(Person person);
        #endregion

        #region Event
        [OperationContract]
        List<Event> GetAllEvents();

        [OperationContract]
        Event CreateEvent(Event eventToCreate);

        [OperationContract]
        Event GetEventByName(string name);

        [OperationContract]
        Event UpdateEvent(Event updatedEvent);

        [OperationContract]
        bool DeleteEvent(Event eventToDelete);
        #endregion

        #region Contribution
        [OperationContract]
        List<Contribution> GetAllContributions();

        [OperationContract]
        Contribution CreateContribution(Contribution contribution);

        [OperationContract]
        Contribution GetContributionByName(string name);

        [OperationContract]
        Event AddContribution(Contribution contribution, Event eventTarget);
        #endregion

        #region Database Manager
        [OperationContract]
        List<Event> GetEventsByDate(DateTime date);

        [OperationContract]
        List<Event> GetEventsBetweenTwoDates(DateTime startDate, DateTime endDate);

        [OperationContract]
        List<Event> GetEventsByStatus(EventStatus status);

        [OperationContract]
        List<Event> GetEventsByType(EventType type);

        [OperationContract]
        bool DeleteClosedEvents();

        [OperationContract]
        bool UpdatePendingEvents();

        [OperationContract]
        bool AddPersonToOpenEvent(Event eventTarget, Person person);

        [OperationContract]
        List<Person> GetAllPersonsFromOpenEvent(Event eventTarget);

        [OperationContract]
        List<Contribution> GetAllContributionsFromEvent(Event eventTarget);

        [OperationContract]
        List<Contribution> GetAllContributionsFromPerson(Person person);

        [OperationContract]
        bool DeleteAllContributionsForAllOpenEventsFromPerson(Person person);
        #endregion
    }
}
