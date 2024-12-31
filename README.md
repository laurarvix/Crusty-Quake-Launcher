# Minty Launcher
A C# WinForms Doom launcher I made as I hadn't liked others like ZDL or Doom Launcher.
This is build for my purposes and features will usually be added when I need/want them. 

The repo exists for others to take from the code and make their own forks.

# Downloading
You can get prebuilt, Framework-Dependant Win64 bins from the Google Drive, as well as a premade port database file and the user manual. Due to limitations with WinForms, I am sadly unable to provide native Linux bins.

# Building
No dependencies are required besides DiscordRichPresence from NuGet and its dependencies as well as WinForms and .NET 6.
Open the solution in Visual Studio 2022.
Create a `Resources.resx` file in the `Properties` folder with a key called `DiscordApi` and put in your own Discord application ID for its value.

Build the solution from VS2022 from there.
