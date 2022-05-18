# DependencyInjectionDemo
Add Dependency Injection to a common Console App

This project shows how it is easy to add Dependency Injection into a common Console Application project.

In only 5 commits, I could do it, and I'm sure that you can do it too:

**First commit (bd350b1af1b68664d6c6abfdeedae4de36f79c52):**

The project doesn't have Dependency Injection. 
It contains a BusinnessLogic class that depends on two Utilities classes: Logger and DataAccess

**Second commit (8040df835145bfa2c041b01d40e71e8292d3d5d8):**

I added Interfaces to the utilities classes and added that interfaces into the constructor of the BusinnessLogic class. 
In that way, when the BusinnessLogic class is initializes, it will automatically reference to the classes

**Third commit (6eb70bb8c703827911fef98a91da04375708d739):**

I added the Autofac package to help me implement Dependency Injection.
Then I create the interface of the BusinnessLogic class.
Then I added a new class called ContainerConfig that initialize all classes, relating interfaces to their classes.

**Fourth commit (ffb0853021a468ca6c6db20313a679748fbda28d):**

I created a new Class and its Interface called Application.
This class will be responsible for initialize the BusinnessLogic, using the method Run.

**Fifth commit (ed5873df86b7be9ba96a1e8ac989c920b72f0b97):**

The ContainerConfig class will initialize the Application class.
The program class (the main class) will start configuring the Container and then, by the Application class, will call the
BusinnessLogic, instead of calling the BusinnessLogic directly.

## Thank you @TimCorey for the Tutorial: https://youtu.be/mCUNrRtVVWY


