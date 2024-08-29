# Cucumber Disease #8 - "Singular/Plural Logic Clones"

## Description
This code smell occurs when there are multiple, nearly identical implementations of step definitions to handle singular and plural cases. These implementations often share similar logic but differ only in the handling of singular and plural nouns. The underlying idea is akin to the “Don’t Repeat Yourself” (DRY) principle, which encourages code reuse and consolidation.

## Impact
* Readability: The code becomes less readable and harder to understand due to the duplication.
* Maintainability: Changes to the underlying logic must be applied to multiple step definitions, increasing maintenance effort.
* Complexity: The codebase becomes more complex and harder to manage with redundant implementations.
* Consistency: Inconsistent parameter handling syntax can lead to errors and inconsistencies.

## Your task

TODO: describe details of exercise

* **Combine Step Definitions**: Merge the singular and plural step definitions into a single definition with multiple expressions and using parameterization to handle variations.
* **Use Regular Expressions / Leverage Parameter Handling**: Consider using regular expressions or custom parameter types to handle dynamic values effectively.
* **Ensure Consistent Syntax**: Standardize the parameter handling syntax across all step definitions to improve readability and maintainability.

