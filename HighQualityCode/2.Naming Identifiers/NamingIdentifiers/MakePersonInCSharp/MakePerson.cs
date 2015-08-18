namespace MakePersonInCSharp
{
    public class MakePerson
    {
        public static void Main(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;

            if (age % 2 == 0)
            {
                newPerson.Name = "John";
                newPerson.Gender = Gender.Man;
            }
            else
            {
                newPerson.Name = "Jannet";
                newPerson.Gender = Gender.Female;
            }
        }
    }
}
