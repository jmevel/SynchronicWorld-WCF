using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using SynchronicWorld.SynchronicWorldServiceReference;
using System.Globalization;

namespace SynchronicWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                BasicHttpBinding binding = new BasicHttpBinding();
                EndpointAddress address = new EndpointAddress(new Uri("http://localhost:8173/SynchronicWorldService.svc"));
                ChannelFactory<ISynchronicWorldService> factory = new ChannelFactory<ISynchronicWorldService>(binding, address);
                var channel = factory.CreateChannel();

                string[] lines = System.IO.File.ReadAllLines(@"../../Resources/menu.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t\t" + line);
                }
                var keyInfo = new ConsoleKeyInfo();
                while (!keyInfo.Key.ToString().Equals("Escape"))
                {
                    Console.WriteLine("\n\t1: CRUD Person");
                    Console.WriteLine("\t2: CRUD Event");
                    Console.WriteLine("\t3: CR Contribution");
                    Console.WriteLine("\t4: Manage events");
                    Console.WriteLine("\t5: Manage contributions");
                    Console.WriteLine("\tEchap: Exit\n");
                    keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key.ToString())
                    {
                        #region CRUD Person
                        case "NumPad1":
                            var keyInfoPerson = new ConsoleKeyInfo();
                            while (!keyInfoPerson.Key.ToString().Equals("Escape"))
                            {
                                Console.WriteLine("\n\t1: Get all persons");
                                Console.WriteLine("\t2: Create person");
                                Console.WriteLine("\t3: Update person");
                                Console.WriteLine("\t4: Delete person");
                                Console.WriteLine("\tEchap: Go back\n");
                                keyInfoPerson = Console.ReadKey(true);
                                switch (keyInfoPerson.Key.ToString())
                                {
                                    // GET ALL PERSONS
                                    case "NumPad1":
                                        List<Person> persons = new List<Person>(channel.GetAllPersons());
                                        if (persons.Count == 0)
                                        {
                                            Console.WriteLine("\nNo persons created yet");
                                        }
                                        else
                                        {
                                            foreach (var person in persons)
                                            {
                                                Console.WriteLine(person.Firstname + " " + person.Lastname + " " + person.Nickname);
                                            }
                                        }
                                        break;

                                    // CREATE PERSON
                                    case "NumPad2":
                                        Person newPerson = new Person();
                                        Console.Write("Firstname: ");
                                        newPerson.Firstname = Console.ReadLine();
                                        Console.Write("Lastname: ");
                                        newPerson.Lastname = Console.ReadLine();
                                        Console.Write("Nickname: ");
                                        newPerson.Nickname = Console.ReadLine();
                                        var createdPerson = channel.CreatePerson(newPerson);
                                        if (createdPerson == null)
                                        {
                                            Console.WriteLine("\nYou have to give a value for all fields, or maybe this person already exists in Database");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nNew person created: ");
                                            Console.WriteLine("Firstname: " + createdPerson.Firstname + "\tLastname: " + createdPerson.Lastname + "\tNickname: " + createdPerson.Nickname);
                                        }
                                        break;

                                    // UPDATE PERSON
                                    case "NumPad3":
                                        Console.Write("Nickname of the person you want to update: ");
                                        string nickname = Console.ReadLine();
                                        Person personToUpdate = channel.GetPersonByNickname(nickname);
                                        if (personToUpdate == null)
                                        {
                                            Console.WriteLine("\nThis person does not exist");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nPerson to update: ");
                                            Console.WriteLine("Firstname: " + personToUpdate.Firstname + "\tLastname: " + personToUpdate.Lastname + "\tNickname: " + personToUpdate.Nickname);
                                            Console.WriteLine("\nPlease provide new data (EMPTY VALUE WILL KEEP EXISTING VALUE)");
                                            Console.Write("Firstname: ");
                                            string firstname = Console.ReadLine();
                                            personToUpdate.Firstname = firstname.Equals("") ? personToUpdate.Firstname : firstname;
                                            Console.Write("Lastname: ");
                                            string lastname = Console.ReadLine();
                                            personToUpdate.Lastname = lastname.Equals("") ? personToUpdate.Lastname : lastname;
                                            Console.Write("Nickname: ");
                                            nickname = Console.ReadLine();
                                            personToUpdate.Nickname = nickname.Equals("") ? personToUpdate.Nickname : nickname;
                                            Person updatedPerson = channel.UpdatePerson(personToUpdate);
                                            if (updatedPerson == null)
                                            {
                                                Console.WriteLine("\nThis person already exists in Database");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nUpdated person: ");
                                                Console.WriteLine("Firstname: " + updatedPerson.Firstname + ", Lastname: " + updatedPerson.Lastname + ", Nickname: " + updatedPerson.Nickname);
                                            }
                                        }
                                        break;

                                    // DELETE PERSON
                                    case "NumPad4":
                                        Console.Write("\nNickname of the person you want to delete: ");
                                        nickname = Console.ReadLine();
                                        Person personToDelete = channel.GetPersonByNickname(nickname);
                                        if (personToDelete == null)
                                        {
                                            Console.WriteLine("\nThis person does not exist");
                                        }
                                        else
                                        {
                                            bool isDeleted = channel.DeletePerson(personToDelete);
                                            if (isDeleted == false)
                                            {
                                                Console.WriteLine("\nCan't delete this person, maybe already deleted");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPerson deleted");
                                            }
                                        }
                                        break;
                                    case "Escape":
                                        break;
                                    default:
                                        Console.WriteLine("\nEnter a valid value");
                                        break;
                                }
                            }
                            break;
                            #endregion

                        #region CRUD Event
                        case "NumPad2":                           
                            var keyInfoEvent = new ConsoleKeyInfo();
                            while (!keyInfoEvent.Key.ToString().Equals("Escape"))
                            {
                                Console.WriteLine("\n\t1: Get all events");
                                Console.WriteLine("\t2: Create event");
                                Console.WriteLine("\t3: Update event");
                                Console.WriteLine("\t4: Delete event");
                                Console.WriteLine("\tEchap: Go back\n");
                                keyInfoEvent = Console.ReadKey(true);
                                switch (keyInfoEvent.Key.ToString())
                                {
                                    // GET ALL EVENTS
                                    case "NumPad1":
                                        List<Event> events = new List<Event>(channel.GetAllEvents());
                                        if (events.Count == 0)
                                        {
                                            Console.WriteLine("\nNo event created yet");
                                        }
                                        else
                                        {
                                            foreach (var eventLoop in events)
                                            {
                                                Console.WriteLine(eventLoop.Name + " " + eventLoop.Date + " " + eventLoop.Address + " " + eventLoop.Description + " " + eventLoop.Status.ToString() + " " + eventLoop.Type.ToString());
                                            }
                                        }
                                        break;

                                    // CREATE EVENT
                                    case "NumPad2":
                                        Event eventToCreate = new Event();
                                        Console.Write("Name: ");
                                        eventToCreate.Name = Console.ReadLine();
                                        Console.Write("Date (format \"dd/MM/yyyy\"): ");
                                        try
                                        {
                                            eventToCreate.Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        Console.Write("Address: ");
                                        eventToCreate.Address = Console.ReadLine();
                                        Console.Write("Description: ");
                                        eventToCreate.Description = Console.ReadLine();
                                        Console.Write("Status (\"Open\", \"Closed\" or \"Pending\"): ");
                                        try
                                        {
                                            string status = Console.ReadLine();
                                            eventToCreate.Status = (EventStatus)Enum.Parse(typeof(EventStatus), status[0].ToString().ToUpper() + status.Substring(1));
                                            Console.Write("Type (\"Party\" or \"Lunch\"): ");
                                            string type = Console.ReadLine();
                                            eventToCreate.Type = (EventType)Enum.Parse(typeof(EventType), type[0].ToString().ToUpper() + type.Substring(1));
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        Event createdEvent = channel.CreateEvent(eventToCreate);
                                        if (createdEvent == null)
                                        {
                                            Console.WriteLine("\nYou have to give a value for all fields, or maybe this name is already taken");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nNew event created: ");
                                            Console.WriteLine(createdEvent.Name + " " + createdEvent.Date + " " + createdEvent.Address + " " + createdEvent.Description + " " + createdEvent.Status.ToString() + " " + createdEvent.Type.ToString());
                                        }
                                        break;

                                    // UPDATE EVENT
                                    case "NumPad3":
                                        Console.Write("\nName of the event you want to update: ");
                                        string eventName = Console.ReadLine();
                                        Event eventToUpdate = channel.GetEventByName(eventName);
                                        if(eventToUpdate == null)
                                        {
                                            Console.WriteLine("\nThis event does not exist");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEvent to update: ");
                                            Console.WriteLine(eventToUpdate.Name + " " + eventToUpdate.Date + " " + eventToUpdate.Address + " " + eventToUpdate.Description + " " + eventToUpdate.Status.ToString() + " " + eventToUpdate.Type.ToString());
                                            Console.WriteLine("\nPlease provide new data (EMPTY VALUE WILL KEEP EXISTING VALUE)");
                                            Console.Write("Name: ");
                                            eventName = Console.ReadLine();
                                            eventToUpdate.Name = eventName.Equals("") ? eventToUpdate.Name : eventName;
                                            Console.Write("Date (format \"dd/MM/yyyy\"): ");
                                            try
                                            {
                                                string newDateString = Console.ReadLine();
                                                eventToUpdate.Date = newDateString.Equals("") ? eventToUpdate.Date : DateTime.ParseExact(newDateString, "dd/MM/yyyy", CultureInfo.CurrentCulture);
                                            }
                                            catch(Exception)
                                            {
                                                goto default;
                                            }
                                            Console.Write("Address: ");
                                            string eventAddress = Console.ReadLine();
                                            eventToUpdate.Address = eventAddress.Equals("") ? eventToUpdate.Address : eventAddress;
                                            Console.Write("Description: ");
                                            string eventDescription = Console.ReadLine();
                                            eventToUpdate.Description = eventDescription.Equals("") ? eventToUpdate.Description : eventDescription;
                                            Console.Write("Status (\"Open\", \"Closed\" or \"Pending\"): ");
                                            try
                                            {
                                                string eventStatus = Console.ReadLine();
                                                eventToUpdate.Status = eventStatus.Equals("") ? eventToUpdate.Status : (EventStatus)Enum.Parse(typeof(EventStatus), eventStatus[0].ToString().ToUpper() + eventStatus.Substring(1));
                                                Console.Write("Type (\"Party\" or \"Lunch\"): ");
                                                string eventType = Console.ReadLine();
                                                eventToUpdate.Type = eventType.Equals("") ? eventToUpdate.Type : (EventType)Enum.Parse(typeof(EventType), eventType[0].ToString().ToUpper() + eventType.Substring(1));
                                            }
                                            catch (Exception)
                                            {
                                                goto default;
                                            }

                                            Event updatedEvent = channel.UpdateEvent(eventToUpdate);
                                            if (updatedEvent == null)
                                            {
                                                Console.WriteLine("\nThis event name is already taken");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nUpdated event: ");
                                                Console.WriteLine(updatedEvent.Name + " " + updatedEvent.Date + " " + updatedEvent.Address + " " + updatedEvent.Description + " " + updatedEvent.Status.ToString() + " " + updatedEvent.Type.ToString());
                                            }
                                        }
                                        break;

                                    // DELETE EVENT
                                    case "NumPad4":
                                        Console.Write("\nName of the event you want to delete: ");
                                        eventName = Console.ReadLine();
                                        Event EventToDelete = channel.GetEventByName(eventName);
                                        if (EventToDelete == null)
                                        {
                                            Console.WriteLine("\nThis event does not exist");
                                        }
                                        else
                                        {
                                            bool isDeleted = channel.DeleteEvent(EventToDelete);
                                            if (isDeleted == false)
                                            {
                                                Console.WriteLine("\nCan't delete this event, maybe already deleted");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nEvent deleted");
                                            }
                                        }
                                        break;

                                    case "Escape":
                                        break;
                                    default:
                                        Console.WriteLine("\nEnter a valid value");
                                        break;
                                }
                            }
                            break;
                            #endregion

                        #region CR Contribution
                        case "NumPad3":
                            var keyInfoContribution = new ConsoleKeyInfo();
                            while (!keyInfoContribution.Key.ToString().Equals("Escape"))
                            {
                                Console.WriteLine("\n\t1: Get all contributions");
                                Console.WriteLine("\t2: Create contribution");
                                Console.WriteLine("\t3: Add contribution to an existing event");
                                Console.WriteLine("\tEchap: Go back\n");
                                keyInfoContribution = Console.ReadKey(true);
                                switch (keyInfoContribution.Key.ToString())
                                {
                                    // GET ALL CONTRIBUTIONS
                                    case "NumPad1":
                                        List<Contribution> contributions = new List<Contribution>(channel.GetAllContributions());
                                        if (contributions.Count == 0)
                                        {
                                            Console.WriteLine("\nNo contribution created yet");
                                        }
                                        else
                                        {
                                            foreach (var contribution in contributions)
                                            {
                                                Console.WriteLine(contribution.Name + " " + contribution.Type + " " + contribution.Quantity + " " + contribution.Person.Nickname);
                                            }
                                        }
                                        break;

                                    // CREATE CONTRIBUTION
                                    case "NumPad2":
                                        Contribution newContribution = new Contribution();
                                        Console.Write("Name: ");
                                        newContribution.Name = Console.ReadLine();
                                        try
                                        {
                                            if(channel.GetContributionByName(newContribution.Name) != null)
                                            {
                                                Console.WriteLine("\nThis contribution name is already used");
                                                throw new Exception();
                                            }
                                            Console.Write("Type (\"Money\", \"Food\" or \"Beverage\"): ");
                                            var contributionType = Console.ReadLine();
                                            newContribution.Type = (ContributionType)Enum.Parse(typeof(ContributionType), contributionType[0].ToString().ToUpper() + contributionType.Substring(1));
                                            Console.Write("Quantity (ex: \"2L of vodka\"): ");
                                            newContribution.Quantity = Console.ReadLine();
                                            Console.Write("Nickname of existing person: ");
                                            var contributionPersonNickname = Console.ReadLine();
                                            var contributionPerson = channel.GetPersonByNickname(contributionPersonNickname);
                                            if (contributionPerson == null)
                                            {
                                                throw new Exception();
                                            }
                                            newContribution.Person = contributionPerson;
                                            var createdContribution = channel.CreateContribution(newContribution);
                                            if (createdContribution == null)
                                            {
                                                Console.WriteLine("\nThis contribution name is already used");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\n" + createdContribution.Name + " " + createdContribution.Type + " " + createdContribution.Quantity + " " + createdContribution.Person.Nickname);
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    // ADD CONTRIBUTION TO AN EXISTING EVENT
                                    case "NumPad3":
                                        try
                                        {
                                            Console.Write("Contribution's name: ");
                                            string contributionName = Console.ReadLine();
                                            var contributionInDb = channel.GetContributionByName(contributionName);
                                            if (contributionInDb == null)
                                            {
                                                Console.WriteLine("\nThis contribution does not exist");
                                                throw new Exception();
                                            }
                                            Console.Write("Event's name: ");
                                            string eventName = Console.ReadLine();
                                            var eventInDb = channel.GetEventByName(eventName);
                                            if (eventInDb == null)
                                            {
                                                Console.WriteLine("\nThis event does not exist");
                                                throw new Exception();
                                            }
                                            var updatedEvent = channel.AddContribution(contributionInDb, eventInDb);
                                            if(updatedEvent == null)
                                            {
                                                Console.WriteLine("\nThis contribution has already been added to an event");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nContribution added to the event: ");
                                                Console.WriteLine(updatedEvent.Name + " " + updatedEvent.Date + " " + updatedEvent.Address + " " + updatedEvent.Description + " " + updatedEvent.Status.ToString() + " " + updatedEvent.Type.ToString());
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    case "Escape":
                                        break;
                                    default:
                                        Console.WriteLine("\nEnter a valid value");
                                        break;
                                }
                            }
                            break;
                        #endregion

                        #region Manage events
                        case "NumPad4":
                            var keyInfoManageEvents = new ConsoleKeyInfo();
                            while (!keyInfoManageEvents.Key.ToString().Equals("Escape"))
                            {
                                Console.WriteLine("\n\t1: Get event by name");
                                Console.WriteLine("\t2: Get event(s) by date");
                                Console.WriteLine("\t3: Get event(s) between two dates");
                                Console.WriteLine("\t4: Get event(s) by status");
                                Console.WriteLine("\t5: Get event(s) by type");
                                Console.WriteLine("\t6: Delete all closed events");
                                Console.WriteLine("\t7: Update pending events to open");
                                Console.WriteLine("\t8: Add a person to an open event");
                                Console.WriteLine("\t9: Get all persons in an open event");
                                Console.WriteLine("\tEchap: Go back\n");
                                keyInfoManageEvents = Console.ReadKey(true);
                                switch (keyInfoManageEvents.Key.ToString())
                                {
                                    // GET EVENT BY NAME
                                    case "NumPad1":
                                        Console.Write("\nEvent's name: ");
                                        string eventName = Console.ReadLine();
                                        Event eventInDb = channel.GetEventByName(eventName);
                                        if (eventInDb == null)
                                        {
                                            Console.WriteLine("\nThis event does not exist");
                                        }
                                        else
                                        {
                                            Console.WriteLine(eventInDb.Name + " " + eventInDb.Date + " " + eventInDb.Address + " " + eventInDb.Description + " " + eventInDb.Status.ToString() + " " + eventInDb.Type.ToString());
                                        }
                                        break;

                                    // GET EVENT(S) BY DATE
                                    case "NumPad2":
                                        Console.Write("Date (format \"dd/MM/yyyy\"): ");
                                        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
                                        var events = channel.GetEventsByDate(date);
                                        if (events.Count() == 0)
                                        {
                                            Console.WriteLine("\nNo event on this date");
                                        }
                                        else
                                        {
                                            foreach (var event1 in events)
                                            {
                                                Console.WriteLine("\n" + event1.Name + " " + event1.Date + " " + event1.Address + " " + event1.Description + " " + event1.Status.ToString() + " " + event1.Type.ToString());
                                            }
                                        }
                                        break;

                                    // GET EVENT(S) BETWEEN TWO DATES
                                    case "NumPad3":
                                        try
                                        {
                                            Console.Write("Start date (format \"dd/MM/yyyy\"): ");
                                            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
                                            Console.Write("End date (format \"dd/MM/yyyy\"): ");
                                            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
                                            var eventsResult = channel.GetEventsBetweenTwoDates(startDate, endDate);
                                            if (eventsResult.Count() == 0)
                                            {
                                                Console.WriteLine("\nNo events between these two dates");
                                            }
                                            else
                                            {
                                                foreach (var eventResult in eventsResult)
                                                {
                                                    Console.WriteLine("\n" + eventResult.Name + " " + eventResult.Date + " " + eventResult.Address + " " + eventResult.Description + " " + eventResult.Status.ToString() + " " + eventResult.Type.ToString());
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    // GET EVENT(S) BY STATUS
                                    case "NumPad4":
                                        Console.Write("Status (\"Open\", \"Closed\" or \"Pending\"): ");
                                        try
                                        {
                                            string eventStatusSring = Console.ReadLine();
                                            EventStatus eventStatus = (EventStatus)Enum.Parse(typeof(EventStatus), eventStatusSring[0].ToString().ToUpper() + eventStatusSring.Substring(1));
                                            var eventsByStatus = channel.GetEventsByStatus(eventStatus);
                                            if (eventsByStatus.Count() == 0)
                                            {
                                                Console.WriteLine("\nNo event with this status");
                                            }
                                            else
                                            {
                                                foreach (var eventByStatus in eventsByStatus)
                                                {
                                                    Console.WriteLine("\n" + eventByStatus.Name + " " + eventByStatus.Date + " " + eventByStatus.Address + " " + eventByStatus.Description + " " + eventByStatus.Status.ToString() + " " + eventByStatus.Type.ToString());
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    // GET EVENT(S) BY TYPE
                                    case "NumPad5":
                                        Console.Write("Type (\"Party\" or \"Lunch\"): ");
                                        try
                                        {
                                            string eventTypeString = Console.ReadLine();
                                            EventType eventType = (EventType)Enum.Parse(typeof(EventType), eventTypeString[0].ToString().ToUpper() + eventTypeString.Substring(1));
                                            var eventsByType = channel.GetEventsByType(eventType);
                                            if (eventsByType.Count() == 0)
                                            {
                                                Console.WriteLine("\nNo event with this type");
                                            }
                                            else
                                            {
                                                foreach (var eventByType in eventsByType)
                                                {
                                                    Console.WriteLine("\n" + eventByType.Name + " " + eventByType.Date + " " + eventByType.Address + " " + eventByType.Description + " " + eventByType.Status.ToString() + " " + eventByType.Type.ToString());
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    // DELETE ALL CLOSED EVENTS
                                    case "NumPad6":
                                        if (channel.DeleteClosedEvents() == false)
                                        {
                                            Console.WriteLine("\nThere was no closed events to delete");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nClosed events are now deleted");
                                        }
                                        break;

                                    // UPDATE PENDING EVENTS TO OPEN
                                    case "NumPad7":
                                        if (channel.UpdatePendingEvents() == false)
                                        {
                                            Console.WriteLine("\nThere was no pending events");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nPending events are now open");
                                        }
                                        break;

                                    // ADD PERSON TO AN OPEN EVENT
                                    case "NumPad8":
                                        try
                                        {
                                            Console.Write("Person's nickname: ");
                                            string nickname = Console.ReadLine();
                                            var personToAddToEvent = channel.GetPersonByNickname(nickname);
                                            if (personToAddToEvent == null)
                                            {
                                                throw new Exception();
                                            }
                                            Console.Write("Event's name: ");
                                            string eventNameString = Console.ReadLine();
                                            var eventTarget = channel.GetEventByName(eventNameString);
                                            if (eventTarget == null)
                                            {
                                                throw new Exception();
                                            }
                                            if (channel.AddPersonToOpenEvent(eventTarget, personToAddToEvent) == false)
                                            {
                                                Console.WriteLine("\nThis event is not open, or this person has already been added to it");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nPerson added to this event");
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    // GET ALL PERSONS IN AN OPEN EVENT
                                    case "NumPad9":
                                        try
                                        {
                                            Console.Write("Event's name: ");
                                            var eventNameString2 = Console.ReadLine();
                                            var event2 = channel.GetEventByName(eventNameString2);
                                            if (event2 == null)
                                            {
                                                throw new Exception();
                                            }
                                            var persons = channel.GetAllPersonsFromOpenEvent(event2);
                                            if (persons == null)
                                            {
                                                Console.WriteLine("\nThis event is not Open");
                                            }
                                            else if (persons.Length == 0)
                                            {
                                                Console.WriteLine("\nNobody in this event for the moment");
                                            }
                                            else
                                            {
                                                foreach (var person in persons)
                                                {
                                                    Console.WriteLine(person.Firstname + " " + person.Lastname + " " + person.Nickname);
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    case "Escape":
                                        break;
                                    default:
                                        Console.WriteLine("\nEnter a valid value");
                                        break;
                                }
                            }
                            break;
                        #endregion

                        #region Manage Contributions
                        case "NumPad5":
                            var keyInfoManageContributions = new ConsoleKeyInfo();
                            while (!keyInfoManageContributions.Key.ToString().Equals("Escape"))
                            {
                                Console.WriteLine("\n\t1: Get all contributions of an event");
                                Console.WriteLine("\t2: Get all contributions of a person for all events");
                                Console.WriteLine("\t3: Delete all contribution of a person for all open events");
                                Console.WriteLine("\tEchap: Go back\n");
                                keyInfoManageContributions = Console.ReadKey(true);
                                switch (keyInfoManageContributions.Key.ToString())
                                {
                                    // GET ALL CONTRIBUTIONS OF AN EVENT
                                    case "NumPad1":
                                        try
                                        {
                                            Console.Write("Event's name: ");
                                            var eventNameString2 = Console.ReadLine();
                                            var event2 = channel.GetEventByName(eventNameString2);
                                            if (event2 == null)
                                            {
                                                throw new Exception();
                                            }
                                            var contributions = channel.GetAllContributionsFromEvent(event2);
                                            if (contributions.Length == 0)
                                            {
                                                Console.WriteLine("\nNo contribution for this event for the moment");
                                            }
                                            else
                                            {
                                                foreach (var contribution in contributions)
                                                {
                                                    Console.WriteLine(contribution.Name + " " + contribution.Type + " " + contribution.Quantity + " " + contribution.Person.Nickname);
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    // GET ALL CONTRIBUTIONS OF A PERSON FOR ALL EVENTS
                                    case "NumPad2":
                                        try
                                        {
                                            Console.Write("Person's nickname: ");
                                            string nickname = Console.ReadLine();
                                            var personToGetContributions = channel.GetPersonByNickname(nickname);
                                            if (personToGetContributions == null)
                                            {
                                                throw new Exception();
                                            }
                                            var contributions = channel.GetAllContributionsFromPerson(personToGetContributions);
                                            if (contributions.Length == 0)
                                            {
                                                Console.WriteLine("\nThis person has no contribution for the moment");
                                            }
                                            else
                                            {
                                                foreach (var contribution in contributions)
                                                {
                                                    Console.WriteLine(contribution.Name + " " + contribution.Type + " " + contribution.Quantity + " " + contribution.Person.Nickname);
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    // DELETE ALL CONTRIBUTIONS OF A PERSON FOR ALL OPEN EVENTS
                                    case "NumPad3":
                                        try
                                        {
                                            Console.Write("Person's nickname: ");
                                            string nickname = Console.ReadLine();
                                            var personToDeleteContributions = channel.GetPersonByNickname(nickname);
                                            if (personToDeleteContributions == null)
                                            {
                                                throw new Exception();
                                            }
                                            var contributions = channel.DeleteAllContributionsForAllOpenEventsFromPerson(personToDeleteContributions);
                                            if (contributions == false)
                                            {
                                                Console.WriteLine("\nThis person has no contribution for all his open events to delete");
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nContributions deleted");
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            goto default;
                                        }
                                        break;

                                    case "Escape":
                                        break;
                                    default:
                                        Console.WriteLine("\nEnter a valid value");
                                        break;
                                }
                            }
                            break;
                        #endregion

                        case "Escape":
                            break;

                        default:
                            Console.WriteLine("\nEnter a valid value");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nOOPS, an error occured:\n " + ex.Message);
                Console.WriteLine("Program will exit (Press any key)");
                Console.ReadKey(true);
            }
        }
    }
}
