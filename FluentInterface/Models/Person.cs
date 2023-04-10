namespace FluentInterface.Models;

public class Person
{
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    public Person SetFirstName(string firstName)
    {
        FirstName = firstName;
        return this;
    }

    public Person SetLastName(string lastName)
    {
        LastName = lastName;
        return this;
    }

    public Person SetAge(int age)
    {
        Age = age;
        return this;
    }
}