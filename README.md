# Starting C# from Scratch: A Beginner's Guide

## Introduction

- **C#** is a programming language used to build a wide range of applications.
- It is an **object-oriented programming language**, which means it focuses on objects and classes to create reusable code.
- C# is a **strongly typed language**, enforcing type safety, which helps catch errors during compile time.
- It is a **multi-paradigm language**, supporting various programming styles such as imperative, declarative, functional, and event-driven programming.
- C# is **platform-independent**; applications can run on different platforms using the .NET framework.

## How to Start a C# Project

1. Download [Visual Studio Community 2022](https://visualstudio.microsoft.com/).
2. Follow the installation instructions to set up Visual Studio on your system.
3. Once installed, launch Visual Studio and create a new project.
4. Select **C#** as your programming language and choose a project template (e.g., Console App, Windows Forms App, etc.).
5. Start coding and building your application!

## How to push the code to GitHub

1. Keep in mind that you need to **initalize** an empty repository in the same path as the `.sln` file in your project.
2. This is usually found in the **1st level below** the main directory
3. After initializing your empty repository, **close** the `Visual Studio 2022` app and the perform these steps in your terminal:

```bash
git add.
git commit -m "Initial commit"
git push origin <your-branch>
```

## How to Open an already existing C# Project

Open the `.sln` file in Visual Studio.

## OOPs Concepts in CSharp

### Properties of OOPs

- **Class**: A blueprint for creating objects.
- **Object**: An instance of a class.

```csharp
class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine("Car started!");
    }
}

Car myCar = new Car();
```

- **Encapsulation**: Bundling data (properties) and methods (functions) that operate on the data into a single unit (class).
  - **Access Modifiers**: Control the visibility of classes, properties, and methods.
    - `public`: Accessible from anywhere.
    - `private`: Accessible only within the same class.
    - `protected`: Accessible within the same class or derived classes.
    - `internal`: Accessible within the same assembly.
    - `protected internal`: Accessible within the same assembly or derived classes.
    - `private protected`: Accessible within the same assembly or derived classes.

- **Abstraction**: Hiding the complexity of the implementation and showing only the essential features of an object.
  - **Abstract Classes**: Classes that cannot be instantiated and may contain abstract methods.
  - **Interfaces**: Define a contract for classes to implement.

- **Inheritance**: A mechanism where a new class inherits properties and methods from an existing class.

- **Polymorphism**: The ability of an object to take on multiple forms.
  - **Method Overloading**: Defining multiple methods with the same name but different parameters.
  - **Method Overriding**: Redefining a method in a derived class.

### Example of Inheritance and Polymorphism

```csharp
class Animal
{
    public virtual void MakeSound() // virtual keyword allows method overriding
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound() // override keyword redefines the method
    {
        Console.WriteLine("Dog barks");
    }
}
```

### Using Interfaces

```csharp
interface IShape
{
    double GetArea();
}

class Circle : IShape
{
    public double Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
```
