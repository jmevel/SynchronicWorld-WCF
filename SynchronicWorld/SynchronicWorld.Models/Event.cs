using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SynchronicWorld.Models
{
    [DataContract]
    public class Event
    {
        public Event()
        {

        }

        public Event(string name, string address, string description, DateTime date, EventType type, EventStatus status)
        {
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.Date = date;
            this.Type = type;
            this.Status = status;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String Address { get; set; }

        [DataMember]
        public String Description { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public EventType Type { get; set; }

        [DataMember]
        public EventStatus Status { get; set; }

        [DataMember]
        public List<Person> Persons { get; set; }

        [DataMember]
        public List<Contribution> Contributions { get; set; }

    }
}
