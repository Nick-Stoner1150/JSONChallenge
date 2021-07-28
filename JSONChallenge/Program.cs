using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("Nick", "Stoner", new DateTime(1992, 07, 27));
            newPerson.FavoriteIceCreamFlavors = new List<string> { "Strawberry", "Cookie-Dough", "Chocolate" };

            string json = JsonConvert.SerializeObject(newPerson);
            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
