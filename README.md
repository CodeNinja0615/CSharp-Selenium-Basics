# 🚀 Automation Journey with C#, Selenium, NUnit, Appium & APIs

![.NET](https://img.shields.io/badge/.NET-6.0-blueviolet)
![NUnit](https://img.shields.io/badge/NUnit-Testing-blue)
![Selenium](https://img.shields.io/badge/Selenium-WebDriver-green)
![Appium](https://img.shields.io/badge/Appium-Mobile--Automation-purple)
![RestSharp](https://img.shields.io/badge/API-Testing-orange)
![CI/CD](https://img.shields.io/badge/CI%2FCD-Ready-green)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

A comprehensive learning repository for mastering **Automation Testing** with **C#**, covering **Selenium WebDriver**, **NUnit**, **Appium** for mobile automation, and **API testing** using .NET tools. This project is also **CI/CD-ready** for Jenkins and Azure DevOps.

---

## 📚 What You'll Learn

- ✅ Selenium WebDriver automation with C#
- ✅ Test structuring and assertions using NUnit
- ✅ Mobile automation using Appium (.NET Bindings)
- ✅ API testing with RestSharp / HttpClient
- ✅ Page Object Model (POM) implementation
- ✅ Config-driven execution using `App.config`
- ✅ Parallel execution and test categorization
- ✅ CI/CD pipeline integration with Jenkins & Azure

---

## 🏗️ Project Structure

```
AutomationWithCSharp/
│
├── Selenium/             → Selenium test case examples(UI)
├── Appium/               → Appium test case examples(UI)
├── ApiTesting/           → Api test case examples
├── Drivers/              → WebDriver/Appium setup
├── TestData/             → JSON test data
├── App.config            → Central configuration
└── README.md             → Project documentation
```

---

## ⚙️ Configuration (`App.config`)

```xml
<appSettings>
  <add key="browser" value="chrome" />
  <add key="platform" value="web" /> <!-- web | mobile | api -->
  <add key="baseUrl" value="https://your-app-url.com" />
</appSettings>
```

---

## 💻 Running Tests via CLI

Make sure .NET 6 SDK is installed.

### ▶️ Run All Tests

```bash
dotnet test
```

### 🔍 Run by Category

```bash
dotnet test --filter TestCategory=API
```

### 🧪 Run a Specific Test

```bash
dotnet test --filter FullyQualifiedName=Namespace.Class.Method
```

---

## 📲 Appium Mobile Testing

- Supports Android automation
- Appium server setup and capabilities via config or environment variables
- Handles app launch, activity, and teardown

---

## 🌐 API Testing Support

- Using `RestSharp` or `HttpClient`
- Validates status codes, headers, and JSON responses
- Can include Auth (Bearer/OAuth2)

---

## 🔄 .csproj Configuration

```xml
<ItemGroup>
  <None Update="TestData\*.json">
    <CopyToOutputDirectory>Always</CopyToOutputDirectory>
  </None>
</ItemGroup>
```

---

## ☁️ CI/CD Integration

### ✅ Jenkins

- Use `dotnet test` in build steps
- Add parameters for browser/platform
- Output test reports (e.g., Allure, NUnit XML)

### ✅ Azure DevOps

- YAML pipeline with `restore`, `build`, and `test` steps
- Filter test categories per stage

---

## 📊 Reporting Support

- **Allure Reports**
- **ExtentReports**
- **ReportUnit**

### Example:

```bash
dotnet test --logger:"allure;logfilepath=allure-results"
```

---

## 🤝 Contributing

This is a personal learning repository, but contributions and ideas are welcome. Feel free to open issues or pull requests.

---

## 📄 License

Licensed under the MIT License.
