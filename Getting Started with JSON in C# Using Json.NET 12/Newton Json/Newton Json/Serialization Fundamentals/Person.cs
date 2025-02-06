using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Json.Serialization_Fundamentals
{
    public class Person
    {
        public string name { get; set; } = null!;
        public int age { get; set; }
        public string email { get; set; } = null!;
        public Address address { get; set; } = null!;
        public Phonenumber[] phoneNumbers { get; set; } = null!;
        public bool isActive { get; set; }

        public List<Person> favouritePersons { get; set; } = new();
        public override string ToString()
        {
            return name + " " + age + " " + email;
        }

    }
    public class Address
    {
        public string street { get; set; } = null!;
        public string city { get; set; } = null!;
        public string state { get; set; } = null!;
        public string postalCode { get; set; } = null!;
    }

    public class Phonenumber
    {
        public string type { get; set; } = null!;
        public string number { get; set; } = null!;
    }
}
