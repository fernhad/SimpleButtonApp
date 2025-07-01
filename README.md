"# Simple VB.NET Button App" 

Prerequisites;
make sure you have the following tools installed on your system especiall for windows users
  - .NET SDK 6.0 or later
  - Visual Studio Code
  - (Optional) Git for windows for version control
  - (Option) Windows Forms support via .NET SDK
Once you download the whole package, you will need to remember the path to which you have saved the package.

Getting started;
-Follow these steps to run the app from sources:
# 1. Clone the repository
git clone https://github.com/fernhad/SimpleButtonApp.git

# 2. Navigate to the project directory
cd SimpleButtonApp/SimpleButton

# 3. Restore any dependencies (optional)
dotnet restore

~YOU MIGHT WANT TO MAKE CHANGES TO Fomr1.vb //MessageBox.Show("<$>")

# 4. Build the project
dotnet build

# 5. Run the app
dotnet run

=================================================================================
=========== Result ==============================================================
A Windows Form app will launch with a single button labeled "Click Me". When clicked, it displays a message box that says:

Hello, Emmanuel!



