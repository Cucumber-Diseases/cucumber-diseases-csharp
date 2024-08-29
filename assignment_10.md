# Cucumber Disease #7 - "Hardcoded Parameters"

## Description
“Hardcoded Parameters” occur when Gherkin scenarios use fixed, literal values instead of parameters or placeholders.
Instead of leveraging reusable parameters, steps directly reference specific values.
This leads to redundancy, as multiple steps end up performing the same action with hardcoded data.

## Impact
* Duplication: Steps with identical hardcoded values create unnecessary repetition.
* Maintenance: If a value changes, you must update it in multiple places.
* Readability: Non parameterized steps reduce the scenario readability. Parameterization allows flexibility and reusability.

## Your task

TODO: describe details of exercise

* Parameterize: Implement a new step with placeholders and parameters for dynamic values. Replace all hardcoded steps with the new step and remove the previous step implementations.
* Reuse Existing Steps: If a parameterized version exists, ensure consistent usage.
* Merge similar scenarios to a 'Scenarion Outline'