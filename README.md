# Crystis DesktopNet - Crystal Reports for .NET desktop

This repository demonstrates how to integrate Crystal Reports into .NET desktop applications using **CrystisDesktop**,
a powerful tool designed for Windows Forms and WPF developers.

🔗 **Additional features & Troubleshooting, :** [Read More](https://www.siteknower.com/crystis-desktop.net)

## About crystis for Desktop NET
CrystisDesktop is a .NET library that allows you to display Crystal Reports directly within your desktop applications
without requiring additional installations. Everything needed to render reports is embedded within **CrystisDesktop.dll**.

### **No Additional Installations Required**
One of the key benefits of **CrystisDesktop** is that you **do not need to install Crystal Reports or Crystal Reports Runtime**.

In addition, the library unpacks and integrates all necessary dependencies automatically when first used.

### Key Features
- Seamless integration of Crystal Reports into .NET desktop applications.
- **No additional installations required:** Everything is handled by `CrystisDesktop.dll`.
- The library automatically extracts required files when first used:
  - `Microsoft.Web.WebView2.Core.dll`
  - `Microsoft.Web.WebView2.WinForms.dll`
  - `Newtonsoft.Json.dll`
  - `WebView2Loader.dll`
- Supports placing `.rpt` report files directly in the application directory.

## Getting Started

### Prerequisites
1. .NET Framework or .NET Core compatible with Windows Forms or WPF applications.
2.  Access to an account at siteknower.com (https://www.siteknower.com) to obtain your account code and user code.
    - Demo account code (`DEMO1`) and user code (`0000`) are used in these examples to display demo data.
3. **No need to install Crystal Reports or its runtime** – everything is handled by **CrystisDesktop.dll**.

### Cloning the Repository
When you clone the `crystisDesktopNet` repository, you get a **fully functional desktop .NET application**. No changes are needed—simply open `CrystisDesktopNet.csproj` in Visual Studio, and everything works out of the box.

**Steps:**
1. Clone the repository:
   ```bash
   git clone https://github.com/siteknower/crystisDesktopNet.git
   cd crystisDesktopNet
   ```
2. Open `CrystisDesktopNet.csproj` in Visual Studio.
3. Run the application—everything is preconfigured.

## Integrating CrystisDesktop into a New Project
To use **CrystisDesktop** in your own desktop application, install it via **NuGet**:
   ```bash
  Install-Package Crystis.DesktopNet
   ```
This will automatically include CrystisDesktop.dll in your project.

Alternatively, if you prefer **manual installation**, you can:

1. Download `CrystisDesktop.dll` from this repository.
2. Copy it to your project's `bin\Debug` directory.
3. Add it as a reference in Visual Studio.

## Placing Report Files (`.rpt`)
- Place your **Crystal Reports** (`.rpt` files) in the **same directory as your executable** (bin\Debug during development).
- This ensures that CrystisDesktop.dll can locate and load them properly.

## First 30 Days Free
- To use CrystisDesktop, you need an account code and user code from [Siteknower](https://www.siteknower.com/).
- When you sign up, you get 30 days free with your own account code.
- If you don’t have an account yet, you can test with:
    - **Account Code**: DEMO1
    - **User Code: 0000** (for demo data only)

## Deployment
For end-users running the final application, ensure that `CrystisDesktop.dll` and all `.rpt` files are placed in the **same directory as the application executable**. This ensures proper functionality without additional configurations.

## Running the Application
1. **During development:**
   - Ensure `CrystisDesktop.dll` and `.rpt` files are in `bin\Debug`.
   - Run your application from Visual Studio.
2. **For deployed applications:**
   - Ensure `CrystisDesktop.dll` and `.rpt` files are in the same directory as the `.exe` file.

### Quick Start Example
Below is a simple example demonstrating how to integrate **CrystisDesktop** into a Windows Forms application.

```csharp
using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using CrystisDesktop;

namespace CrystisDemo
{
    DataSet dsCustomers = new DataSet();

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string filename = "schema.xml";  //in this example the schema is used to create a dataset
          
            using (System.IO.FileStream stream = new System.IO.FileStream(filename, System.IO.FileMode.Open))
            {
                dsCustomers.ReadXmlSchema(stream);
            }

            GetData();
        }

         private DataSet GetData()
         {
             DataTable dt = dsCustomers.Tables["Users"];
             dt.Rows.Add("ABDEN", "Maria Weiss", "Berlin", "Germany");
             dt.Rows.Add("AXEIS", "Pedro Alvarez", "México D.F.", "Mexico");
             dt.Rows.Add("BENOI", "Anna Tóth", "Szeged", "Hungary");
             dt.Rows.Add("CAZLE", "Jan Eriksson", "Mannheim", "Sweden");
             dt.Rows.Add("DRFOS", "Giulia Donatelli", "Milano", "Italia");
             return dsCustomers;
         }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            clsCrystisClass tsi = new clsCrystisClass();

            tsi.AccountCode = "DEMO1";  // your account code
            tsi.UserCode = "0000"; // yout user code
            tsi.dsRPT = dsCustomers;
            tsi.DEST = 0;

            string rptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomerReport1.rpt");
            tsi.ReportFullName = rptPath;

            tsi.ShowForm();
        }
    }
}
```

### Key Points
1. **Single DLL Integration**: Simply include `CrystisDesktop.dll` in your project.
2. **Automatic Dependency Unpacking**: When the application first runs, the necessary dependencies are extracted automatically.
3. **Report Placement**: Make sure your `.rpt` files are placed alongside your application's executable.
4. **Easy Report Display**: Set report parameters and call `tsi.ShowForm();` to render the report.
5. Alternatively, you can get the URL of the report with **string tgetReportUrl = tsi.getReportUrl();** and display it in your application in some other way.

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

