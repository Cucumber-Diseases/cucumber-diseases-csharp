# Cucumber Disease #6 - "Given/When Purpose Mismatch"
## Description
The "Given/When Purpose Mismatch" occurs when the roles of Given and When steps are confused or misused in a Gherkin scenario. It happens when the Given step is intended to set up test data, while the When step is meant to test a function that creates something. In a proper setup (Given), the focus should be on preparing the necessary context or state, without concern for validation or correctness. However, the implementation of these steps may be similar or identical, leading to confusion.

## Impact
* Readability: Scenarios become harder to understand because the purpose of each step is unclear, leading to confusion about what is being tested.
* Maintenance: Maintaining such tests becomes challenging, as the conflation of setup and behavior testing can lead to brittle tests that are difficult to update or refactor.
* Clarity: The distinction between preparation and verification blurs, making it difficult to discern whether the scenario is setting up context or validating functionality.
* Complexity: This smell can increase the complexity of tests, as it introduces unnecessary checks and validations in the setup phase, complicating the logic of the test steps.

## Your task

TODO: describe details of exercise

* Separate Concerns: Clearly differentiate between Given and When steps. Ensure that Given steps are solely for setting up the context without any assertions, and When steps are used to trigger the behavior you want to test, including necessary validations.
* Refactor Steps: If you identify a Given step that performs validation or verification, refactor it into a When step to align with the intended purpose. Similarly, ensure that When steps do not involve unnecessary setup.
* Use Scenario Outlines: If multiple scenarios share similar setups, use scenario outlines to parameterize the Given step and avoid code duplication.
* Use Data Tables: If your scenario needs different test data of the same kind pass a data tale instead of duplicating your "Given" steps.

