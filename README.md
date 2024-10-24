# oop-principles-c-sharp
This respository is intended for my submission 2 from the Unity Learn Junior Programmer pathway

Here I'll be practicing the four pillars of object-orienting programming: Abstraction, Inheritance, Polymorphism and Encapsulation

Below you can find a short description of each of them:

## Abstraction

The abstraction principle states that each object created must implemented only necessary information for the context of the application. 

For example, an address might be composed of lots of information, so we could use a string variable to store it or lots of single fields, such as street name, city, state, zipcode, etc.; 

However, an application which is connected to google maps, might only need the zipcode to locate that address, therefore we could only implement a single string variable and limit its setter to 8 chars which are enough to define a zipcode here in Brazil.

## Inheritance

The inheritance principle states that we don't have to define from scratch objects that share the same attributes or functionalities. We can create a base class and child classes which would inherit the behavior from the base class.

For example, when making a game, we can have lots of different enemies that would share the same attributes, such as life and damage output, and some behaviors, such as walking and attacking. However, different types of enemy might attack and differently and have different values for the damage output. 

In this use case, we can create a base class named Enemy which would define the shared attributes and child classes, such as GoblinEnemy and GhostEnemy. Both child classes could redefine the value for the damage output variable and the return value of and Attack() method.

## Polymorphism

The polymorphism principle states that a defined behavior can return different values or define different parameters in different objects.

We are going to exemplify with the same example above.

Given our Enemy, GoblinEnemy and GhostEnemy, when we only define the Attack() method in the base class and implement it in the GoblinEnemy and GhostEnemy, we have an override of the method Attack().

Likewise, we can have the same Attack() but with different parameters. Let's say we have an Attack() method with no parameter and an Attack(Weapon weapon) method with a weapon parameter in order to attack with a weapon. This is called and overload, since we have the same method with a different signature.

## Encapsulation

The encapsulation principle states that a given attribute or method should only be accessible to the class which defines it and a limited number of other classes, such as child classes. This way, the flow of information is consistent and we can easily debug when something is not right.

Using the same example, a GoblinEnemy's life can be accessed by many other classes, but it should limit the write-access to it, since not every class can set the value of the Goblin's life.
