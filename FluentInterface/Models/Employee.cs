namespace FluentInterface.Models;

public class Employee
{
    public Employee(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public static class EmployeeExtensions
{
    public static Employee SetFirstName(this Employee employee, string firstName)
    {
        employee.FirstName = firstName;
        return employee;
    }

    public static Employee SetLastName(this Employee employee, string lastName)
    {
        employee.LastName = lastName;
        return employee;
    }

    public static Employee SetAge(this Employee employee, int age)
    {
        employee.Age = age;
        return employee;
    }
}