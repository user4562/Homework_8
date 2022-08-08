using System.Xml.Linq;

namespace Homework_8_4
{
    internal class Program
    {
        static void Main()
        {
            string pathSave = "person.xml";

            XElement person = new XElement("Person");
            XElement address = new XElement("Address");
            XElement street = new XElement("Street");
            XElement houseNumber = new XElement("HouseNumber");
            XElement flatNumber = new XElement("FlatNumber");
            XElement phones = new XElement("Phones");
            XElement mobileNumber = new XElement("mobileNumber");
            XElement flatPhone = new XElement("flatPhone");

            string name;
            while (true)
            {
                Console.WriteLine("Введите имя.");
                name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) break;
                
                Console.WriteLine("Имя не может быть пустым.");         
            }

            person.Add(new XAttribute("name",name));
            
            Console.WriteLine("Введите название улицы.");
            street.Add(Console.ReadLine());          
            
            Console.WriteLine("Введите номер дома.");
            houseNumber.Add(Console.ReadLine());            
            
            Console.WriteLine("Введите номер квартиры.");
            flatNumber.Add(Console.ReadLine());

            Console.WriteLine("Введите номер мобильного телефона.");
            mobileNumber.Add(Console.ReadLine());

            Console.WriteLine("Введите номер домашнего телефона.");
            flatPhone.Add(Console.ReadLine());

            address.Add(street);
            address.Add(houseNumber);
            address.Add(flatNumber);

            phones.Add(mobileNumber);
            phones.Add(flatPhone);

            person.Add(address);
            person.Add(phones);

            person.Save(pathSave);

            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine();
            Console.WriteLine(File.ReadAllText(pathSave));
            Console.ReadLine();
        }

    }
}