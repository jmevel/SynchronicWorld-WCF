using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SynchronicWorld.Models
{
    [DataContract]
    public class Contribution
    {
        public Contribution()
        {

        }

        public Contribution(string name, string quantity, ContributionType type, Person person)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Type = type;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Quantity { get; set; }

        [DataMember]
        public ContributionType Type { get; set; }

        [DataMember]
        public Person Person { get; set; }
    }
}
