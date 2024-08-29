# Cucumber Disease #12 - "Test Code Impurity"

## Description
“Test Code Impurity” occurs when the step definition contains significant business logic, resulting in tightly coupled test code. In other words, the test code becomes heavily reliant on the syntax and intricacies of the system under test (SUT). This tight coupling makes the test suite challenging to maintain and less adaptable to changes in the SUT.

## Impact
* Coupling: The business logic embedded within step definitions creates a strong dependency between the test code and the SUT. Any changes to the business rules or system behavior can propagate throughout the entire test suite, leading to maintenance difficulties.
* Readability: When business logic is mixed with test code, it becomes harder to understand the purpose of each step. Developers may struggle to differentiate between actual test steps and implementation details.
* Maintenance: As the system evolves, maintaining and updating the test code becomes cumbersome. Changes to business rules may require modifications across multiple step definitions, increasing the risk of errors.
* Scalability Issues: Complex step definitions hinder scalability. As the number of scenarios grows, managing intertwined business logic becomes unwieldy.
* Reusabilty: Tests become less reusable as they are tightly coupled to the system's implementation.

## Your task

TODO: describe details of exercise

* Separation of Concerns: Extract business logic from step definitions. Keep the test code focused on expressing the intended behavior without diving into implementation details. Create separate utility methods or helper classes to encapsulate business rules.
* Leverage Page Objects: Use page objects to encapsulate interactions with the UI, reducing the amount of business logic in step definitions.
* Dependency Inversion: Introduce a test design where the test implementation defines interfaces to be fulfilled by utilities or drivers. By applying the principles of dependency inversion, you enable easy exchange of the test object (e.g., REST service instead of UI) while maintaining a clean separation between test code and SUT.

