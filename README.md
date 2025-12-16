# DevNooTools

A comprehensive C# Windows Forms application designed to streamline development workflows with an intuitive interface and powerful database management capabilities.

## 📋 Overview

DevNooTools is a desktop application built with . NET Framework that provides developers with a suite of tools for managing products and database operations. The application features a modern UI with custom rounded controls and integrates with Supabase for cloud database functionality.

## ✨ Features

### Database Management
- **Supabase Integration**: Seamless connection to Supabase PostgreSQL databases
- **Product CRUD Operations**: Complete Create, Read, Update, and Delete functionality for product management
- **Database Helper Utilities**: Simplified database operations through a dedicated helper class
- **SQL Setup Scripts**: Pre-configured database setup scripts for quick deployment

### User Interface
- **Custom Rounded Controls**: Modern, aesthetically pleasing UI components
- **Windows Forms Application**: Native Windows desktop experience
- **Responsive Design**: Clean and intuitive interface for efficient workflow

### Data Management
- **Product Repository Pattern**: Organized data access layer for maintainability
- **Model-based Architecture**:  Structured data models for type-safe operations
- **Form-based Data Entry**: User-friendly forms for data input and management

## 🛠️ Technology Stack

- **Language**: C# (.NET Framework)
- **UI Framework**: Windows Forms
- **Database**: PostgreSQL (via Supabase)
- **Package Management**: NuGet
- **License**: GNU General Public License v3.0

## 📁 Project Structure

```
DevNooTools/
├── DevNooTools/
│   ├── Data/              # Data access layer
│   ├── Forms/             # Additional form components
│   ├── Models/            # Data models
│   ├── Properties/        # Project properties
│   ├── DatabaseHelper.cs  # Database utility class
│   ├── Product.cs         # Product model
│   ├── ProductRepository.cs # Product data access
│   ├── RoundedControls.cs # Custom UI controls
│   ├── Form1.cs           # Main application form
│   └── Program.cs         # Application entry point
├── supabase_setup.sql     # Database initialization script
└── LICENSE                # GPL-3.0 License
```

## 🚀 Getting Started

### Prerequisites

- .NET Framework 4.x or higher
- Visual Studio 2019 or later
- Supabase account (for database functionality)

### Installation

1. Clone the repository: 
```bash
git clone https://github.com/Gustafigz0/DevNooTools. git
```

2. Open the solution file `DevNooTools.slnx` in Visual Studio

3. Restore NuGet packages:
```bash
nuget. exe restore
```

4. Configure your Supabase connection in `App.config`

5. Run the `supabase_setup.sql` script in your Supabase project to set up the database schema

6. Build and run the application

## 🔧 Configuration

Update the `App.config` file with your Supabase credentials and connection settings before running the application.

## 📝 Usage

1. Launch the application
2. Use the main form to navigate through different tools
3. Manage products using the CRUD interface
4. Perform database operations through the integrated database helper

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request. 

## 📄 License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE](LICENSE) file for details.


## 🔗 Links

- Repository: [https://github.com/Gustafigz0/DevNooTools](https://github.com/Gustafigz0/DevNooTools)

---

*Last updated: December 2025*
