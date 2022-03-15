using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGeneratorApp
{
    public class Person
    {
        public Address address = new Address();

        public List<Car> cars;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public bool HasACar { get { return cars != null && cars.Count > 0; } }


    }
}
