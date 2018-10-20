# InvokableCallback
Lets you drag-and-drop methods with or without return values / parameters in the Unity inspector.
It uses expression trees and reflection to cache a delegate on first execution.

## Getting started

These instructions will get you a dll file with all code from SerializableCallback.

#Creating DLL
To create a DLL, you will first need a suitable compiler. Not all compilers that produce .NET code are guaranteed to work with Unity, so it may be wise to test the compiler with some available code before doing significant work with it. If the DLL contains no code that depends on the Unity API then you can simply compile it to a DLL using the appropriate compiler options. If you do want to use the Unity API then you will need to make Unity’s own DLLs available to the compiler. On a Mac, these are contained in the application bundle (you can see the internal structure of the bundle by using the Show Package Contents command from the contextual menu; right click or ctrl-click the Unity application):-

The path to the Unity DLLs will typically be
```
/Applications/Unity/Unity.app/Contents/Managed/
```

## Managed bytecode stripping with IL2CPP
This library was written to prevent code stripping by IL2CPP for iOS platform.
The link.xml file (described below) can be used to effectively disable bytecode stripping by preserving both types and full assemblies.

```xml
<linker>
       <assembly fullname="InvokableCallback" preserve="all"/>
</linker>
```


### Built based on

* [SerializableCallback](https://github.com/Siccity/SerializableCallback)
