# Cucumber Disease #1 - "Missing Then Implementation":

## Description
This smell refers to steps within your Gherkin scenarios that lack assertions (specifically, “Then” steps).
When you encounter a step without an assertion, it means that the scenario doesn’t verify any expected outcome or behavior.
Essentially, it’s like having a test case without an assertion in your test suite.

## Impact
* Without assertions, your scenarios may not effectively validate the system’s behavior.
* Unverified steps can lead to false positives (where a scenario passes even if it shouldn’t).
* It undermines the purpose of behavior-driven development (BDD) because the scenarios don’t provide meaningful feedback.

## Your task
Identify all steps within your Gherkin scenarios that lack assertions. Then, choose one of these steps to implement the missing assertion.

Decide which criteria apply and select the step depending on your answers:
* Simplicity: Selected for a straightforward  step
* Relevance: Ensure that the selected step makes sense in your scenarios
* No Further Improvement Needed: Confirm that there’s no additional enhancement required for the chosen step.
*Reverse Implementation: Check if there’s another “Then” step that expresses the opposite behavior