namespace CreatesNewXmlDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    internal class Program
    {
        public static void Main()
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                var personElement = new XElement("persons");

                var data = reader.ReadLine();
                while (data != null)
                {
                    person.Name = data;
                    person.Phone = reader.ReadLine();
                    person.Address = reader.ReadLine();
                    data = reader.ReadLine();

                    personElement.Add(new XElement("person",
                        new XElement("name", person.Name),
                        new XElement("phone", person.Phone),
                        new XElement("address", person.Address)));

                    personElement.Save("../../person.xml");
                }
            }

            Console.WriteLine("person saved as person.xml");
        }
    }
}