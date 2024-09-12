using System;
using FluentAssertions;
using Reqnroll;

namespace CucumberDiseases.Specs.StepDefinitions;

[Binding]
public class CustomerStepDefinitions
{
    private static readonly DateTime DefaultBirthday = DateTime.Parse("01/01/1995");

    private readonly CustomerService _customerService;
    private string _firstName;
    private string _lastName;
    private string _secondFirstName;
    private string _secondLastName;
    private int _count;
    private ArgumentException _error;

    public CustomerStepDefinitions(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [Given("the customer name is {} {}")]
    public void GivenTheCustomerNameIs(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    [Given("the second customer is (.*) (.*)")]
    public void GivenTheSecondCustomerIs(string firstName, string lastName)
    {
        _secondFirstName = firstName;
        _secondLastName = lastName;
    }

    [When("the customer is created")]
    [When("an invalid customer is created")]
    public void CreateCustomerAndHandleException()
    {
        try
        {
            _customerService.AddCustomer(_firstName, _lastName, DefaultBirthday);
        }
        catch (ArgumentException ex)
        {
            _error = ex;
        }
    }

    [When("the second customer is created")]
    public void WhenTheSecondCustomerIsCreated()
    {
    }

    [Then("the customer creation should be successful")]
    public void ThenTheCustomerCreationShouldBeSuccessful()
    {
        _error.Should().BeNull();
    }

    [Then("the customer creation should fail")]
    public void ThenTheCustomerCreationShouldFail()
    {
        _error.Should().NotBeNull();
        _error.Message.Should().Be("Mandatory name parameter is missing");
    }

    [Then("the second customer creation should fail")]
    public void ThenTheSecondCustomerCreationShouldFail()
    {
        var add = () => _customerService.AddCustomer(_secondFirstName, _secondLastName, DefaultBirthday);
        add.Should()
            .Throw<ArgumentException>()
            .WithMessage("Customer already exists");
    }

    [Given("there are no customers")]
    public void GivenThereAreNoCustomers()
    {
    }

    [Given("there is a customer")]
    [Given("there are some customers")]
    public void GivenThereAreSomeCustomers(Table customerTable)
    {
        var customers = customerTable.CreateSet<CustomerData>(() => new CustomerData("John", "Doe", DefaultBirthday));
        foreach (var customer in customers)
        {
            _customerService.AddCustomer(customer.FirstName, customer.LastName, customer.Birthday);
        }
    }

    [When("all customers are searched")]
    public void WhenAllCustomersAreSearched()
    {
        _count = _customerService.FindAllCustomers().Count;
    }

    [When("the customer {} {} is searched")]
    public void WhenTheCustomerIsSearched(string firstName, string lastName)
    {
        _count = _customerService.FindCustomers(firstName, lastName).Count;
    }

    [Then("the customer can be found")]
    public void ThenTheCustomerCanBeFound()
    {
        var customer = _customerService.FindCustomer(_firstName, _lastName);

        customer.Should().BeEquivalentTo(new { FirstName = _firstName, LastName = _lastName });
    }

    [Then("the customer {} {} can be found")]
    public void ThenTheCustomerCanBeFound(string firstName, string lastName)
    {
        var customerByName = _customerService.FindCustomer(firstName, lastName);

        customerByName.Should().BeEquivalentTo(new { FirstName = firstName, LastName = lastName });
    }

    [Then("the second customer can be found")]
    public void ThenTheSecondCustomerCanBeFound()
    {
        _customerService.AddCustomer(_secondFirstName, _secondLastName, DefaultBirthday);
        var customer = _customerService.FindCustomer(_secondFirstName, _secondLastName);

        customer.Should().BeEquivalentTo(new { FirstName = _secondFirstName, LastName = _secondLastName });
    }

    [Then("the number of customers found is {int}")]
    public void ThenTheNumberOfCustomersFoundIs(int expectedCount)
    {
        _count.Should().Be(expectedCount);
    }
}

public record CustomerData(string FirstName, string LastName, DateTime Birthday)
{
}