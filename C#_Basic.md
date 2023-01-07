- class
  - interface
  - abstract class : any class that subclasses from an abstract class must fully implement all variables and methods marked with the abstract keyword
  - Diff: Interfaces will allow you to spread and share pieces of functionality between unrelated objects, leading to a Lego-like assembly when it comes to your code. Abstract classes, on the other hand, will let you keep the single-inheritance structure of OOP while separating a class's implementation from its blueprint. These approaches can even be mixed and matched, as abstract classes can adopt interfaces just like non-abstract ones.
- sturct(same as light class, with constant values, acssed by values instead of references)


- public, private, protected (access by child), internal


- const(unmodifiable value,  assign its initial value when declare), 
- readonly(unmodifiable value, can assign its initial value at any time.), 
- static(not all classes need to be instantiated, and not all properties need to belong to a specific instance),
  - StaticUtilitieClass.RestartLevel();
- abstract, 
- overide


- Dic<,>, List<> (not sequential), Array
- Stack
  - Push, Peek, Pop, Clear, Contains, 
  - TryPeek and TryPop
- Queue, 
  - Enqueue, Peek, Dequeue
- HashSet (it cannot store duplicate values and is not sorted, meaning its elements are not ordered in any way)
   - Add, Remove
   - activePlayers.**UnionWith**(inactivePlayers);
   - activePlayers.**IntersectWith**(premiumPlayers);
   - activePlayers.**ExceptWith**(premiumPlayers);
