public class Hauptklasse
{
    public enum Sex
    {
        man,
        woman
    }

    public void CreatePerson(int age)
    {
        Person newPerson = new Person();
        newPerson.Age = age;
        if (age % 2 == 0)
        {
            newPerson.Name = "Батката";
            newPerson.Gender = Sex.man;
        }
        else
        {
            newPerson.Name = "Мацето";
            newPerson.Gender = Sex.woman;
        }
    }

    public class Person
    {
        public Sex Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}