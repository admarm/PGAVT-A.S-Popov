using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Person
{
    private string firstName;
    private string lastName;
    private int age, salary;

    public Person(string firstName, string lastName, int age, int salary)
    {
        validation_firstName(firstName);
        validation_lastName(lastName);
        validation_age(age);
        validation_salary(salary);
        
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return firstName; }
        private set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        private set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        private set { age = value; }
    }

    public int Salary
    {
        get { return salary; }
        private set { salary = value; }
    }

    private void validation_firstName(string firstName)
    {
        if (firstName.Length < 3)
        {
            throw new ArgumentException("First name must be longer than 3 characters.");
        }
        this.firstName = firstName;
    }

    private void validation_lastName(string lastName)
    {
        if (lastName.Length < 3)
        {
            throw new ArgumentException("Last name must be longer than 3 characters.");
        }
        this.lastName = lastName;
    }
    
    private void validation_age(int age)
    {
        if (age <= 0)
        {
            throw new ArgumentException("Age must be greater than 0.");
        }
        this.age = age;
    }

    private void validation_salary(int salary)
    {
        if (salary < 460)
        {
            throw new ArgumentException("Salary must be higher than 460.");
        }
        this.salary = salary;
    }
    
    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old and earns {salary} a month.";
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Model(firstName lastName age salary)\nLines: ");
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), int.Parse(cmdArgs[3]));
            persons.Add(person);
        }

        persons.OrderBy(p => p.FirstName)
               .ThenBy(p => p.Age)
               .ToList()
               .ForEach(p => Console.WriteLine(p.ToString()));
    }
}