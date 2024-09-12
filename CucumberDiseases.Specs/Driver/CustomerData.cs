using System;

namespace CucumberDiseases.Specs.Driver;

public record CustomerData(string FirstName, string LastName, DateTime Birthday)
{
    public static readonly DateTime DefaultBirthday = DateTime.Parse("01/01/1995");

    public static CustomerData CreateDefaultCustomer()
    {
        return new CustomerData("John", "Doe", DefaultBirthday);
    }
}