# crystisDesktopNet Example Application

This repository demonstrates how to integrate Crystal Reports into .NET desktop applications using **CrystisDesktop**,
a powerful tool designed for Windows Forms and WPF developers.

## About CrystisDesktop
CrystisDesktop is a .NET library that allows you to display Crystal Reports directly within your desktop applications
without requiring additional installations. Everything needed to render reports is embedded within **CrystisDesktop.dll**.

### **No Additional Installations Required**
One of the key benefits of **CrystisDesktop** is that you **do not need to install Crystal Reports or Crystal Reports Runtime**.
The library unpacks and integrates all necessary dependencies automatically when first used.

## Features
- Display Crystal Reports seamlessly in .NET desktop applications.
- No need to install Crystal Reports or its runtime.
- Automatic unpacking of required dependencies.
- Uses **WebView2** for rendering reports inside the application.
- Lightweight and easy to integrate.

## Getting Started

### Prerequisites
1. .NET Framework or .NET Core compatible with Windows Forms or WPF applications.
2. **No need to install Crystal Reports or its runtime** – everything is handled by **CrystisDesktop.dll**.

### Required Files
To use **CrystisDesktop**, you only need to include **CrystisDesktop.dll** in your application's **bin\Debug** directory.

Upon first use, **CrystisDesktop.dll** automatically unpacks and adds the following embedded dependencies:
- `Microsoft.Web.WebView2.Core.dll`
- `Microsoft.Web.WebView2.WinForms.dll`
- `Newtonsoft.Json.dll`
- `WebView2Loader.dll`

These files will be placed in the **bin\Debug** directory alongside your main executable.

### Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/siteknower/crystisDesktopNet.git
   cd crystisDesktopNet
   ```

2. Copy **CrystisDesktop.dll** from this repository to your project's **bin\Debug** folder.

3. Place your `.rpt` files (Crystal Reports) in the same directory as your application executable (e.g., **bin\Debug**).

### Quick Start Example
Below is a simple example demonstrating how to integrate **CrystisDesktop** into a Windows Forms application.

```csharp
using System;
using System.Windows.Forms;
using CrystisDesktop;

namespace CrystisDemo
{
    public partial class MainForm : Form
    {
        private Crystal cs = new Crystal();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            cs.tcode = "DEMO1";  // Your account code
            cs.tucode = "0000";  // Your user code
            cs.trptfilePath = "CustomerReport1.rpt";  // Report file in bin\Debug
            cs.tDEST = "0";  // Display the report on screen

            cs.showReport();
        }
    }
}
```

### Key Points
1. **Single DLL Integration**: Simply include `CrystisDesktop.dll` in your project.
2. **Automatic Dependency Unpacking**: When the application first runs, the necessary dependencies are extracted automatically.
3. **Report Placement**: Ensure that your `.rpt` files are placed in **bin\Debug** alongside your application executable.
4. **Easy Report Display**: Set report parameters and call `cs.showReport()` to render the report.

### Running the Application
Run your application, and click the button to display the report.

## Repository Usage
Feel free to use this repository as:
- A guide to integrating Crystal Reports into your .NET desktop application.
- A base for building your own reporting solutions.

## Advertising CrystisDesktop
This repository showcases the unique capabilities of **CrystisDesktop**. Its seamless integration with .NET desktop applications
makes it an essential tool for developers looking for advanced reporting solutions without extra dependencies.

## License
This repository is licensed under the MIT License (LICENSE).

## About Us
This project is maintained by **[Siteknower](https://www.siteknower.com)**. For more information about our services, please visit our website.

## Contact
If you have questions, feel free to reach out through our [contact page](https://www.siteknower.com/contact).

