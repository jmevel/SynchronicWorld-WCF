using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SynchronicWorld.Models
{
    [DataContract]
    public class Person
    {
        public Person()
        {

        }

        public Person(String firstname, String lastname, String nickname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Nickname = nickname;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Firstname { get; set; }

        [DataMember]
        public String Lastname { get; set; }

        [DataMember]
        public String Nickname { get; set; }
    }
}
