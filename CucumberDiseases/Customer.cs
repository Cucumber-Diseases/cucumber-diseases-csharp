using System;

namespace CucumberDiseases;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; init; }

    public bool IsAdult()
    {
        return DateTime.Today.Year - Birthday.Year >= 18;
    }

    public string FullName()
    {
        return FirstName + " " + LastName;
    }

    public string Email()
    {
        return FirstName.ToLower() + "." + LastName.ToLower() + "@mybank.com";
    }
}
