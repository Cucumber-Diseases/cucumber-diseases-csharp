using System;
using System.Collections.Generic;
using FluentAssertions;

namespace CucumberDiseases.Specs.Driver;

public class CustomerServiceDriver(CustomerService customerService)
{
    private ArgumentException _error;
    private List<Customer> _customers;


    public void CreateCustomerAndHandleException(string firstName, string lastName)
    {
        try
        {
            customerService.AddCustomer(firstName, lastName, CustomerData.DefaultBirthday);
        }
        catch (ArgumentException ex)
        {
            _error = ex;
        }
    }

    public void CreateCustomers(IEnumerable<CustomerData> customers)
    {
        foreach (var customer in customers)
        {
            customerService.AddCustomer(customer.FirstName, customer.LastName, customer.Birthday);
        }
    }

    public void CreateCustomerWasSuccessful()
    {
        _error.Should().BeNull();
    }

    public void CreateCustomerFailed(string message)
    {
        _error.Should().NotBeNull();
        _error.Message.Should().Be(message);
    }

    public void FindAllCustomers()
    {
        _customers = customerService.FindAllCustomers();
    }

    public void FindCustomers(string firstName, string lastName)
    {
        _customers = customerService.FindCustomers(firstName, lastName);
    }

    public void VerifyCustomerFound(string firstName, string lastName)
    {
        var customerByName = customerService.FindCustomer(firstName, lastName);

        customerByName.Should().BeEquivalentTo(new { FirstName = firstName, LastName = lastName });
    }

    public void VerifyNumberOfCustomersFound(int expectedCount)
    {
        _customers.Count.Should().Be(expectedCount);
    }
}