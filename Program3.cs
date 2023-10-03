using System;

public class Application
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee("Duba", "Danya", "Dubnitskiy", 18, DateTime.Now.Date);
        Console.WriteLine(employee);
        Console.ReadLine();
    }
}

class Employee
{
    private string login;
    private string name;
    private string surname;
    private int age;
    private readonly DateTime date;

    public Employee(string login, string name, string surname, int age, DateTime date)
    {
        this.login = login;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.date = date;
    }

    public override string ToString()
    {
        return $"Employee{{login='{login}', name='{name}', surname='{surname}', age={age}, date={date}}}";
    }
}