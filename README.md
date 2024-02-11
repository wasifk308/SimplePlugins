# Create C++ plugins for Unity3d 

This will help you to Understand how to create Plugins for Unity3d with the help of other languages.


Part 1:

Let us understand how you can easily create simple c++ plugins for unity3d.

First of all you need to create C++ DLL , for this you can use Visual Studio or you can choose any other tool.

1) Create a DLL Project in VS.

2) Create a custom header and  cpp file. For the refference you can check the Folder.

3) Select the Target Plateform and Configuration in the VS for which the DLL must compiled. For me  I am using target Plateform : x64 arch and Cofiguration type : Debug.

4) Final Step Build the solution.


How you can use this DLL in Unity?

1) After you have created a DLL , You need can create a Unity Project.

2) Create a Plugins/x64 folder in Asset folder and add the DLL . For more infomration regarding Special Folder check out unity link.
https://docs.unity3d.com/2017.2/Documentation/Manual/SpecialFolders.html

3) Next you can check the SimplePlugin.cs file to use DLL methods.











