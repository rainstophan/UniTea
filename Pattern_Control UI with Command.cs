//The command pattern is a design pattern that is used to encapsulate a request or command as an object, allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations. It allows you to separate the implementation of a request from its execution, making it easier to change the implementation or add new requests without modifying the client code.
// Usage: such as inventory items that can be used to perform actions, or buttons that execute specific actions when clicked.

public interface IItem
{
    void Use();
}

public class HealthPotion : IItem
{
    public void Use()
    {
        // Restore health logic
    }
}

public class Bomb : IItem
{
    public void Use()
    {
        // Explode logic
    }
}

public class Key : IItem
{
    public void Use()
    {
        // Unlock door logic
    }
}

//***
public class UseItemCommand : ICommand
{
    private IItem item;

    public UseItemCommand(IItem item)
    {
        this.item = item;
    }

    public void Execute()
    {
        item.Use();
    }
}
// ***
IItem healthPotion = new HealthPotion();
ICommand useHealthPotionCommand = new UseItemCommand(healthPotion);

IItem bomb = new Bomb();
ICommand useBombCommand = new UseItemCommand(bomb);

IItem key = new Key();
ICommand useKeyCommand = new UseItemCommand(key);

// ***
useHealthPotionCommand.Execute();
useBombCommand.Execute();
useKeyCommand.Execute();
