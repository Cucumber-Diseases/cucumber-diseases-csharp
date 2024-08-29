# Diagnosis and Treatment of Cucumber Diseases in Java with Cucumber

Can you spot the Cucumber Diseases in this code? We’ll explore the code smells lurking in Gherkin and [Reqnroll](https://reqnroll.net/). 🧪👃 These subtle yet impactful issues can creep into our test scenarios, affecting readability, maintainability, and overall quality.

Refactor this code, take small steps, run the tests often. See how small and beautiful can make it.

## Installation
For the workshop .NET 8 or later is a pre-requisite for building und runnnig the Gherkin features. It needs to be installed before the local setup.

### Microsoft Visual Studio 2022
Our **recommendation** for C# and .NET development is to use Microsoft Visual Studio 2022 and the **the Reqnroll extension**. By installing the Reqnroll extension you add features like Gherkin syntax highlighting, navigation between Gherkin and step definitions, ... 
A detailed decription of features and the [installation & setup guideline](https://docs.reqnroll.net/latest/installation/setup-ide.html) is available on the Reqnroll web pages.

1. Either clone the repository locally via command line or in Microsoft Visual Studio 2022:
   - Open **Microsoft Visual Studio 2022**.
   - Go to **File** > **Clone Repository**.
   - Paste the repository URL into the **Repository Location** field and click **Clone**.
   
2. Open the solution in Visual Studio after cloning.
3. Build the solution to ensure all dependencies are resolved.
4. Run the Gherkin tests to verify functionality.

### Visual Studio Code

> [!NOTE]
> The integration for building and running Gherkin tests in VS Cosde is less seamless compared to Microsoft Visual Studio and the Reqnroll extension, which provides a more features for C# and .NET development.

There is a similar installation procedure for VS Code like for Microsoft Visual Studio 2022.

1. Either clone the repository locally via command line or in Visual Studio Code:
   - Open **Visual Studio Code**.
   - Open the **Command Palette** (`Ctrl+Shift+P`), then select **Git: Clone**.
   - Paste the repository URL when prompted and select a local directory to clone the repository.

2. Open the cloned repository folder in Visual Studio Code.

3. Install the **Cucumber (Gherkin) Full Support** extension from the VS Code Marketplace for Gherkin syntax support.

4. Build the solution using the terminal or the integrated build tasks.

5. Run the Gherkin tests via the terminal or test explorer.


#### Platform notes

> [!IMPORTANT]
> The VC Code Cucumber extension fails on any Unix distribution. It's recommended to use VS Code on Windows.
>
> Restrictions of missing Cucumber extension on Unix:  <br>
> * You won't have Gherkin support
> * You can't generate step definition
> * There is NO linkage between your feature files and step definition implementation
> * You are still able to edit all file and execute your Unit Tests.
> 
   
### gitpod.io

<a href="https://gitpod.io/#https://github.com/Cucumber-Diseases/cucumber-diseases-csharp" target="_blank"> 
<img src="https://gitpod.io/button/open-in-gitpod.svg" alt="Open in Gitpod">
</a> <br>

> [!IMPORTANT]
> Since Gitpod VS Code Browser uses Linux, the same restrictions as on any other Unix distribution apply.
> 
> Additionally, Gitpod VS Code Browser does not support the official C# extension, which means you’ll be missing key features like unit test support and the solution explorer.

> [!NOTE]
> If you like to use Gitpod for .NET, the recommended solution is [Gitpod with VS Code Desktop](https://www.gitpod.io/docs/references/ides-and-editors/vscode). 

## 📝 Refactoring Exercises

The code in the `main` branch contains multiple Cucumber smells. The smells can be removed by a variety of refactoring exercises. It's recommended to follow the suggested order. 

Look at our [Code Smells Documentation](https://cucumber-diseases.github.io/exercise/) for a detailed introduction to all exercises.

