using CucumberDiseases.Specs.Driver;
using Reqnroll;

namespace CucumberDiseases.Specs.StepDefinitions;

[Binding]
public class CustomerStepDefinitions(CustomerServiceDriver customerServiceDriver)
{
    [When("the customer {} {} is created")]
    [When("an invalid customer {} {} is created")]
    [When("the second customer {} {} is created")]
    public void CreateCustomerAndHandleException(string firstName, string lastName)
    {
        customerServiceDriver.CreateCustomerAndHandleException(firstName, lastName);
    }

    [Then("the customer creation should be successful")]
    public void ThenTheCustomerCreationShouldBeSuccessful()
    {
        customerServiceDriver.CreateCustomerWasSuccessful();
    }

    [Then("the customer creation should fail")]
    public void ThenTheCustomerCreationShouldFail()
    {
        customerServiceDriver.CreateCustomerFailed("Mandatory name parameter is missing");
    }

    [Then("the second customer creation should fail")]
    public void ThenTheSecondCustomerCreationShouldFail()
    {
        customerServiceDriver.CreateCustomerFailed("Customer already exists");
    }

    [Given("there are no customers")]
    public void GivenThereAreNoCustomers()
    {
    }

    [Given("there is a customer")]
    [Given("there are some customers")]
    public void GivenThereAreSomeCustomers(Table customerTable)
    {
        var customers = customerTable.CreateSet<CustomerData>(CustomerData.CreateDefaultCustomer);
        customerServiceDriver.CreateCustomers(customers);
    }


    [When("all customers are searched")]
    public void WhenAllCustomersAreSearched()
    {
        customerServiceDriver.FindAllCustomers();
    }

    [When("the customer {} {} is searched")]
    public void WhenTheCustomerIsSearched(string firstName, string lastName)
    {
        customerServiceDriver.FindCustomers(firstName, lastName);
    }

    [Then("the customer {} {} can be found")]
    [Then("the second customer {} {} can be found")]
    public void ThenTheCustomerCanBeFound(string firstName, string lastName)
    {
        customerServiceDriver.VerifyCustomerFound(firstName, lastName);

    }

    [Then("the number of customers found is {int}")]
    public void ThenTheNumberOfCustomersFoundIs(int expectedCount)
    {
        customerServiceDriver.VerifyNumberOfCustomersFound(expectedCount);
    }
}