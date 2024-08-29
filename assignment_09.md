# Cucumber Disease #9 - "Dead Steps"

## Description
“Dead Steps” refer to step implementations that exist within your codebase but are not used by any feature file.
These steps may have been created for various reasons (e.g., experimentation, incomplete scenarios, or refactoring) but are now obsolete.
Detecting and removing them can be challenging because they don’t contribute to any scenario.

## Impact
* Maintenance: Dead steps clutter your test codebase, making it harder to maintain.
* Confusion: Developers and testers may wonder why certain steps exist without corresponding scenarios.
* Risk of Misuse: If someone accidentally uses a dead step, it can lead to false positives or negatives in test results.

## Your task
Search fo the "Dead Steps" in the step implementation file. Either use the tools provided in your IDE or the search functionality. Delete the unused steps from the code and commit your chnages.  

In your daily business periodically review your step definitions and remove unused ones. Use version control history to identify steps that were once relevant but are no longer needed.
