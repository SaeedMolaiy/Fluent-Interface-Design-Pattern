using FluentInterface.Models;

#region Using Method Chain

Console.WriteLine("Using Method Chain :");

var person = new Person("Saeed", "Molaiy", 19);
Console.WriteLine($"First Name : {person.FirstName}, Last Name : {person.LastName}, Age : {person.Age}");

person.SetFirstName("Ali").SetLastName("Mohammadi").SetAge(30);

Console.WriteLine($"First Name : {person.FirstName}, Last Name : {person.LastName}, Age : {person.Age}");

Console.WriteLine();

#endregion

#region Using Extension Method Chain

Console.WriteLine("Using Extension Method Chain :");

var employee = new Employee("Saeed", "Molaiy", 19);

Console.WriteLine($"First Name : {employee.FirstName}, Last Name : {employee.LastName}, Age : {employee.Age}");

employee.SetFirstName("Mohammad").SetLastName("Mohammadi").SetAge(30);

Console.WriteLine($"First Name : {employee.FirstName}, Last Name : {employee.LastName}, Age : {employee.Age}");

#endregion

Console.ReadKey();