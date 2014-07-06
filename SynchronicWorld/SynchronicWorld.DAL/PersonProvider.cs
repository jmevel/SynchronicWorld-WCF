using SynchronicWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SynchronicWorld.DAL
{
    public class PersonProvider
    {
        public List<Person> GetAllPersons()
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Persons.ToList();
            }
        }

        public Person CreatePerson(Person person)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                //can't contain space, or nickname already used, or Firstname AND Lastname couple is already used
                if (context.Persons.Where(c => c.Firstname.ToLower().Equals(person.Firstname) && c.Lastname.ToLower().Equals(person.Lastname.ToLower())).Count() != 0
                    || context.Persons.Where(c => c.Nickname.ToLower().Equals(person.Nickname.ToLower())).Count() != 0
                    || person.Nickname.Contains(' ') == true)
                {
                    return null;
                }
                Person newPerson = context.Persons.Add(person);
                context.SaveChanges();
                return newPerson;
            }
        }

        public Person GetPersonByNickname(string nickname)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Persons.Where(p => p.Nickname.ToLower().Equals(nickname.ToLower())).FirstOrDefault();
            }
        }

        public Person UpdatePerson(Person person)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {

                //can't contain space, or nickname already used, or Firstname AND Lastname couple is already used
                if (context.Persons.Where(p => p.Firstname.ToLower().Equals(person.Firstname) && p.Lastname.ToLower().Equals(person.Lastname.ToLower()) && !p.Id.Equals(person.Id)).Count() != 0
                   || context.Persons.Where(p => p.Nickname.ToLower().Equals(person.Nickname.ToLower()) && !p.Id.Equals(person.Id)).Count() != 0
                   || person.Nickname.Contains(' ') == true)
                {
                    return null;
                }
                Person personInDb = context.Persons.Where(p => p.Id.Equals(person.Id)).FirstOrDefault();
                if (personInDb == null)
                {
                    return null;
                }
                personInDb.Firstname = person.Firstname;
                personInDb.Lastname = person.Lastname;
                personInDb.Nickname = person.Nickname;
                context.SaveChanges();
                return personInDb;
            }
        }

        public bool DeletePerson(Person person)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                Person PersonInDb = context.Persons.Where(p => p.Id.Equals(person.Id)).FirstOrDefault();
                if (PersonInDb == null)
                {
                    return false;
                }
                var contribsToRemove = context.Contributions.Include(c => c.Person).Where(p => p.Person.Id.Equals(person.Id));
                var events = context.Events.Include(e => e.Contributions).Include(e => e.Persons).ToList();
                foreach (var event1 in events)
                {
                    event1.Persons.Remove(PersonInDb);
                    foreach(var contr in contribsToRemove)
                    {
                        event1.Contributions.Remove(contr);
                    }
                }

                
                // A CONTRIBUTION CAN HAVE NO PERSON 
                /*foreach (var contr in contribs)
                {
                    context.Persons.Remove(contr.Person);
                }*/

                // BUT I CHOOSE A CONTRIBUTION MUST HAVE A PERSON, SO I DELETE EVERY CONTRIBUTIONS WHICH HAVE NOBODY NOW
                foreach (var contr in contribsToRemove)
                {
                    context.Contributions.Remove(contr);
                }
                context.Persons.Remove(PersonInDb);
                context.SaveChanges();
                return true;
            }
        }
    }
}
