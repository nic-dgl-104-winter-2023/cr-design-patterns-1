This is to document the functionality of brandon-java.java file.

Implementating this pattern limits the user to 1 instance of a Deck

How it works:

Declaring constructors to be private, this stops this instance from being instantiated by other objects
Using a static method returning a reference to the instance
The instance stored as a private static variable. 
The instance is created when the variable is initialized before the static method is first called.