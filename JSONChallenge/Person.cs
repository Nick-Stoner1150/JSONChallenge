using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public List<string> FavoriteIceCreamFlavors { get; set; }
        public Person()
        {

        }

        public Person
        (
            string firstName, 
            string lastName, 
            DateTime dob
        )

        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dob;
        }
    }
}
