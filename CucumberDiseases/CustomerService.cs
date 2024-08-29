using System;
using System.Collections.Generic;

namespace CucumberDiseases;

public class CustomerService
{
    private readonly List<Customer> _customers = [];

    public void AddCustomer(string firstName, string lastName, DateTime birthday)
    {
        if (firstName == "" || lastName == "")
        {
            throw new ArgumentException("Mandatory name parameter is missing"); ;
        }

        if (CustomerExists(firstName, lastName, birthday))
        {
            throw new ArgumentException("Customer already exists");
        }

        _customers.Add(new Customer
        {
            FirstName = firstName,
            LastName = lastName,
            Birthday = birthday
        });
    }

    private bool CustomerExists(string firstName, string lastName, DateTime birthday)
    {
        if (_customers.Count == 0)
        {
            return false;
        }
        return _customers.Exists(customer => HasSameName(customer, firstName, lastName) && customer.Birthday == birthday);
    }

    public void RemoveCustomer(string firstName, string lastName, DateTime birthday)
    {
        for (var i = _customers.Count - 1; i >= 0; i--)
        {
            var customer = _customers[i];
            if (HasSameName(customer, firstName, lastName) && customer.Birthday == birthday)
            {
                _customers.RemoveAt(i);
            }
        }
    }

    public List<Customer> FindAllCustomers()
    {
        return FindCustomers(_ => true);
    }

    public List<Customer> FindCustomers(string firstName, string lastName)
    {
        return FindCustomers(customer => HasSameName(customer, firstName, lastName));
    }

    private List<Customer> FindCustomers(Predicate<Customer> match)
    {
        return _customers.FindAll(match);
    }

    public Customer FindCustomer(string firstName, string lastName)
    {
        return FindCustomer(customer => HasSameName(customer, firstName, lastName));
    }

    public Customer FindCustomer(Predicate<Customer> match)
    {
        return _customers.Find(match);
    }

    private static bool HasSameName(Customer customer, string firstName, string lastName)
    {
        return customer.FirstName == firstName && customer.LastName == lastName;
    }
}
