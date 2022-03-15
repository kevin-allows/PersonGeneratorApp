using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGeneratorApp
{
    public class RandomPerson
    {
        private Random rnd = new Random();
        private string[] firstNamesFemale = {"Alexandra", "Alison", "Maria", "Sophie", "Wanda"},
            firstNamesMale = { "Brandon", "David", "Gordon", "Jonatan", "Peter" },
            lastNames = { "Abraham", "Campbell", "Ellison", "Henderson", "Johnston"},
            streets = {"2708 Adonais Way", "4154 Cherry Tree Drive", "3466 Wilmar FarmRoad",
            "1949 Jadewood Drive", "501 Blane Street"},
            cities = {"Atlanta", "Jacksonville", "Lanham", "Wheatfield", "Fairview Heights" },
            states = { "Georgia(GA)", "Florida(FL)", "Maryland(MD)", "Indiana(IN)", "Missouri(MO)" },
            models = { "Volvo", "BMW", "Jaguar", "Audi", "Ford"};

        private string generateElementOf(string[] strArray)
        {
            return strArray[rnd.Next(strArray.Length)];
        }
        private int generateZip()
        {
            return rnd.Next(1, 10000);
        }
        private string generateGender()
        {
            return rnd.Next(2) == 0 ? "Female" : "Male";  //0 or 1
        }
        private DateTime generateBirthDate()
        {
            DateTime start = new DateTime(1900, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range)).AddHours(rnd.Next(24)).AddMinutes(rnd.Next(60)).AddSeconds(rnd.Next(60));
        }
        private string generatePhoneNumber()
        {
            // 100-999
            return rnd.Next(100, 1000) + "-" + rnd.Next(100, 1000) + "-" + rnd.Next(1000, 10000);
        }
        private bool generateHasACar()
        {
            return rnd.Next(2) == 0;
        }
        private int generateHorsePower()
        {
            return rnd.Next(115, 301);
        }
        private int generateMaximumSpeed()
        {
            return rnd.Next(180, 301);
        }
        public Person generatePerson()
        {
            Person person = new Person();

            person.Gender = generateGender();
            person.FirstName = generateElementOf(person.Gender.Equals("Female") ?
                firstNamesFemale : firstNamesMale);
            person.LastName = generateElementOf(lastNames);
            person.Birthday = generateBirthDate();
            person.Telephone = generatePhoneNumber();
            person.Mobile = generatePhoneNumber();
            person.address.Street = generateElementOf(streets);
            person.address.City = generateElementOf(cities);
            person.address.State = generateElementOf(states);
            person.address.Zip = generateZip();
            if (generateHasACar())
            {
                person.cars = new List<Car>();
                int howMany = rnd.Next(1, 5 + 1);
                for (int i = 0; i < howMany; ++i)
                    person.cars.Add(new Car(generateElementOf(models), generateHorsePower(),
                        generateMaximumSpeed()));
            }
            return person;
        }



    }


}
