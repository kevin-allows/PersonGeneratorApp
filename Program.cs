using System;
namespace PersonGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomPerson personGenerator = new RandomPerson();
            for (int i = 0; i < 5; ++i)
            {
                Person person = personGenerator.generatePerson();
                Console.WriteLine("=================");
                Console.WriteLine("BASIC INFORMATION");
                Console.WriteLine("Firstname: {0}\n\rLastname: {1}\n\rGender: {2}\n\rBirthDay: {3}",
                    person.FirstName, person.LastName, person.Gender, person.Birthday);
                Console.WriteLine("\n\rCONTACT INFORMATION");
                Console.WriteLine("Telephone: {0} Mobile: {1}\n\rCity: {2}\n\rState: {3}\n\rStreet: {4}\n\rZip: {5}",
                person.Telephone, person.Mobile, person.address.City, person.address.State, person.address.Street, person.address.Zip);
            Console.WriteLine("\n\rCAR INFORMATION");
            if (person.HasACar)
                foreach (Car car in person.cars)
                    Console.WriteLine("Model: {0}\n\rHorsePower: {1}\n\rMaximumSpeed: {2}",
                        car.getModel(), car.getHorsePower(), car.getMaximumSpeed());
            else
                Console.WriteLine("HAS NO ANY CARS");
            Console.WriteLine("=================");
            Console.WriteLine();
        }
    }
}
}
