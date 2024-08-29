# Cucumber Disease #4 - "Redundant Mirror Image":

## Description
The “Redundant Mirror Image” code smell involves code duplication within your Gherkin scenarios.
When the same implementation logic appears multiple times with different expressions, consider consolidating it into reusable expressions.
Even if the expressions seem completely mismatched (representing opposite behaviors, such as success and failure cases), both scenarios verify the same behavior.

## Impact
* Maintenance: Any change to one step affects all implementations.
* Risk of Inconsistency: If one side of the mirror image is updated without considering the other, scenarios may become inconsistent.

## Your task
Identify steps that share the same implementation but describe asymmetric behavior. If you find such steps, consider consolidating them by using multiple expressions for a single implementation.