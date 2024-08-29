Cucumber Disease #7 - "Rotting Steps"

## Description
“Rotting Steps” refer to Gherkin steps within a scenario that lack meaningful purpose or relevance.
These steps may have empty implementations or contribute nothing substantial to the scenario.
They often appear in “Given” steps, where they set up initial conditions but fail to add value.

## Impact
* Scenario Clutter: Unnecessary steps make scenarios harder to read and understand.
* Maintenance: Empty or irrelevant steps require unnecessary upkeep.
* Misleading Intent: Readers may assume these steps play a crucial role when they don’t.

## Your task
Eliminate steps that don’t contribute to the behavior being tested. Indicators are:
* "Given" step used only once and implicitly setup,
* "Given" steps covered already by a "Background" step
* or empty implementations